using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.shift
{
    public interface IShiftServices
    {
        public Task<ServiceResult<IEnumerable<Shift>>> GetShifts();
        public Task<ServiceResult<IEnumerable<Shift>>> GetShiftsByDateRange(DateTime startDate, DateTime endDate);
        public Task<ServiceResult<Shift>> GetById(int id);
        public Task<ServiceResult<bool>> Add(Shift shift);
        public Task<ServiceResult<bool>> Update(int id, Shift shift);
        public Task<ServiceResult<bool>> Delete(int id);
    }
}
