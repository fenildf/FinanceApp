/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_TaskOperateLogDAL.cs
// 文件功能描述：任务操作记录表dbo.Wf_TaskOperateLog数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 任务操作记录表dbo.Wf_TaskOperateLog数据交互接口。
    /// </summary>
    public class Wf_TaskOperateLogBLL : BaseBLL<Wf_TaskOperateLog>
    {
        private readonly Wf_TaskOperateLogDAL wf_taskoperatelogDAL = new Wf_TaskOperateLogDAL();
        
        protected override BaseDAL<Wf_TaskOperateLog> CurDALInstance{
            get{return wf_taskoperatelogDAL;}
        }
    }
}
