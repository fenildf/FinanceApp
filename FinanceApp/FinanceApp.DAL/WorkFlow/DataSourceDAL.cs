/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_DataSourceDAL.cs
// 文件功能描述：数据源表dbo.Wf_DataSource数据交互接口。
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
    /// 数据源表dbo.Wf_DataSource数据交互接口。
    /// </summary>
    public class Wf_DataSourceDAL : BaseDAL<Wf_DataSource>,IWf_DataSourceDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Wf_DataSource entity)
        {
            throw new NotImplementedException();
        }
    }
}
