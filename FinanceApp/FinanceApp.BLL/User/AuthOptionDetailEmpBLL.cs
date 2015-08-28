/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAuthOptionDetailEmp_RefDAL.cs
// 文件功能描述：权限项明细员工关联表dbo.AuthOptionDetailEmp_Ref数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 权限项明细员工关联表dbo.AuthOptionDetailEmp_Ref数据交互接口。
    /// </summary>
    public class AuthOptionDetailEmp_RefBLL : BaseBLL<AuthOptionDetailEmp_Ref>
    {
        private readonly AuthOptionDetailEmp_RefDAL authoptiondetailemp_refDAL = new AuthOptionDetailEmp_RefDAL();
        
        protected override BaseDAL<AuthOptionDetailEmp_Ref> CurDALInstance{
            get{return authoptiondetailemp_refDAL;}
        }
    }
}
