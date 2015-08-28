/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IRateDAL.cs
// 文件功能描述：汇率dbo.Rate数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 汇率dbo.Rate数据交互接口。
    /// </summary>
    public class RateBLL : BaseBLL<Rate>
    {
        private readonly RateDAL rateDAL = new RateDAL();
        
        protected override BaseDAL<Rate> CurDALInstance{
            get{return rateDAL;}
        }
    }
}
