﻿/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IBrandAssetDAL.cs
// 文件功能描述：品牌品种关联表dbo.BrandAsset数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月28日
----------------------------------------------------------------*/

using FinanceApp.DAL;
using FinanceApp.Model;

namespace FinanceApp.BLL
{
    /// <summary>
    /// 品牌品种关联表dbo.BrandAsset数据交互接口。
    /// </summary>
    public class BrandAssetBLL : BaseBLL<BrandAsset>
    {
        private readonly BrandAssetDAL brandassetDAL = new BrandAssetDAL();
        
        protected override BaseDAL<BrandAsset> CurDALInstance{
            get{return brandassetDAL;}
        }
    }
}
