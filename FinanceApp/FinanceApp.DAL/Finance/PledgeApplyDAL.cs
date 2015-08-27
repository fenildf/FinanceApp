/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_PledgeApplyDAL.cs
// 文件功能描述：融资头寸质押申请单dbo.Fin_PledgeApply数据交互接口。
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
    /// 融资头寸质押申请单dbo.Fin_PledgeApply数据交互接口。
    /// </summary>
    public class Fin_PledgeApplyDAL : BaseDAL<Fin_PledgeApply>,IFin_PledgeApplyDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Fin_PledgeApply entity)
        {
            throw new NotImplementedException();
        }
    }
}
