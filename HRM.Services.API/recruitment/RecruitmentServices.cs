using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services.API.recruitment
{
    public class RecruitmentServices : IRecruitmentServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<RecruitmentServices> _logger;

        public RecruitmentServices(ApplicationDbContext context, ILogger<RecruitmentServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all recruitments
        public async Task<ServiceResult<IEnumerable<Recruitment>>> GetRecruitments()
        {
            try
            {
                var data = await _context.Recruitments
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Recruitment>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Recruitment>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all recruitments.");
                return ServiceResult<IEnumerable<Recruitment>>.FailedResult(ex.Message);
            }
        }

        // Fetches recruitments that match the search text
        public async Task<ServiceResult<IEnumerable<Recruitment>>> GetRecruitmentsByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<IEnumerable<Recruitment>>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Recruitments
                    .Where(x => x.RecruitmentPosition.ToLower().Contains(text.ToLower())
                        || x.Status.ToLower().Contains(text.ToLower())
                        || x.RecruitmentDescription.ToLower().Contains(text.ToLower()))
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Recruitment>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Recruitment>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching recruitments by text.");
                return ServiceResult<IEnumerable<Recruitment>>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a recruitment by ID
        public async Task<ServiceResult<Recruitment>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Recruitment>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Recruitments
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Recruitment>.SuccessResult(data)
                    : ServiceResult<Recruitment>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching recruitment by ID.");
                return ServiceResult<Recruitment>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a recruitment by exact position name
        public async Task<ServiceResult<Recruitment>> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<Recruitment>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Recruitments
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.RecruitmentPosition.ToLower() == text.ToLower());
                return data != null
                    ? ServiceResult<Recruitment>.SuccessResult(data)
                    : ServiceResult<Recruitment>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching recruitment by text.");
                return ServiceResult<Recruitment>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new recruitment
        public async Task<ServiceResult<bool>> Add(Recruitment recruitment)
        {
            if (recruitment == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Recruitments.AddAsync(recruitment);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new recruitment.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing recruitment by ID
        public async Task<ServiceResult<bool>> Update(int id, Recruitment recruitment)
        {
            if (recruitment == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Recruitments
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.RecruitmentPosition = recruitment.RecruitmentPosition;
                data.PostingDate = recruitment.PostingDate;
                data.Deadline = recruitment.Deadline;
                data.Status = recruitment.Status;
                data.Requestment = recruitment.Requestment;
                data.RecruitmentDescription = recruitment.RecruitmentDescription;
                data.DepartmentId = recruitment.DepartmentId;

                _context.Recruitments.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating recruitment.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes a recruitment by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Recruitments
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Recruitments.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting recruitment.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
