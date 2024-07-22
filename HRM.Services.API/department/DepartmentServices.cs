using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services.API.department
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DepartmentServices> _logger;

        public DepartmentServices(ApplicationDbContext context, ILogger<DepartmentServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Fetches all departments
        public async Task<ServiceResult<IEnumerable<Department>>> GetDepartments()
        {
            try
            {
                var data = await _context.Departments
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Department>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Department>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching all departments.");
                return ServiceResult<IEnumerable<Department>>.FailedResult(ex.Message);
            }
        }

        // Fetches departments that match the search text
        public async Task<ServiceResult<IEnumerable<Department>>> GetDepartmentsByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<IEnumerable<Department>>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Departments
                    .Where(x => x.DepartmentName.ToLower().Contains(text.ToLower())
                        || x.Description.ToLower().Contains(text.ToLower()))
                    .AsNoTracking()
                    .ToListAsync();
                return data.Any()
                    ? ServiceResult<IEnumerable<Department>>.SuccessResult(data)
                    : ServiceResult<IEnumerable<Department>>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching departments by text.");
                return ServiceResult<IEnumerable<Department>>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a department by ID
        public async Task<ServiceResult<Department>> GetById(int id)
        {
            if (id <= 0)
                return ServiceResult<Department>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Departments
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                return data != null
                    ? ServiceResult<Department>.SuccessResult(data)
                    : ServiceResult<Department>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching department by ID.");
                return ServiceResult<Department>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Fetches a department by exact name
        public async Task<ServiceResult<Department>> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return ServiceResult<Department>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Departments
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.DepartmentName.ToLower() == text.ToLower());
                return data != null
                    ? ServiceResult<Department>.SuccessResult(data)
                    : ServiceResult<Department>.FailedResult("Not Found");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching department by text.");
                return ServiceResult<Department>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Adds a new department
        public async Task<ServiceResult<bool>> Add(Department department)
        {
            if (department == null)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                await _context.Departments.AddAsync(department);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new department.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Updates an existing department by ID
        public async Task<ServiceResult<bool>> Update(int id, Department department)
        {
            if (department == null || id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Departments
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                data.DepartmentName = department.DepartmentName;
                data.Description = department.Description;

                _context.Departments.Update(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating department.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }

        // Deletes a department by ID
        public async Task<ServiceResult<bool>> Delete(int id)
        {
            if (id <= 0)
                return ServiceResult<bool>.FailedResult("Input value was null");

            try
            {
                var data = await _context.Departments
                    .AsTracking()
                    .FirstOrDefaultAsync(x => x.Id == id);
                if (data == null)
                    return ServiceResult<bool>.FailedResult("Not Found");

                _context.Departments.Remove(data);
                await _context.SaveChangesAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting department.");
                return ServiceResult<bool>.FailedResult($"Error: {ex.Source}");
            }
        }
    }
}
