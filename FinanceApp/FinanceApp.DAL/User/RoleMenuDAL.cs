/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IRoleMenuDAL.cs
// 文件功能描述：角色菜单关联表dbo.RoleMenu数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using System;
using System.Data.Entity;
using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.DAL
{
    /// <summary>
    /// 角色菜单关联表dbo.RoleMenu数据交互接口。
    /// </summary>
    public class RoleMenuDAL : BaseDAL<RoleMenu>,IRoleMenuDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(RoleMenu entity)
        {
            throw new NotImplementedException();
        }
    }
}
