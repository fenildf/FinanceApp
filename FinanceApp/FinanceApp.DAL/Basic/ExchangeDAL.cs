/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IExchangeDAL.cs
// 文件功能描述：交易所表dbo.Exchange数据交互接口。
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
    /// 交易所表dbo.Exchange数据交互接口。
    /// </summary>
    public class ExchangeDAL : BaseDAL<Exchange>,IExchangeDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Exchange entity)
        {
            throw new NotImplementedException();
        }
    }
}
