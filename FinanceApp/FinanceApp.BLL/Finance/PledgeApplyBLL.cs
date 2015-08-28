/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_PledgeApplyDAL.cs
// 文件功能描述：融资头寸质押申请单dbo.Fin_PledgeApply数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 融资头寸质押申请单dbo.Fin_PledgeApply数据交互接口。
    /// </summary>
    public class Fin_PledgeApplyBLL : BaseBLL<Fin_PledgeApply>
    {
        private readonly Fin_PledgeApplyDAL fin_pledgeapplyDAL = new Fin_PledgeApplyDAL();
        
        protected override BaseDAL<Fin_PledgeApply> CurDALInstance{
            get{return fin_pledgeapplyDAL;}
        }
    }
}
