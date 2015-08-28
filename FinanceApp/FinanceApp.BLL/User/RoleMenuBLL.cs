/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IRoleMenuDAL.cs
// 文件功能描述：角色菜单关联表dbo.RoleMenu数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 角色菜单关联表dbo.RoleMenu数据交互接口。
    /// </summary>
    public class RoleMenuBLL : BaseBLL<RoleMenu>
    {
        private readonly RoleMenuDAL rolemenuDAL = new RoleMenuDAL();
        
        protected override BaseDAL<RoleMenu> CurDALInstance{
            get{return rolemenuDAL;}
        }
    }
}
