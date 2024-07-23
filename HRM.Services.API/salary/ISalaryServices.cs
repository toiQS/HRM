using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.salary
{
    public interface ISalaryServices
    {
        public Task<ServiceResult<IEnumerable<Salary>>> GetSalaries();
        public Task<ServiceResult<IEnumerable<Salary>>> GetSalariesByDateRange(DateTime startDate, DateTime endDate);
        public Task<ServiceResult<Salary>> GetById(int id);
        public Task<ServiceResult<bool>> Add(Salary salary);
        public Task<ServiceResult<bool>> Update(int id, Salary salary);
        public Task<ServiceResult<bool>> Delete(int id);
    }
}
