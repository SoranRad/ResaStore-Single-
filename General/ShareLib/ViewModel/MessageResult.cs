using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.ViewModel
{
    public partial class MessageResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Redirect { get; set; }
        public ResultStatusCode StatusCode { get; set; }


        public MessageResult(bool isSuccess, ResultStatusCode statusCode, string message = null, string redirect = null)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            Redirect = redirect;
            Message = message ?? statusCode.ToString();
        }
    }

    public partial class MessageResult<T> : MessageResult //where T : class
    {
        public T Data { get; set; }

        public MessageResult
            (bool isSuccess, ResultStatusCode statusCode, T data, string message = null, string redirect = null)
            : base(isSuccess, statusCode, message, redirect)
        {
            Data = data;
        }


    }

    public enum ResultStatusCode
    {
        [Display(Name = "عملیات با موفقیت انجام شد")]
        Success = 0,

        [Display(Name = "خطایی در سرور رخ داده است")]
        ServerError = 1,

        [Display(Name = "پارامتر های ارسالی معتبر نیستند")]
        BadRequest = 2,

        [Display(Name = "یافت نشد")]
        NotFound = 3,

        [Display(Name = "لیست خالی است")]
        ListEmpty = 4,

        [Display(Name = "خطایی در پردازش رخ داد")]
        LogicError = 5,

        [Display(Name = "خطای دسترسی به سیستم")]
        UnAuthorized = 6
    }
}
