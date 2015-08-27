/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_TaskNodeDAL.cs
// 文件功能描述：任务节点dbo.Wf_TaskNode数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 任务节点dbo.Wf_TaskNode数据交互接口。
    /// </summary>
    public class Wf_TaskNodeBLL : BaseBLL<Wf_TaskNode>
    {
        public Wf_TaskNodeBLL(IBaseDAL<Wf_TaskNode> currentDAL) : base(currentDAL) { }
    }
}
