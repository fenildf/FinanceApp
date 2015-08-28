/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IWf_DataSourceDAL.cs
// 文件功能描述：数据源表dbo.Wf_DataSource数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 数据源表dbo.Wf_DataSource数据交互接口。
    /// </summary>
    public class Wf_DataSourceBLL : BaseBLL<Wf_DataSource>
    {
        private readonly Wf_DataSourceDAL wf_datasourceDAL = new Wf_DataSourceDAL();
        
        protected override BaseDAL<Wf_DataSource> CurDALInstance{
            get{return wf_datasourceDAL;}
        }
    }
}
