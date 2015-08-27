/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_PledgeApplyCashDetailDAL.cs
// 文件功能描述：质押申请单期货头寸明细dbo.Fin_PledgeApplyCashDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 质押申请单期货头寸明细dbo.Fin_PledgeApplyCashDetail数据交互接口。
    /// </summary>
    public class Fin_PledgeApplyCashDetailBLL : BaseBLL<Fin_PledgeApplyCashDetail>
    {
        public Fin_PledgeApplyCashDetailBLL(IBaseDAL<Fin_PledgeApplyCashDetail> currentDAL) : base(currentDAL) { }
    }
}
