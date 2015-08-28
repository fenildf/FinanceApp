/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_TaskOperateDAL.cs
// 文件功能描述：任务操作表dbo.Wf_TaskOperate数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 任务操作表dbo.Wf_TaskOperate数据交互接口。
    /// </summary>
    public class Wf_TaskOperateBLL : BaseBLL<Wf_TaskOperate>
    {
        private readonly Wf_TaskOperateDAL wf_taskoperateDAL = new Wf_TaskOperateDAL();
        
        protected override BaseDAL<Wf_TaskOperate> CurDALInstance{
            get{return wf_taskoperateDAL;}
        }
    }
}
