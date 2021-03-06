﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IRoleDeptDAL.cs
// 文件功能描述：角色部门关联表dbo.RoleDept数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 角色部门关联表dbo.RoleDept数据交互接口。
    /// </summary>
    public class RoleDeptBLL : BaseBLL<RoleDept>
    {
        private readonly RoleDeptDAL roledeptDAL = new RoleDeptDAL();
        
        protected override BaseDAL<RoleDept> CurDALInstance{
            get{return roledeptDAL;}
        }
    }
}
