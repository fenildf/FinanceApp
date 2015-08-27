/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ISm_SmsTypeDAL.cs
// 文件功能描述：消息类型dbo.Sm_SmsType数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 消息类型dbo.Sm_SmsType数据交互接口。
    /// </summary>
    public class Sm_SmsTypeBLL : BaseBLL<Sm_SmsType>
    {
        public Sm_SmsTypeBLL(IBaseDAL<Sm_SmsType> currentDAL) : base(currentDAL) { }
    }
}
