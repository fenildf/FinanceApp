﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IEmployeeDAL.cs
// 文件功能描述：员工表dbo.Employee数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.Model;

namespace FinanceApp.IDAL
{
    /// <summary>
    /// 员工表dbo.Employee数据交互接口。
    /// </summary>
    public interface IEmployeeDAL : IBaseDAL<Employee>
    {
    }
}
