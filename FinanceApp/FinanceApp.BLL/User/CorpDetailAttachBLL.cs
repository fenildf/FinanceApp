/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ICorpDetailAttachDAL.cs
// 文件功能描述：客户附件表dbo.CorpDetailAttach数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 客户附件表dbo.CorpDetailAttach数据交互接口。
    /// </summary>
    public class CorpDetailAttachBLL : BaseBLL<CorpDetailAttach>
    {
        private readonly CorpDetailAttachDAL corpdetailattachDAL = new CorpDetailAttachDAL();
        
        protected override BaseDAL<CorpDetailAttach> CurDALInstance{
            get{return corpdetailattachDAL;}
        }
    }
}
