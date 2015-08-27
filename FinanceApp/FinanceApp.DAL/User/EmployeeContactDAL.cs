/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IEmployeeContactDAL.cs
// 文件功能描述：联系人员工关系表dbo.EmployeeContact数据交互接口。
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
    /// 联系人员工关系表dbo.EmployeeContact数据交互接口。
    /// </summary>
    public class EmployeeContactDAL : BaseDAL<EmployeeContact>,IEmployeeContactDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(EmployeeContact entity)
        {
            throw new NotImplementedException();
        }
    }
}
