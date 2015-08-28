/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_NodeOperateDAL.cs
// 文件功能描述：节点操作表dbo.Wf_NodeOperate数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 节点操作表dbo.Wf_NodeOperate数据交互接口。
    /// </summary>
    public class Wf_NodeOperateBLL : BaseBLL<Wf_NodeOperate>
    {
        private readonly Wf_NodeOperateDAL wf_nodeoperateDAL = new Wf_NodeOperateDAL();
        
        protected override BaseDAL<Wf_NodeOperate> CurDALInstance{
            get{return wf_nodeoperateDAL;}
        }
    }
}
