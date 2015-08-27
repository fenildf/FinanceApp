/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IEmpAuthGroupDAL.cs
// 文件功能描述：员工权限组关联表dbo.EmpAuthGroup数据交互接口。
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
    /// 员工权限组关联表dbo.EmpAuthGroup数据交互接口。
    /// </summary>
    public class EmpAuthGroupDAL : BaseDAL<EmpAuthGroup>,IEmpAuthGroupDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(EmpAuthGroup entity)
        {
            throw new NotImplementedException();
        }
    }
}
