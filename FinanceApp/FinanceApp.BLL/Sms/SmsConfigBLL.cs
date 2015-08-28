/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ISm_SmsConfigDAL.cs
// 文件功能描述：消息配置dbo.Sm_SmsConfig数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 消息配置dbo.Sm_SmsConfig数据交互接口。
    /// </summary>
    public class Sm_SmsConfigBLL : BaseBLL<Sm_SmsConfig>
    {
        private readonly Sm_SmsConfigDAL sm_smsconfigDAL = new Sm_SmsConfigDAL();
        
        protected override BaseDAL<Sm_SmsConfig> CurDALInstance{
            get{return sm_smsconfigDAL;}
        }
    }
}
