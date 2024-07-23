using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services.API.position
{
    public class PositionServices : IPositionServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<PositionServices> _logger;

        public PositionServices(ApplicationDbContext context, ILogger<PositionServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all positions
        public async Task<ServiceResult<IEnumerable<Position>>> GetPositions()
        {
            try
            {
                var data = await _context.Positions
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Position>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Position>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all positions.");
                return ServiceResult<IEnumerable<Position>>.FailedResult(ex.Message);
            }
        }

        // Fetches positions that match the search text
        public async Task<ServiceResult<IEnumerable<Position>>> GetPositionsByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<IEnumerable<Position>>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Positions
                    .Where(x => x.PositionName.ToLower().Contains(text.ToLower())
                        || x.PositionDescription.ToLower().Contains(text.ToLower()))
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Position>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Position>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching positions by text.");
                return ServiceResult<IEnumerable<Position>>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a position by ID
        public async Task<ServiceResult<Position>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Position>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Positions
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Position>.SuccessResult(data)
                    : ServiceResult<Position>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching position by ID.");
                return ServiceResult<Position>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a position by exact name
        public async Task<ServiceResult<Position>> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<Position>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Positions
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.PositionName.ToLower() == text.ToLower());
                return data != null
                    ? ServiceResult<Position>.SuccessResult(data)
                    : ServiceResult<Position>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching position by text.");
                return ServiceResult<Position>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new position
        public async Task<ServiceResult<bool>> Add(Position position)
        {
            if (position == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Positions.AddAsync(position);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new position.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing position by ID
        public async Task<ServiceResult<bool>> Update(int id, Position position)
        {
            if (position == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Positions
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.PositionName = position.PositionName;
                data.PositionDescription = position.PositionDescription;

                _context.Positions.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating position.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes a position by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Positions
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Positions.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting position.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
