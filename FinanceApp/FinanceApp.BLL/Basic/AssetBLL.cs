﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IAssetDAL.cs
// 文件功能描述：品种表dbo.Asset数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 品种表dbo.Asset数据交互接口。
    /// </summary>
    public class AssetBLL : BaseBLL<Asset>
    {
        private readonly AssetDAL assetDAL = new AssetDAL();
        
        protected override BaseDAL<Asset> CurDALInstance{
            get{return assetDAL;}
        }
    }
}
