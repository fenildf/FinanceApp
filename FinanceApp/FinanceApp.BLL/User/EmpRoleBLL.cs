/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IEmpRoleDAL.cs
// 文件功能描述：员工角色关联表dbo.EmpRole数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 员工角色关联表dbo.EmpRole数据交互接口。
    /// </summary>
    public class EmpRoleBLL : BaseBLL<EmpRole>
    {
        private readonly EmpRoleDAL emproleDAL = new EmpRoleDAL();
        
        protected override BaseDAL<EmpRole> CurDALInstance{
            get{return emproleDAL;}
        }
    }
}
