/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAuthOptionDetailEmp_RefDAL.cs
// 文件功能描述：权限项明细员工关联表dbo.AuthOptionDetailEmp_Ref数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 权限项明细员工关联表dbo.AuthOptionDetailEmp_Ref数据交互接口。
    /// </summary>
    public class AuthOptionDetailEmp_RefBLL : BaseBLL<AuthOptionDetailEmp_Ref>
    {
        public AuthOptionDetailEmp_RefBLL(IBaseDAL<AuthOptionDetailEmp_Ref> currentDAL) : base(currentDAL) { }
    }
}
