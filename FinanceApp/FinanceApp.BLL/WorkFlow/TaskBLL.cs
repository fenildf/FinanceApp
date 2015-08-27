/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_TaskDAL.cs
// 文件功能描述：任务表dbo.Wf_Task数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 任务表dbo.Wf_Task数据交互接口。
    /// </summary>
    public class Wf_TaskBLL : BaseBLL<Wf_Task>
    {
        public Wf_TaskBLL(IBaseDAL<Wf_Task> currentDAL) : base(currentDAL) { }
    }
}
