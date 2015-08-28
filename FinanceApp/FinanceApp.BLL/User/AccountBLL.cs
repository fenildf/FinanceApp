/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAccountDAL.cs
// 文件功能描述：账户表dbo.Account数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using System;
using FinanceApp.Common;
using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 账户表dbo.Account数据交互接口。
    /// </summary>
    public class AccountBLL : BaseBLL<Account>
    {
        private readonly AccountDAL accountDAL = new AccountDAL();

        protected override BaseDAL<Account> CurDALInstance
        {
            get { return accountDAL; }
        }

        public ResultModel CheckLogin(string userName, string passWord)
        {
            ResultModel result = new ResultModel();

            try
            {
                result = accountDAL.CheckLogin(userName.Trim(), passWord);
            }
            catch (Exception ex)
            {
                result.ResultStatus = -1;
                result.Message = ex.Message;
            }
            finally
            {
                if (result.ResultStatus != 0)
                    log.ErrorFormat("验证用户登录失败，失败原因：{0}", result.Message);
                else if (log.IsInfoEnabled)
                    log.InfoFormat("验证用户登录，验证结果为：{0}，提示信息为：", result.ReturnValue, result.Message);
            }

            return result;
        }
    }
}
