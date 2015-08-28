/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ISm_SmsDetailDAL.cs
// 文件功能描述：消息明细表dbo.Sm_SmsDetail数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 消息明细表dbo.Sm_SmsDetail数据交互接口。
    /// </summary>
    public class Sm_SmsDetailBLL : BaseBLL<Sm_SmsDetail>
    {
        private readonly Sm_SmsDetailDAL sm_smsdetailDAL = new Sm_SmsDetailDAL();
        
        protected override BaseDAL<Sm_SmsDetail> CurDALInstance{
            get{return sm_smsdetailDAL;}
        }
    }
}
