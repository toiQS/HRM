using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services.API.employee
{
    public class EmployeeServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<EmployeeServices> _logger;

        public EmployeeServices(ApplicationDbContext context, ILogger<EmployeeServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all employees
        public async Task<ServiceResult<IEnumerable<Employee>>> GetEmployees()
        {
            try
            {
                var data = await _context.Employees
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Employee>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Employee>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all employees.");
                return ServiceResult<IEnumerable<Employee>>.FailedResult(ex.Message);
            }
        }

        // Fetches employees that match the search text
        public async Task<ServiceResult<IEnumerable<Employee>>> GetEmployeesByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<IEnumerable<Employee>>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Employees
                    .Where(x => x.FirstName.ToLower().Contains(text.ToLower())
                        || x.LastName.ToLower().Contains(text.ToLower())
                        || x.Email.ToLower().Contains(text.ToLower()))
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Employee>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Employee>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching employees by text.");
                return ServiceResult<IEnumerable<Employee>>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches an employee by ID
        public async Task<ServiceResult<Employee>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Employee>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Employees
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Employee>.SuccessResult(data)
                    : ServiceResult<Employee>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching employee by ID.");
                return ServiceResult<Employee>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches an employee by exact name
        public async Task<ServiceResult<Employee>> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<Employee>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Employees
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.FullName.ToLower() == text.ToLower());
                return data != null
                    ? ServiceResult<Employee>.SuccessResult(data)
                    : ServiceResult<Employee>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching employee by text.");
                return ServiceResult<Employee>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new employee
        public async Task<ServiceResult<bool>> Add(Employee employee)
        {
            if (employee == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new employee.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing employee by ID
        public async Task<ServiceResult<bool>> Update(int id, Employee employee)
        {
            if (employee == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Employees
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.FirstName = employee.FirstName;
                data.MiddleName = employee.MiddleName;
                data.LastName = employee.LastName;
                data.FullName = employee.FullName;
                data.Address = employee.Address;
                data.Email = employee.Email;
                data.HireDate = employee.HireDate;
                data.DepartmentId = employee.DepartmentId;
                data.PositionId = employee.PositionId;
                data.ShiftId = employee.ShiftId;

                _context.Employees.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating employee.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes an employee by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Employees
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Employees.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting employee.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
