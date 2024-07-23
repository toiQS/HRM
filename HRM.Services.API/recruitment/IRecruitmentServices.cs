using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.recruitment
{
    public interface IRecruitmentServices
    {
        public Task<ServiceResult<IEnumerable<Recruitment>>> GetRecruitments();
        public Task<ServiceResult<IEnumerable<Recruitment>>> GetRecruitmentsByText(string text);
        public Task<ServiceResult<Recruitment>> GetById(int id);
        public Task<ServiceResult<Recruitment>> GetByText(string text);
        public Task<ServiceResult<bool>> Add(Recruitment recruitment);
        public Task<ServiceResult<bool>> Update(int id, Recruitment recruitment);
        public Task<ServiceResult<bool>> Delete(int id);
    }
}
