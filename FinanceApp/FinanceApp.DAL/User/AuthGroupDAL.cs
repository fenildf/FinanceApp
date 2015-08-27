/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAuthGroupDAL.cs
// 文件功能描述：权限组dbo.AuthGroup数据交互接口。
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
    /// 权限组dbo.AuthGroup数据交互接口。
    /// </summary>
    public class AuthGroupDAL : BaseDAL<AuthGroup>,IAuthGroupDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(AuthGroup entity)
        {
            throw new NotImplementedException();
        }
    }
}
