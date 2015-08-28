/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAreaDAL.cs
// 文件功能描述：地区表dbo.Area数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 地区表dbo.Area数据交互接口。
    /// </summary>
    public class AreaBLL : BaseBLL<Area>
    {
        private readonly AreaDAL areaDAL = new AreaDAL();
        
        protected override BaseDAL<Area> CurDALInstance{
            get{return areaDAL;}
        }
    }
}
