using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.employee
{
    public interface IEmployeeServices
    {
        public Task<ServiceResult<IEnumerable<Employee>>> GetEmployee();
        public Task<ServiceResult<IEnumerable<Employee>>> GetEmployeeByText(string text);
        public Task<ServiceResult<Employee>> GetById(int id);
        public Task<ServiceResult<Employee>> GetByText(string text);
        public Task<ServiceResult<bool>> Add(Employee Employee);
        public Task<ServiceResult<bool>> Update(int id, Employee Employee);
        public Task<ServiceResult<bool>> Delete(int id);
    }
}
