﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IPriceAuthorityDAL.cs
// 文件功能描述：点价权dbo.PriceAuthority数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 点价权dbo.PriceAuthority数据交互接口。
    /// </summary>
    public class PriceAuthorityBLL : BaseBLL<PriceAuthority>
    {
        private readonly PriceAuthorityDAL priceauthorityDAL = new PriceAuthorityDAL();
        
        protected override BaseDAL<PriceAuthority> CurDALInstance{
            get{return priceauthorityDAL;}
        }
    }
}
