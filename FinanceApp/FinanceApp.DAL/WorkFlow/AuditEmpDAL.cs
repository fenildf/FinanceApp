/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_AuditEmpDAL.cs
// 文件功能描述：审核人表dbo.Wf_AuditEmp数据交互接口。
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
    /// 审核人表dbo.Wf_AuditEmp数据交互接口。
    /// </summary>
    public class Wf_AuditEmpDAL : BaseDAL<Wf_AuditEmp>,IWf_AuditEmpDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Wf_AuditEmp entity)
        {
            throw new NotImplementedException();
        }
    }
}
