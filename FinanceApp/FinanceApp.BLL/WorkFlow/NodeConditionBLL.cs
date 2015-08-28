/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_NodeConditionDAL.cs
// 文件功能描述：节点条件表dbo.Wf_NodeCondition数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 节点条件表dbo.Wf_NodeCondition数据交互接口。
    /// </summary>
    public class Wf_NodeConditionBLL : BaseBLL<Wf_NodeCondition>
    {
        private readonly Wf_NodeConditionDAL wf_nodeconditionDAL = new Wf_NodeConditionDAL();
        
        protected override BaseDAL<Wf_NodeCondition> CurDALInstance{
            get{return wf_nodeconditionDAL;}
        }
    }
}
