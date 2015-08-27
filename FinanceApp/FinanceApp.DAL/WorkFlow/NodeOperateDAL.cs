/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_NodeOperateDAL.cs
// 文件功能描述：节点操作表dbo.Wf_NodeOperate数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using System;
using System.Data.Entity;
using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.DAL
{
    /// <summary>
    /// 节点操作表dbo.Wf_NodeOperate数据交互接口。
    /// </summary>
    public class Wf_NodeOperateDAL : BaseDAL<Wf_NodeOperate>,IWf_NodeOperateDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Wf_NodeOperate entity)
        {
            throw new NotImplementedException();
        }
    }
}
