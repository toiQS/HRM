using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services.API.salary
{
    public class SalaryServices : ISalaryServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<SalaryServices> _logger;

        public SalaryServices(ApplicationDbContext context, ILogger<SalaryServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all salaries
        public async Task<ServiceResult<IEnumerable<Salary>>> GetSalaries()
        {
            try
            {
                var data = await _context.Salaries
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Salary>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Salary>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all salaries.");
                return ServiceResult<IEnumerable<Salary>>.FailedResult(ex.Message);
            }
        }

        // Fetches salaries by date range
        public async Task<ServiceResult<IEnumerable<Salary>>> GetSalariesByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                var data = await _context.Salaries
                    .Where(x => x.PaymentDate >= startDate && x.PaymentDate <= endDate)
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Salary>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Salary>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching salaries by date range.");
                return ServiceResult<IEnumerable<Salary>>.FailedResult(ex.Message);
            }
        }

        // Fetches a salary by ID
        public async Task<ServiceResult<Salary>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Salary>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Salaries
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Salary>.SuccessResult(data)
                    : ServiceResult<Salary>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching salary by ID.");
                return ServiceResult<Salary>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new salary
        public async Task<ServiceResult<bool>> Add(Salary salary)
        {
            if (salary == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Salaries.AddAsync(salary);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new salary.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing salary by ID
        public async Task<ServiceResult<bool>> Update(int id, Salary salary)
        {
            if (salary == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Salaries
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.BasicSalary = salary.BasicSalary;
                data.Bonus = salary.Bonus;
                data.Deductions = salary.Deductions;
                data.NetSalary = salary.NetSalary;
                data.PaymentDate = salary.PaymentDate;

                _context.Salaries.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating salary.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes a salary by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Salaries
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Salaries.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting salary.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
