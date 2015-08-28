/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IBankDAL.cs
// 文件功能描述：银行dbo.Bank数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 银行dbo.Bank数据交互接口。
    /// </summary>
    public class BankBLL : BaseBLL<Bank>
    {
        private readonly BankDAL bankDAL = new BankDAL();
        
        protected override BaseDAL<Bank> CurDALInstance{
            get{return bankDAL;}
        }
    }
}
