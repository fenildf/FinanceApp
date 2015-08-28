﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IBankAccountDAL.cs
// 文件功能描述：银行账号dbo.BankAccount数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 银行账号dbo.BankAccount数据交互接口。
    /// </summary>
    public class BankAccountBLL : BaseBLL<BankAccount>
    {
        private readonly BankAccountDAL bankaccountDAL = new BankAccountDAL();
        
        protected override BaseDAL<BankAccount> CurDALInstance{
            get{return bankaccountDAL;}
        }
    }
}
