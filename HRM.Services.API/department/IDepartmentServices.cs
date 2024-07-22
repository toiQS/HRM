using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.department
{
    public interface IDepartmentServices
    {
        public Task<ServiceResult<IEnumerable<Department>>> GetDepartment();
        public Task<ServiceResult<IEnumerable<Department>>> GetDepartmentByText(string text);
        public Task<ServiceResult<Department>> GetById(int id);
        public Task<ServiceResult<Department>> GetByText(string text);
        public Task<ServiceResult<bool>> Add(Department Department);
        public Task<ServiceResult<bool>> Update(int id, Department Department);
        public Task<ServiceResult<bool>> Delete(int id);
    }
}
