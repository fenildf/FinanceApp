/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IBDStyleDetailDAL.cs
// 文件功能描述：基础类型编码明细表dbo.BDStyleDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 基础类型编码明细表dbo.BDStyleDetail数据交互接口。
    /// </summary>
    public class BDStyleDetailBLL : BaseBLL<BDStyleDetail>
    {
        private readonly BDStyleDetailDAL bdstyledetailDAL = new BDStyleDetailDAL();
        
        protected override BaseDAL<BDStyleDetail> CurDALInstance{
            get{return bdstyledetailDAL;}
        }
    }
}
