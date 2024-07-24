using System.ComponentModel.DataAnnotations;

namespace HRM.Services.API.auth
{
    public class AuthModel
    {
    }
    public class LoginModel
    {
        [EmailAddress]
        public string Email {  get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
    public class RegisterModel
    {
        public string UserName { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; 
    }
}
