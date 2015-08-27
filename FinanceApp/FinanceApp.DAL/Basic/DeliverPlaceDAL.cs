/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IDeliverPlaceDAL.cs
// 文件功能描述：交货地dbo.DeliverPlace数据交互接口。
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
    /// 交货地dbo.DeliverPlace数据交互接口。
    /// </summary>
    public class DeliverPlaceDAL : BaseDAL<DeliverPlace>,IDeliverPlaceDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(DeliverPlace entity)
        {
            throw new NotImplementedException();
        }
    }
}
