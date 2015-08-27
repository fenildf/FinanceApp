/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_NodeConditionDAL.cs
// 文件功能描述：节点条件表dbo.Wf_NodeCondition数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 节点条件表dbo.Wf_NodeCondition数据交互接口。
    /// </summary>
    public class Wf_NodeConditionBLL : BaseBLL<Wf_NodeCondition>
    {
        public Wf_NodeConditionBLL(IBaseDAL<Wf_NodeCondition> currentDAL) : base(currentDAL) { }
    }
}
