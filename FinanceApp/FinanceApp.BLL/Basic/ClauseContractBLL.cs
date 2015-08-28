/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IClauseContract_RefDAL.cs
// 文件功能描述：模板条款关联表dbo.ClauseContract_Ref数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 模板条款关联表dbo.ClauseContract_Ref数据交互接口。
    /// </summary>
    public class ClauseContract_RefBLL : BaseBLL<ClauseContract_Ref>
    {
        private readonly ClauseContract_RefDAL clausecontract_refDAL = new ClauseContract_RefDAL();
        
        protected override BaseDAL<ClauseContract_Ref> CurDALInstance{
            get{return clausecontract_refDAL;}
        }
    }
}
