/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IMenuDAL.cs
// 文件功能描述：功能菜单表dbo.Menu数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 功能菜单表dbo.Menu数据交互接口。
    /// </summary>
    public class MenuBLL : BaseBLL<Menu>
    {
        private readonly MenuDAL menuDAL = new MenuDAL();
        
        protected override BaseDAL<Menu> CurDALInstance{
            get{return menuDAL;}
        }
    }
}
