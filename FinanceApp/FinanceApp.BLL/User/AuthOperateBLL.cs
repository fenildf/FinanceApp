/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAuthOperateDAL.cs
// 文件功能描述：操作权限表dbo.AuthOperate数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 操作权限表dbo.AuthOperate数据交互接口。
    /// </summary>
    public class AuthOperateBLL : BaseBLL<AuthOperate>
    {
        private readonly AuthOperateDAL authoperateDAL = new AuthOperateDAL();
        
        protected override BaseDAL<AuthOperate> CurDALInstance{
            get{return authoperateDAL;}
        }
    }
}
