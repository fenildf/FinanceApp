/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_FlowMasterConfigDAL.cs
// 文件功能描述：流程模版配置表dbo.Wf_FlowMasterConfig数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 流程模版配置表dbo.Wf_FlowMasterConfig数据交互接口。
    /// </summary>
    public class Wf_FlowMasterConfigBLL : BaseBLL<Wf_FlowMasterConfig>
    {
        private readonly Wf_FlowMasterConfigDAL wf_flowmasterconfigDAL = new Wf_FlowMasterConfigDAL();
        
        protected override BaseDAL<Wf_FlowMasterConfig> CurDALInstance{
            get{return wf_flowmasterconfigDAL;}
        }
    }
}
