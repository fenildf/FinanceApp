/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_TaskOperateDAL.cs
// 文件功能描述：任务操作表dbo.Wf_TaskOperate数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 任务操作表dbo.Wf_TaskOperate数据交互接口。
    /// </summary>
    public class Wf_TaskOperateBLL : BaseBLL<Wf_TaskOperate>
    {
        public Wf_TaskOperateBLL(IBaseDAL<Wf_TaskOperate> currentDAL) : base(currentDAL) { }
    }
}
