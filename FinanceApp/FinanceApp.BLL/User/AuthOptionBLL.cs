/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAuthOptionDAL.cs
// 文件功能描述：权限项dbo.AuthOption数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 权限项dbo.AuthOption数据交互接口。
    /// </summary>
    public class AuthOptionBLL : BaseBLL<AuthOption>
    {
        private readonly AuthOptionDAL authoptionDAL = new AuthOptionDAL();
        
        protected override BaseDAL<AuthOption> CurDALInstance{
            get{return authoptionDAL;}
        }
    }
}
