/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：IMenuDAL.cs
// 文件功能描述：功能菜单表dbo.Menu数据交互接口。
// 创建人：CodeSmith
// 创建时间： 2015年8月27日
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using FinanceApp.Common;
using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.DAL
{
    /// <summary>
    /// 功能菜单表dbo.Menu数据交互接口。
    /// </summary>
    public class MenuDAL : BaseDAL<Menu>,IMenuDAL
    {
        public override DbContext CurrentContext
        {
            get { return new Model.NFMT_User_ConnectStr(); }
        }

        public override bool Invalid(Menu entity)
        {
            throw new NotImplementedException();
        }

        public ResultModel Load(int empId)
        {
            ResultModel result = new ResultModel();

            try
            {
                string cmdText = string.Format(" select distinct m.* from dbo.AuthOperate ao left join dbo.Menu m on ao.MenuId = m.MenuId where ao.EmpId ={0} and ao.AuthOperateStatus={1} and m.MenuStatus={1} union select distinct mParent.* from dbo.EmpMenu em left join dbo.Menu m on em.MenuId = m.MenuId left join dbo.Menu mParent on mParent.MenuId = m.ParentId where em.EmpId ={1} and em.RefStatus={1} and ISNULL(mParent.MenuId,0)<>0 and mParent.MenuStatus={1}", empId, (int)Common.StatusEnum.已生效);

                var menus = CurrentContext.Set<Menu>().SqlQuery(cmdText, null).ToListAsync();

                result.AffectCount = menus.Result.Count;
                result.Message = "获取列表成功";
                result.ResultStatus = 0;
                result.ReturnValue = menus;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return result;
        }
    }
}
