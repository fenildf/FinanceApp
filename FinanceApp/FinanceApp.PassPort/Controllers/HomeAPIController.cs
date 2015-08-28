using System;
using System.Web;
using System.Web.Http;
using FinanceApp.Common;

namespace FinanceApp.PassPort.Controllers
{
    public class HomeAPIController : ApiController
    {
        [HttpGet]
        [ActionName("Login")]
        public string Login(string userName, string password)
        {
            return userName + "     " + password;
            //UserService userService = new UserService();
            //ResultModel result = userService.Login(userName, password);
            //if (result.ResultStatus == 0)
            //{
            //    HttpCookie tokenCookie = new HttpCookie(DefaultValue.CookieName, result.ReturnValue.ToString())
            //    {
            //        Domain = DefaultValue.Domain,
            //        Path = "/",
            //        Expires = DateTime.Now.AddMinutes(DefaultValue.CacheExpiration)
            //    };
            //    HttpContext.Current.Response.Cookies.Add(tokenCookie);
            //}

            //return result;
        }

        //[HttpGet]
        //public string sth()
        //{
        //    return "你好";
        //}
    }
}