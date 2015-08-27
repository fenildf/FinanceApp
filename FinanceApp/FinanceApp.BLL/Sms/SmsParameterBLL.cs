/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：ISm_SmsParameterDAL.cs
// 文件功能描述：消息类型构造参数dbo.Sm_SmsParameter数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 消息类型构造参数dbo.Sm_SmsParameter数据交互接口。
    /// </summary>
    public class Sm_SmsParameterBLL : BaseBLL<Sm_SmsParameter>
    {
        public Sm_SmsParameterBLL(IBaseDAL<Sm_SmsParameter> currentDAL) : base(currentDAL) { }
    }
}
