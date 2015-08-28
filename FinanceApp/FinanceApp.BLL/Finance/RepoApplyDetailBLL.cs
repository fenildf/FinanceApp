/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_RepoApplyDetailDAL.cs
// 文件功能描述：赎回申请单明细dbo.Fin_RepoApplyDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 赎回申请单明细dbo.Fin_RepoApplyDetail数据交互接口。
    /// </summary>
    public class Fin_RepoApplyDetailBLL : BaseBLL<Fin_RepoApplyDetail>
    {
        private readonly Fin_RepoApplyDetailDAL fin_repoapplydetailDAL = new Fin_RepoApplyDetailDAL();
        
        protected override BaseDAL<Fin_RepoApplyDetail> CurDALInstance{
            get{return fin_repoapplydetailDAL;}
        }
    }
}
