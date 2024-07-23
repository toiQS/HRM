using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services.API.shift
{
    public class ShiftServices : IShiftServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ShiftServices> _logger;

        public ShiftServices(ApplicationDbContext context, ILogger<ShiftServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all shifts
        public async Task<ServiceResult<IEnumerable<Shift>>> GetShifts()
        {
            try
            {
                var data = await _context.Shifts
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Shift>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Shift>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all shifts.");
                return ServiceResult<IEnumerable<Shift>>.FailedResult(ex.Message);
            }
        }

        // Fetches shifts by date range
        public async Task<ServiceResult<IEnumerable<Shift>>> GetShiftsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                var data = await _context.Shifts
                    .Where(x => x.StartAt >= startDate && x.EndAt <= endDate)
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Shift>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Shift>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching shifts by date range.");
                return ServiceResult<IEnumerable<Shift>>.FailedResult(ex.Message);
            }
        }

        // Fetches a shift by ID
        public async Task<ServiceResult<Shift>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Shift>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Shifts
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Shift>.SuccessResult(data)
                    : ServiceResult<Shift>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching shift by ID.");
                return ServiceResult<Shift>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new shift
        public async Task<ServiceResult<bool>> Add(Shift shift)
        {
            if (shift == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Shifts.AddAsync(shift);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new shift.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing shift by ID
        public async Task<ServiceResult<bool>> Update(int id, Shift shift)
        {
            if (shift == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Shifts
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.StartAt = shift.StartAt;
                data.EndAt = shift.EndAt;
                data.DayOfApplication = shift.DayOfApplication;
                data.TotalHours = shift.TotalHours;

                _context.Shifts.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating shift.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes a shift by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Shifts
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Shifts.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting shift.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
