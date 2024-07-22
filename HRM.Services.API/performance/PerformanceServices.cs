using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services.API.Performances
{
    public class PerformanceServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<PerformanceServices> _logger;

        public PerformanceServices(ApplicationDbContext context, ILogger<PerformanceServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all performances
        public async Task<ServiceResult<IEnumerable<Performance>>> GetPerformances()
        {
            try
            {
                var data = await _context.Performances
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Performance>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Performance>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all performances.");
                return ServiceResult<IEnumerable<Performance>>.FailedResult(ex.Message);
            }
        }

        // Fetches performances that match the search text
        public async Task<ServiceResult<IEnumerable<Performance>>> GetPerformancesByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<IEnumerable<Performance>>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Performances
                    .Where(x => x.Comment.ToLower().Contains(text.ToLower()))
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Performance>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Performance>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching performances by text.");
                return ServiceResult<IEnumerable<Performance>>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a performance by ID
        public async Task<ServiceResult<Performance>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Performance>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Performances
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Performance>.SuccessResult(data)
                    : ServiceResult<Performance>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching performance by ID.");
                return ServiceResult<Performance>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a performance by evaluation date
        public async Task<ServiceResult<Performance>> GetByEvaluationDate(DateTime evaluationDate)
        {
            try
            {
                var data = await _context.Performances
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.EvaluationDate == evaluationDate);
                return data != null
                    ? ServiceResult<Performance>.SuccessResult(data)
                    : ServiceResult<Performance>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching performance by evaluation date.");
                return ServiceResult<Performance>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new performance
        public async Task<ServiceResult<bool>> Add(Performance performance)
        {
            if (performance == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Performances.AddAsync(performance);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new performance.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing performance by ID
        public async Task<ServiceResult<bool>> Update(int id, Performance performance)
        {
            if (performance == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Performances
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.EvaluationDate = performance.EvaluationDate;
                data.Score = performance.Score;
                data.Comment = performance.Comment;
                data.EmployeeId = performance.EmployeeId;
                data.TrainingId = performance.TrainingId;
                data.SalaryId = performance.SalaryId;

                _context.Performances.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating performance.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes a performance by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Performances
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Performances.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting performance.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
