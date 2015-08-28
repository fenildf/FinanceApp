/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAccountDAL.cs
// 文件功能描述：账户表dbo.Account数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using FinanceApp.Common;
using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.DAL
{
    /// <summary>
    /// 账户表dbo.Account数据交互接口。
    /// </summary>
    public class AccountDAL : BaseDAL<Account>
    {
        public override DbContext CurrentContext
        {
            get { return new Model.NFMT_User_ConnectStr(); }
        }

        public override bool Invalid(Account entity)
        {
            throw new NotImplementedException();
        }

        public ResultModel CheckLogin(string accountName, string passWord)
        {
            ResultModel result = new ResultModel();

            try
            {
                using (CurrentContext)
                {
                    string cmdText =
                        string.Format(
                            "select count(*) from dbo.Account where AccountName={0} and PassWord={1} ", accountName,
                            passWord);
                    var cmd = CurrentContext.Database.Connection.CreateCommand();
                    cmd.CommandText = cmdText;
                    cmd.CommandType = CommandType.Text;
                    int i = 0;
                    if (int.TryParse(cmd.ExecuteScalar().ToString(), out i) && i > 0)
                    {
                        cmdText =
                            string.Format(
                                "select count(*) from dbo.Account where AccountName={0} and PassWord={1} and IsValid=1", accountName,
                            passWord);
                        cmd.CommandText = cmdText;

                        i = 0;
                        if (int.TryParse(cmd.ExecuteScalar().ToString(), out i) && i > 0)
                        {
                            result.AffectCount = 1;
                            result.Message = "验证成功";
                            result.ResultStatus = 0;
                            result.ReturnValue = i;
                        }
                        else
                        {
                            result.AffectCount = 0;
                            result.Message = "该账号已无效";
                            result.ResultStatus = -1;
                            result.ReturnValue = 0;
                        }
                    }
                    else
                    {
                        result.Message = "账号或密码错误";
                        result.ResultStatus = -1;
                        result.AffectCount = 0;
                        result.ReturnValue = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                result.ResultStatus = -1;
                result.Message = ex.Message;
            }

            return result;
        }
    }
}
