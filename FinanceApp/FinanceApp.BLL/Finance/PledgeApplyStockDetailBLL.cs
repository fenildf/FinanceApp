/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_PledgeApplyStockDetailDAL.cs
// 文件功能描述：质押申请单实货明细dbo.Fin_PledgeApplyStockDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 质押申请单实货明细dbo.Fin_PledgeApplyStockDetail数据交互接口。
    /// </summary>
    public class Fin_PledgeApplyStockDetailBLL : BaseBLL<Fin_PledgeApplyStockDetail>
    {
        public Fin_PledgeApplyStockDetailBLL(IBaseDAL<Fin_PledgeApplyStockDetail> currentDAL) : base(currentDAL) { }
    }
}
