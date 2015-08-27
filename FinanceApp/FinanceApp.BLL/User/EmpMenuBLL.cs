/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IEmpMenuDAL.cs
// 文件功能描述：员工菜单关系表dbo.EmpMenu数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 员工菜单关系表dbo.EmpMenu数据交互接口。
    /// </summary>
    public class EmpMenuBLL : BaseBLL<EmpMenu>
    {
        public EmpMenuBLL(IBaseDAL<EmpMenu> currentDAL) : base(currentDAL) { }
    }
}
