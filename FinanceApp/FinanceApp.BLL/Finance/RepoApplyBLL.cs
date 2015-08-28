/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_RepoApplyDAL.cs
// 文件功能描述：融资头寸赎回申请单dbo.Fin_RepoApply数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 融资头寸赎回申请单dbo.Fin_RepoApply数据交互接口。
    /// </summary>
    public class Fin_RepoApplyBLL : BaseBLL<Fin_RepoApply>
    {
        private readonly Fin_RepoApplyDAL fin_repoapplyDAL = new Fin_RepoApplyDAL();
        
        protected override BaseDAL<Fin_RepoApply> CurDALInstance{
            get{return fin_repoapplyDAL;}
        }
    }
}
