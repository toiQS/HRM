using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services.API.training
{
    public class TrainingServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<TrainingServices> _logger;

        public TrainingServices(ApplicationDbContext context, ILogger<TrainingServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all trainings
        public async Task<ServiceResult<IEnumerable<Training>>> GetTrainings()
        {
            try
            {
                var data = await _context.Trainings
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Training>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Training>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all trainings.");
                return ServiceResult<IEnumerable<Training>>.FailedResult(ex.Message);
            }
        }

        // Fetches trainings by date range
        public async Task<ServiceResult<IEnumerable<Training>>> GetTrainingsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                var data = await _context.Trainings
                    .Where(x => x.StartAt >= startDate && x.EndAt <= endDate)
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Training>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Training>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching trainings by date range.");
                return ServiceResult<IEnumerable<Training>>.FailedResult(ex.Message);
            }
        }

        // Fetches a training by ID
        public async Task<ServiceResult<Training>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Training>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Trainings
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Training>.SuccessResult(data)
                    : ServiceResult<Training>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching training by ID.");
                return ServiceResult<Training>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new training
        public async Task<ServiceResult<bool>> Add(Training training)
        {
            if (training == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Trainings.AddAsync(training);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new training.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing training by ID
        public async Task<ServiceResult<bool>> Update(int id, Training training)
        {
            if (training == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Trainings
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.TrainName = training.TrainName;
                data.TrainDescription = training.TrainDescription;
                data.StartAt = training.StartAt;
                data.EndAt = training.EndAt;
                data.TypeTrain = training.TypeTrain;
                data.Status = training.Status;

                _context.Trainings.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating training.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes a training by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Trainings
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Trainings.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting training.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
