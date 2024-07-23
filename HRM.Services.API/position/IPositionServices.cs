using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.position
{
    public interface IPositionServices
    {
        public Task<ServiceResult<IEnumerable<Position>>> GetPositions();
        public Task<ServiceResult<IEnumerable<Position>>> GetPositionsByText(string text);
        public Task<ServiceResult<Position>> GetById(int id);
        public Task<ServiceResult<Position>> GetByText(string text);
        public Task<ServiceResult<bool>> Add(Position position);
        public Task<ServiceResult<bool>> Update(int id, Position position);
        public Task<ServiceResult<bool>> Delete(int id);
    }
}
