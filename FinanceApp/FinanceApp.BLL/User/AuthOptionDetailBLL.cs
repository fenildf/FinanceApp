/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAuthOptionDetailDAL.cs
// 文件功能描述：权限项明细dbo.AuthOptionDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 权限项明细dbo.AuthOptionDetail数据交互接口。
    /// </summary>
    public class AuthOptionDetailBLL : BaseBLL<AuthOptionDetail>
    {
        private readonly AuthOptionDetailDAL authoptiondetailDAL = new AuthOptionDetailDAL();
        
        protected override BaseDAL<AuthOptionDetail> CurDALInstance{
            get{return authoptiondetailDAL;}
        }
    }
}
