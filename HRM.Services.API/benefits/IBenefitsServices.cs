using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.benefits
{
    public interface IBenefitsServices
    {
        public Task<ServiceResult<IEnumerable<Benefits>>> GetBenefits();
        public Task<ServiceResult<IEnumerable<Benefits>>> GetBenefitsByText(string text);
        public Task<ServiceResult<Benefits>> GetById(int id);
        public Task<ServiceResult<Benefits>> GetByText(string text);
        public Task<ServiceResult<bool>> Add(Benefits benefits);
        public Task<ServiceResult<bool>> Update(int id, Benefits benefits);
        public Task<ServiceResult<bool>> Delete(int id);
    }
}
