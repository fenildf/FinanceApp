/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_RepoApplyDAL.cs
// 文件功能描述：融资头寸赎回申请单dbo.Fin_RepoApply数据交互接口。
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
    /// 融资头寸赎回申请单dbo.Fin_RepoApply数据交互接口。
    /// </summary>
    public class Fin_RepoApplyDAL : BaseDAL<Fin_RepoApply>,IFin_RepoApplyDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Fin_RepoApply entity)
        {
            throw new NotImplementedException();
        }
    }
}
