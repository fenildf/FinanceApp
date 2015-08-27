/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ISm_SmsParameterDAL.cs
// 文件功能描述：消息类型构造参数dbo.Sm_SmsParameter数据交互接口。
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
    /// 消息类型构造参数dbo.Sm_SmsParameter数据交互接口。
    /// </summary>
    public class Sm_SmsParameterDAL : BaseDAL<Sm_SmsParameter>,ISm_SmsParameterDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Sm_SmsParameter entity)
        {
            throw new NotImplementedException();
        }
    }
}
