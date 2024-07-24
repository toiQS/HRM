using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API.auth
{
    public class AuthServices : IAuthServices
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AuthServices(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="registerModel">The model containing user registration details.</param>
        /// <returns>True if registration succeeds; otherwise, false.</returns>
        public async Task<ServiceResult<bool>> RegisterUser(RegisterModel registerModel)
        {
            var user = new IdentityUser
            {
                UserName = registerModel.UserName,
                Email = registerModel.Email,
            };

            try
            {
                var result = await _userManager.CreateAsync(user, registerModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                }
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.FailedResult(ex.Message);
            }
        }

        /// <summary>
        /// Registers a new admin.
        /// </summary>
        /// <param name="registerModel">The model containing admin registration details.</param>
        /// <returns>True if registration succeeds; otherwise, false.</returns>
        public async Task<ServiceResult<bool>> RegisterAdmin(RegisterModel registerModel)
        {
            var user = new IdentityUser
            {
                UserName = registerModel.UserName,
                Email = registerModel.Email,
            };

            try
            {
                var result = await _userManager.CreateAsync(user, registerModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                return ServiceResult<bool>.FailedResult(ex.Message);
            }
        }

        /// <summary>
        /// Logs in a user.
        /// </summary>
        /// <param name="loginModel">The model containing user login details.</param>
        /// <returns>True if login succeeds; otherwise, false.</returns>
        public async Task<ServiceResult<bool>> Login(LoginModel loginModel)
        {
            try
            {
                var identityUser = await _userManager.FindByEmailAsync(loginModel.Email);
                if (identityUser == null)
                {
                    ServiceResult<bool>.FailedResult("Not Found");
                }
                var result = await _signInManager.CheckPasswordSignInAsync(identityUser, loginModel.Password, false);
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.FailedResult(ex.Message);
            }
        }

        /// <summary>
        /// Logs out the current user.
        /// </summary>
        public async Task<ServiceResult<bool>> LogOutUser()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return ServiceResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return ServiceResult<bool>.FailedResult(ex.Message);
            }
        }
    }
}
