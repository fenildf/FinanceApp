/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IRoleDeptMenuDAL.cs
// 文件功能描述：角色部门菜单关联表dbo.RoleDeptMenu数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 角色部门菜单关联表dbo.RoleDeptMenu数据交互接口。
    /// </summary>
    public class RoleDeptMenuBLL : BaseBLL<RoleDeptMenu>
    {
        private readonly RoleDeptMenuDAL roledeptmenuDAL = new RoleDeptMenuDAL();
        
        protected override BaseDAL<RoleDeptMenu> CurDALInstance{
            get{return roledeptmenuDAL;}
        }
    }
}
