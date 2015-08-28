/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IDeliverPlaceDAL.cs
// 文件功能描述：交货地dbo.DeliverPlace数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 交货地dbo.DeliverPlace数据交互接口。
    /// </summary>
    public class DeliverPlaceBLL : BaseBLL<DeliverPlace>
    {
        private readonly DeliverPlaceDAL deliverplaceDAL = new DeliverPlaceDAL();
        
        protected override BaseDAL<DeliverPlace> CurDALInstance{
            get{return deliverplaceDAL;}
        }
    }
}
