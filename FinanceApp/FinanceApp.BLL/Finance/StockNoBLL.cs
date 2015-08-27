/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFin_StockNoDAL.cs
// 文件功能描述：融资单号表dbo.Fin_StockNo数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 融资单号表dbo.Fin_StockNo数据交互接口。
    /// </summary>
    public class Fin_StockNoBLL : BaseBLL<Fin_StockNo>
    {
        public Fin_StockNoBLL(IBaseDAL<Fin_StockNo> currentDAL) : base(currentDAL) { }
    }
}
