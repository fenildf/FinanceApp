using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinanceApp.PassPort
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUserService”。
    [ServiceContract]
    public interface IUserService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="accountName">用户名</param>
        /// <param name="passWord">用户密码</param>
        /// <returns></returns>
        [OperationContract]
        Common.ResultModel Login(string accountName, string passWord);

        /// <summary>
        /// 验证登录状态
        /// </summary>
        /// <param name="token">用户登录的唯一凭证</param>
        /// <returns></returns>
        [OperationContract]
        Common.ResultModel CheckLoginStatus(string token);

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [OperationContract]
        Common.ResultModel LoginOut(string token);
    }
}
