/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_RepoApplyDetailDAL.cs
// 文件功能描述：赎回申请单明细dbo.Fin_RepoApplyDetail数据交互接口。
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
    /// 赎回申请单明细dbo.Fin_RepoApplyDetail数据交互接口。
    /// </summary>
    public class Fin_RepoApplyDetailDAL : BaseDAL<Fin_RepoApplyDetail>,IFin_RepoApplyDetailDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Fin_RepoApplyDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
