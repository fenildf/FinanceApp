/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IClauseContract_RefDAL.cs
// 文件功能描述：模板条款关联表dbo.ClauseContract_Ref数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 模板条款关联表dbo.ClauseContract_Ref数据交互接口。
    /// </summary>
    public class ClauseContract_RefBLL : BaseBLL<ClauseContract_Ref>
    {
        public ClauseContract_RefBLL(IBaseDAL<ClauseContract_Ref> currentDAL) : base(currentDAL) { }
    }
}
