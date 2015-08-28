/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_TaskAttachOperateLogDAL.cs
// 文件功能描述：任务附件操作记录表dbo.Wf_TaskAttachOperateLog数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 任务附件操作记录表dbo.Wf_TaskAttachOperateLog数据交互接口。
    /// </summary>
    public class Wf_TaskAttachOperateLogBLL : BaseBLL<Wf_TaskAttachOperateLog>
    {
        private readonly Wf_TaskAttachOperateLogDAL wf_taskattachoperatelogDAL = new Wf_TaskAttachOperateLogDAL();
        
        protected override BaseDAL<Wf_TaskAttachOperateLog> CurDALInstance{
            get{return wf_taskattachoperatelogDAL;}
        }
    }
}
