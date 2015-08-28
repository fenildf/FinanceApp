/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ISm_SmsDAL.cs
// 文件功能描述：消息dbo.Sm_Sms数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 消息dbo.Sm_Sms数据交互接口。
    /// </summary>
    public class Sm_SmsBLL : BaseBLL<Sm_Sms>
    {
        private readonly Sm_SmsDAL sm_smsDAL = new Sm_SmsDAL();
        
        protected override BaseDAL<Sm_Sms> CurDALInstance{
            get{return sm_smsDAL;}
        }
    }
}
