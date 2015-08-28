/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IDepartmentDAL.cs
// 文件功能描述：部门dbo.Department数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 部门dbo.Department数据交互接口。
    /// </summary>
    public class DepartmentBLL : BaseBLL<Department>
    {
        private readonly DepartmentDAL departmentDAL = new DepartmentDAL();
        
        protected override BaseDAL<Department> CurDALInstance{
            get{return departmentDAL;}
        }
    }
}
