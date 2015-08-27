/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_DataSourceDAL.cs
// 文件功能描述：数据源表dbo.Wf_DataSource数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 数据源表dbo.Wf_DataSource数据交互接口。
    /// </summary>
    public class Wf_DataSourceBLL : BaseBLL<Wf_DataSource>
    {
        public Wf_DataSourceBLL(IBaseDAL<Wf_DataSource> currentDAL) : base(currentDAL) { }
    }
}
