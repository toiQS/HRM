using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.auth
{
    public interface IAuthServices
    {
        public Task<ServiceResult<bool>> Login(LoginModel loginModel);
        public Task<ServiceResult<bool>> RegisterUser(RegisterModel registerModel);
        public Task<ServiceResult<bool>> RegisterAdmin(RegisterModel registerModel);
        public Task<ServiceResult<bool>> LogOutUser();
    }
}
