using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using FinanceApp.Common;
using FinanceApp.PassPort.Controllers;
using FinanceApp.PassPort.Models;

namespace FinanceApp.PassPort.APIControllers
{
    public class HomeAPIController : BaseAPIController<HomeAPIController>
    {
        [HttpPost]
        public string Login([FromBody]LoginModel loginModel)
        {
            ResultModel result = new ResultModel();
            UserService userService = new UserService();
            result = userService.Login(loginModel.userName, loginModel.password);

            if (result.ResultStatus == 0)
            {
                log.InfoFormat("{0}登陆成功", loginModel.userName);

                HttpCookie tokenCookie = new HttpCookie(DefaultValue.CookieName, result.ReturnValue.ToString())
                {
                    Domain = DefaultValue.Domain,
                    Path = "/",
                    Expires = DateTime.Now.AddMinutes(DefaultValue.CacheExpiration)
                };
                HttpContext.Current.Response.Cookies.Add(tokenCookie);
            }

            return serializer.Serialize(result);
        }
    }
}
