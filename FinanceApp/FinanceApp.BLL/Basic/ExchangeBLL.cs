/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IExchangeDAL.cs
// 文件功能描述：交易所表dbo.Exchange数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 交易所表dbo.Exchange数据交互接口。
    /// </summary>
    public class ExchangeBLL : BaseBLL<Exchange>
    {
        private readonly ExchangeDAL exchangeDAL = new ExchangeDAL();
        
        protected override BaseDAL<Exchange> CurDALInstance{
            get{return exchangeDAL;}
        }
    }
}
