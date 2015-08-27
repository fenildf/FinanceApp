/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IPriceAuthorityDAL.cs
// 文件功能描述：点价权dbo.PriceAuthority数据交互接口。
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
    /// 点价权dbo.PriceAuthority数据交互接口。
    /// </summary>
    public class PriceAuthorityDAL : BaseDAL<PriceAuthority>,IPriceAuthorityDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(PriceAuthority entity)
        {
            throw new NotImplementedException();
        }
    }
}
