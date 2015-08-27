/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_NodeDAL.cs
// 文件功能描述：节点表dbo.Wf_Node数据交互接口。
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
    /// 节点表dbo.Wf_Node数据交互接口。
    /// </summary>
    public class Wf_NodeDAL : BaseDAL<Wf_Node>,IWf_NodeDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Wf_Node entity)
        {
            throw new NotImplementedException();
        }
    }
}
