/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAuthGroupDAL.cs
// 文件功能描述：权限组dbo.AuthGroup数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 权限组dbo.AuthGroup数据交互接口。
    /// </summary>
    public class AuthGroupBLL : BaseBLL<AuthGroup>
    {
        private readonly AuthGroupDAL authgroupDAL = new AuthGroupDAL();
        
        protected override BaseDAL<AuthGroup> CurDALInstance{
            get{return authgroupDAL;}
        }
    }
}
