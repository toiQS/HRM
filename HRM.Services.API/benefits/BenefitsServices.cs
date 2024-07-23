using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HRM.Services.API.benefits
{
    public class BenefitsServices : IBenefitsServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BenefitsServices> _logger;

        public BenefitsServices(ApplicationDbContext context, ILogger<BenefitsServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all benefits
        public async Task<ServiceResult<IEnumerable<Benefits>>> GetBenefits()
        {
            try
            {
                var data = await _context.Benefits
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Benefits>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Benefits>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all benefits.");
                return ServiceResult<IEnumerable<Benefits>>.FailedResult(ex.Message);
            }
        }

        // Fetches benefits that match the search text
        public async Task<ServiceResult<IEnumerable<Benefits>>> GetBenefitsByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<IEnumerable<Benefits>>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Benefits
                    .Where(x => x.BenefitsName.ToLower().Contains(text.ToLower())
                        || x.TypeBenefits.ToLower().Contains(text.ToLower())
                        || x.BenefitsDescription.ToLower().Contains(text.ToLower()))
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Benefits>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Benefits>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching benefits by text.");
                return ServiceResult<IEnumerable<Benefits>>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a benefit by ID
        public async Task<ServiceResult<Benefits>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Benefits>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Benefits
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Benefits>.SuccessResult(data)
                    : ServiceResult<Benefits>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching benefit by ID.");
                return ServiceResult<Benefits>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a benefit by exact name
        public async Task<ServiceResult<Benefits>> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<Benefits>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Benefits
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.BenefitsName.ToLower() == text.ToLower());
                return data != null
                    ? ServiceResult<Benefits>.SuccessResult(data)
                    : ServiceResult<Benefits>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching benefit by text.");
                return ServiceResult<Benefits>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new benefit
        public async Task<ServiceResult<bool>> Add(Benefits benefits)
        {
            if (benefits == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Benefits.AddAsync(benefits);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new benefit.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing benefit by ID
        public async Task<ServiceResult<bool>> Update(int id, Benefits benefits)
        {
            if (benefits == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Benefits
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.BenefitsName = benefits.BenefitsName;
                data.BenefitsDescription = benefits.BenefitsDescription;
                data.StartAt = benefits.StartAt;
                data.EndAt = benefits.EndAt;
                data.TypeBenefits = benefits.TypeBenefits;
                data.PositionId = benefits.PositionId;

                _context.Benefits.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating benefit.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes a benefit by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Benefits
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Benefits.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting benefit.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
