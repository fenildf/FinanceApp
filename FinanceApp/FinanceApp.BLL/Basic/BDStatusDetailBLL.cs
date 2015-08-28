/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IBDStatusDetailDAL.cs
// 文件功能描述：基础状态明细表dbo.BDStatusDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 基础状态明细表dbo.BDStatusDetail数据交互接口。
    /// </summary>
    public class BDStatusDetailBLL : BaseBLL<BDStatusDetail>
    {
        private readonly BDStatusDetailDAL bdstatusdetailDAL = new BDStatusDetailDAL();
        
        protected override BaseDAL<BDStatusDetail> CurDALInstance{
            get{return bdstatusdetailDAL;}
        }
    }
}
