﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ICorporationDAL.cs
// 文件功能描述：公司dbo.Corporation数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 公司dbo.Corporation数据交互接口。
    /// </summary>
    public class CorporationBLL : BaseBLL<Corporation>
    {
        private readonly CorporationDAL corporationDAL = new CorporationDAL();
        
        protected override BaseDAL<Corporation> CurDALInstance{
            get{return corporationDAL;}
        }
    }
}
