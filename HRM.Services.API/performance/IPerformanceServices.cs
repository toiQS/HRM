using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.performance
{
    public interface IPerformanceServices
    {
        public Task<ServiceResult<IEnumerable<Performance>>> GetPerformances();
        public Task<ServiceResult<IEnumerable<Performance>>> GetPerformancesByText(string text);
        public Task<ServiceResult<Performance>> GetById(int id);
        public Task<ServiceResult<Performance>> GetByEvaluationDate(DateTime evaluationDate);
        public Task<ServiceResult<bool>> Add(Performance Performance);
        public Task<ServiceResult<bool>> Update(int id, Performance Performance);
        public Task<ServiceResult<bool>> Delete(int id);
    }
}
