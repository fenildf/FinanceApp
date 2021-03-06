﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IContractMasterDAL.cs
// 文件功能描述：合约模板dbo.ContractMaster数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 合约模板dbo.ContractMaster数据交互接口。
    /// </summary>
    public class ContractMasterBLL : BaseBLL<ContractMaster>
    {
        private readonly ContractMasterDAL contractmasterDAL = new ContractMasterDAL();
        
        protected override BaseDAL<ContractMaster> CurDALInstance{
            get{return contractmasterDAL;}
        }
    }
}
