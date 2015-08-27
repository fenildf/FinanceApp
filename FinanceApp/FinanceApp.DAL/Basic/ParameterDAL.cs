/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IParameterDAL.cs
// 文件功能描述：参数表dbo.Parameter数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using System;
using System.Data.Entity;
using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.DAL
{
    /// <summary>
    /// 参数表dbo.Parameter数据交互接口。
    /// </summary>
    public class ParameterDAL : BaseDAL<Parameter>,IParameterDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Parameter entity)
        {
            throw new NotImplementedException();
        }
    }
}
