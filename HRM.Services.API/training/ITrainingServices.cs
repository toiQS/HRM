using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.training
{
    internal interface ITrainingServices
    {
        Task<ServiceResult<IEnumerable<Training>>> GetTrainings();
        Task<ServiceResult<IEnumerable<Training>>> GetTrainingsByDateRange(DateTime startDate, DateTime endDate);
        Task<ServiceResult<Training>> GetById(int id);
        Task<ServiceResult<bool>> Add(Training training);
        Task<ServiceResult<bool>> Update(int id, Training training);
        Task<ServiceResult<bool>> Delete(int id);
    }
}
