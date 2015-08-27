/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IFuturesPriceDAL.cs
// 文件功能描述：期货价格表dbo.FuturesPrice数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 期货价格表dbo.FuturesPrice数据交互接口。
    /// </summary>
    public class FuturesPriceBLL : BaseBLL<FuturesPrice>
    {
        public FuturesPriceBLL(IBaseDAL<FuturesPrice> currentDAL) : base(currentDAL) { }
    }
}
