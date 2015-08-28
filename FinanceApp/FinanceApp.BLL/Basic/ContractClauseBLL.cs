/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IContractClauseDAL.cs
// 文件功能描述：合约条款dbo.ContractClause数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 合约条款dbo.ContractClause数据交互接口。
    /// </summary>
    public class ContractClauseBLL : BaseBLL<ContractClause>
    {
        private readonly ContractClauseDAL contractclauseDAL = new ContractClauseDAL();
        
        protected override BaseDAL<ContractClause> CurDALInstance{
            get{return contractclauseDAL;}
        }
    }
}
