/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IBDStyleDAL.cs
// 文件功能描述：基础类型编码表dbo.BDStyle数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 基础类型编码表dbo.BDStyle数据交互接口。
    /// </summary>
    public class BDStyleBLL : BaseBLL<BDStyle>
    {
        private readonly BDStyleDAL bdstyleDAL = new BDStyleDAL();
        
        protected override BaseDAL<BDStyle> CurDALInstance{
            get{return bdstyleDAL;}
        }
    }
}
