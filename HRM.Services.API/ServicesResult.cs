using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.API
{
    public class ServiceResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Result { get; set; }

        public ServiceResult() { }


        public ServiceResult(T? result)
        {
            Result = result;
            Message = "Success";
            Success = true;
        }


        public ServiceResult(string message)
        {
            Message = message;
            Success = false;
        }


        public static ServiceResult<T> SuccessResult(T? result)
        {
            return new ServiceResult<T>(result);
        }


        public static ServiceResult<T> FailedResult(string message)
        {
            return new ServiceResult<T>(message);
        }
    }
}
