/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_FlowMasterDAL.cs
// 文件功能描述：流程模板dbo.Wf_FlowMaster数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 流程模板dbo.Wf_FlowMaster数据交互接口。
    /// </summary>
    public class Wf_FlowMasterBLL : BaseBLL<Wf_FlowMaster>
    {
        public Wf_FlowMasterBLL(IBaseDAL<Wf_FlowMaster> currentDAL) : base(currentDAL) { }
    }
}
