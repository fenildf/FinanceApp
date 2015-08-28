/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IContractClauseDetailDAL.cs
// 文件功能描述：合约条款明细dbo.ContractClauseDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 合约条款明细dbo.ContractClauseDetail数据交互接口。
    /// </summary>
    public class ContractClauseDetailBLL : BaseBLL<ContractClauseDetail>
    {
        private readonly ContractClauseDetailDAL contractclausedetailDAL = new ContractClauseDetailDAL();
        
        protected override BaseDAL<ContractClauseDetail> CurDALInstance{
            get{return contractclausedetailDAL;}
        }
    }
}
