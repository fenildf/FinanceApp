/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ISm_SmsDAL.cs
// 文件功能描述：消息dbo.Sm_Sms数据交互接口。
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
    /// 消息dbo.Sm_Sms数据交互接口。
    /// </summary>
    public class Sm_SmsDAL : BaseDAL<Sm_Sms>,ISm_SmsDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Sm_Sms entity)
        {
            throw new NotImplementedException();
        }
    }
}
