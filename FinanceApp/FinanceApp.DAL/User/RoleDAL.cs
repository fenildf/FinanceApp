/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IRoleDAL.cs
// 文件功能描述：角色dbo.Role数据交互接口。
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
    /// 角色dbo.Role数据交互接口。
    /// </summary>
    public class RoleDAL : BaseDAL<Role>,IRoleDAL
    {
        public override DbContext CurrentContext
        {
            get { return new Model.NFMT_User_ConnectStr(); }
        }

        public override bool Invalid(Role entity)
        {
            throw new NotImplementedException();
        }

        public ResultModel Load( int empId)
        {
            ResultModel result = new ResultModel();
            try
            {
                string cmdText = string.Format("select r.* from dbo.Role r inner join dbo.EmpRole er on er.RoleId = r.RoleId where er.EmpId={0}", empId);
                var cmd = CurrentContext.Database.Connection.CreateCommand();
                cmd.CommandText = cmdText;
                cmd.CommandType = CommandType.Text;

                var roles = CurrentContext.Set<Role>().SqlQuery(cmdText, null).ToListAsync();

                result.AffectCount = roles.Result.Count;
                result.Message = "获取列表成功";
                result.ResultStatus = 0;
                result.ReturnValue = roles;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return result;
        }

    }
}
