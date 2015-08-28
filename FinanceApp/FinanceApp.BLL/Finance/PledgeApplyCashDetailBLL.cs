/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_PledgeApplyCashDetailDAL.cs
// 文件功能描述：质押申请单期货头寸明细dbo.Fin_PledgeApplyCashDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 质押申请单期货头寸明细dbo.Fin_PledgeApplyCashDetail数据交互接口。
    /// </summary>
    public class Fin_PledgeApplyCashDetailBLL : BaseBLL<Fin_PledgeApplyCashDetail>
    {
        private readonly Fin_PledgeApplyCashDetailDAL fin_pledgeapplycashdetailDAL = new Fin_PledgeApplyCashDetailDAL();
        
        protected override BaseDAL<Fin_PledgeApplyCashDetail> CurDALInstance{
            get{return fin_pledgeapplycashdetailDAL;}
        }
    }
}
