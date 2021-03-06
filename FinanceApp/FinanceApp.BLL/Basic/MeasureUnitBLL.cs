﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IMeasureUnitDAL.cs
// 文件功能描述：计量单位dbo.MeasureUnit数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 计量单位dbo.MeasureUnit数据交互接口。
    /// </summary>
    public class MeasureUnitBLL : BaseBLL<MeasureUnit>
    {
        private readonly MeasureUnitDAL measureunitDAL = new MeasureUnitDAL();
        
        protected override BaseDAL<MeasureUnit> CurDALInstance{
            get{return measureunitDAL;}
        }
    }
}
