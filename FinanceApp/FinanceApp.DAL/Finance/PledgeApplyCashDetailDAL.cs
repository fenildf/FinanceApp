/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_PledgeApplyCashDetailDAL.cs
// 文件功能描述：质押申请单期货头寸明细dbo.Fin_PledgeApplyCashDetail数据交互接口。
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
    /// 质押申请单期货头寸明细dbo.Fin_PledgeApplyCashDetail数据交互接口。
    /// </summary>
    public class Fin_PledgeApplyCashDetailDAL : BaseDAL<Fin_PledgeApplyCashDetail>,IFin_PledgeApplyCashDetailDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Fin_PledgeApplyCashDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
