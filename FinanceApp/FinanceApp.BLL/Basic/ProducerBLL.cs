﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IProducerDAL.cs
// 文件功能描述：生产商dbo.Producer数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 生产商dbo.Producer数据交互接口。
    /// </summary>
    public class ProducerBLL : BaseBLL<Producer>
    {
        private readonly ProducerDAL producerDAL = new ProducerDAL();
        
        protected override BaseDAL<Producer> CurDALInstance{
            get{return producerDAL;}
        }
    }
}
