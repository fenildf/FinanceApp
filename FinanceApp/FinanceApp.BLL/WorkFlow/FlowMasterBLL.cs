/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_FlowMasterDAL.cs
// 文件功能描述：流程模板dbo.Wf_FlowMaster数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 流程模板dbo.Wf_FlowMaster数据交互接口。
    /// </summary>
    public class Wf_FlowMasterBLL : BaseBLL<Wf_FlowMaster>
    {
        private readonly Wf_FlowMasterDAL wf_flowmasterDAL = new Wf_FlowMasterDAL();
        
        protected override BaseDAL<Wf_FlowMaster> CurDALInstance{
            get{return wf_flowmasterDAL;}
        }
    }
}
