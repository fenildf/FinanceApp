/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ICorpDeptDAL.cs
// 文件功能描述：公司部门关联表dbo.CorpDept数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 公司部门关联表dbo.CorpDept数据交互接口。
    /// </summary>
    public class CorpDeptBLL : BaseBLL<CorpDept>
    {
        private readonly CorpDeptDAL corpdeptDAL = new CorpDeptDAL();
        
        protected override BaseDAL<CorpDept> CurDALInstance{
            get{return corpdeptDAL;}
        }
    }
}
