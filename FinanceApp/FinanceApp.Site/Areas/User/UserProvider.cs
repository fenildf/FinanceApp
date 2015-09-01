/*----------------------------------------------------------------
// Copyright (C) 2014-2015 上海迪亮信息科技有限公司 版权所有。 
// 文件名：UserProvider.cs
// 文件功能描述：用户提供类。
// 创建人：CodeSmith
// 创建时间： 2014年6月21日
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Site.Areas.User
{
    public class UserProvider
    {
        private static Dictionary<string, User.UserSecurity> Securities = null;
        private static Dictionary<string, Common.UserModel> Users = null;
        private static Dictionary<string, string> Accounts = null;

        static UserProvider()
        {
            Securities = new Dictionary<string, UserSecurity>();
            Users = new Dictionary<string, Common.UserModel>();
            Accounts = new Dictionary<string, string>();

            blocs = new List<Model.Bloc>();
            corporations = new List<Model.Corporation>();
            departments = new List<Model.Department>();
            employees = new List<Model.Employee>();
        }

        public static string GetAccountName(string ticket)
        {
            return Accounts.ContainsKey(ticket) ? Accounts[ticket] : string.Empty;
        }

        public static void AddAccountName(string ticket, string accountName)
        {
            if (Accounts.ContainsKey(ticket))
                return;
            lock (Accounts)
            {
                if (!Accounts.ContainsKey(ticket))
                    Accounts.Add(ticket, accountName);
            }
        }

        public static User.UserSecurity GetUserSecurity(string ticket, string accountName)
        {
            UserSecurity security = null;

            if (Securities.ContainsKey(accountName))
            {
                security = Securities[accountName];

                if (security != null)
                    return security;
                //if (security.CookieValue != ticket)
                //    return null;
            }

            Common.ResultModel result = RegisterUserSecurity(ticket,accountName);

            return result.ResultStatus ==0 ? Securities[accountName] : security;
        }

        /// <summary>
        /// 待修改
        /// 待增加验证匹配ticket与accountName
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public static Common.UserModel GetUserModel(string ticket, string accountName)
        {
            Common.UserModel user = null;

            if (Users.ContainsKey(accountName))
            {
                user = Users[accountName];
                if (user.CookieValue != ticket)
                    return null;
            }

            RegisterUserModel(ticket,accountName);

            user = Users[accountName];
            return user;
        }

        //internal static Common.UserModel GetUserModel(string accountName)
        //{
        //    if (UserProvider.Users.ContainsKey(accountName))
        //        return UserProvider.Users[accountName];

        //    RegisterUserModel(accountName);

        //    return UserProvider.Users[accountName];
        //}

        private static Common.ResultModel RegisterUserSecurity(string ticket, string accountName)
        {
            Common.ResultModel result = null;

            UserSecurity security = new UserSecurity();

            security.CookieValue = ticket;
            //Account
            Model.Account account = null;
            DAL.AccountDAL accountDal = new DAL.AccountDAL();
            security.Account = accountDal.Find(acc => acc.AccountName == "accountName");

            //Employee
            Model.Employee emp = null;
            DAL.EmployeeDAL empDal = new DAL.EmployeeDAL();
            security.Emp = empDal.Find(e => e.EmpId == account.EmpId); 

            //Department
            Model.Department dept = new Model.Department();
            DAL.DepartmentDAL deptDal = new DAL.DepartmentDAL();
            security.Dept = deptDal.Find(d => d.DeptId == emp.DeptId);

            //Corporation
            Model.Corporation corp = new Model.Corporation();
            DAL.CorporationDAL corpDal = new DAL.CorporationDAL();
            security.Corp = corpDal.Find(c => c.CorpId == dept.CorpId);

            //Bloc
            Model.Bloc bloc = new Model.Bloc();
            DAL.BlocDAL blocDal = new DAL.BlocDAL();
            if (security.Corp != null)
                security.Bloc = blocDal.Find(b => b.BlocId == security.Corp.ParentId);

            //Role
            List<Model.Role> roles = new List<Model.Role>();
            DAL.RoleDAL roleDal = new DAL.RoleDAL();
            result = roleDal.Load(emp.EmpId);
            if (result.ResultStatus == 0)
                roles = result.ReturnValue as List<Model.Role>;
            security.Roles = roles;

            //Menu
            List<Model.Menu> menus = new List<Model.Menu>();
            DAL.MenuDAL menuDal = new DAL.MenuDAL();
            result = menuDal.Load(emp.EmpId);
            if (result.ResultStatus == 0)
                menus = result.ReturnValue as List<Model.Menu>;
            security.Menus = menus;

            Common.UserModel user = security;
            user.AccountId = security.Account.AccId;
            user.AccountName = security.Account.AccountName;
            user.EmpId = security.Emp.EmpId;
            user.EmpName = security.Emp.Name;
            user.CorpId = security.Corp.CorpId;
            user.DeptId = security.Dept.DeptId;

            lock (Securities)
            {
                if (!Securities.ContainsKey(accountName))
                    Securities.Add(accountName, security);
            }

            result.ResultStatus = 0;
            return result;
        }

        private static void RegisterUserModel(string ticket,string accountName)
        {
            Common.ResultModel result = null;

            Common.UserModel user = new Common.UserModel();

            //cookie value
            user.CookieValue = ticket;

            //Account
            Model.Account account = null;
            DAL.AccountDAL accountDal = new DAL.AccountDAL();
            result = accountDal.Get(Common.DefaultValue.SysUser, accountName);
            if (result.ResultStatus == 0)
                account = result.ReturnValue as Model.Account;
            user.AccountId = account.AccId;
            user.AccountName = account.AccountName;

            //Employee
            Model.Employee emp = null;
            DAL.EmployeeDAL empDal = new DAL.EmployeeDAL();
            result = empDal.Get(Common.DefaultValue.SysUser, account.EmpId);
            if (result.ResultStatus == 0)
                emp = result.ReturnValue as Model.Employee;
            user.EmpId = emp.EmpId;

            ////Department
            //List<Model.Department> depts = new List<Model.Department>();
            //DAL.DepartmentDAL deptDal = new DAL.DepartmentDAL();
            //result = deptDal.Load(Common.DefaultValue.SysUser, emp.EmpId);
            //if (result.ResultStatus == 0)
            //    depts = result.ReturnValue as List<Model.Department>;
            //foreach(Model.Department dept in depts)
            //{
            //    user.DeptIds.Add(dept.DeptId);
            //}

            ////Corporation
            //List<Model.Corporation> corps = new List<Model.Corporation>();
            //DAL.CorporationDAL corpDal = new DAL.CorporationDAL();
            //result = corpDal.Load(Common.DefaultValue.SysUser, emp.EmpId);
            //if (result.ResultStatus == 0)
            //    corps = result.ReturnValue as List<Model.Corporation>;
            //foreach (Model.Corporation corp in corps)
            //{
            //    user.CorpIds.Add(corp.CorpId);
            //}

            ////Bloc
            //Model.Bloc bloc = new Model.Bloc();
            //DAL.BlocDAL blocDal = new DAL.BlocDAL();
            //result = blocDal.Get(Common.DefaultValue.SysUser, emp.BlocId);
            //if (result.ResultStatus == 0)
            //    bloc = result.ReturnValue as Model.Bloc;
            //user.BlocId = bloc.BlocId;

            ////Role
            //List<Model.Role> roles = new List<Model.Role>();
            //DAL.RoleDAL roleDal = new DAL.RoleDAL();
            //result = roleDal.Load(Common.DefaultValue.SysUser, emp.EmpId);
            //if (result.ResultStatus == 0)
            //    roles = result.ReturnValue as List<Model.Role>;
            ////user.Roles = roles;

            ////Menu
            //List<Model.Menu> menus = new List<Model.Menu>();
            //DAL.MenuDAL menuDal = new DAL.MenuDAL();
            //result = menuDal.Load(Common.DefaultValue.SysUser, emp.EmpId);
            //if (result.ResultStatus == 0)
            //    menus = result.ReturnValue as List<Model.Menu>;
            ////user.Menus = menus;

            ////AuthOptionDetailEmpRef
            //List<Model.AuthOptionDetailEmpRef> refs = new List<Model.AuthOptionDetailEmpRef>();
            //DAL.AuthOptionDetailEmpRefDal refDal = new DAL.AuthOptionDetailEmpRefDal();
            //result = refDal.Load(Common.DefaultValue.SysUser, emp.EmpId);
            //if (result.ResultStatus == 0)
            //    refs = result.ReturnValue as List<Model.AuthOptionDetailEmpRef>;
            ////security.Refs = refs;

            lock (Users)
            {
                if (!Users.ContainsKey(accountName))
                    Users.Add(accountName, user);
            }
        }

        public static void RefreshUser()
        {
            if (Securities != null)
                Securities.Clear();
            if (Users != null)
                Users.Clear();
            if (Accounts != null)
                Accounts.Clear();
            if (Blocs != null)
                Blocs.Clear();
            if (Corporations != null)
                Corporations.Clear();
            if (Departments != null)
                Departments.Clear();
            if (Employees != null)
                Employees.Clear();

            User.MenuProvider.RefreshMenus();
        }

        private static List<Model.Bloc> blocs ; 
        private static List<Model.Corporation> corporations ;
        private static List<Model.Department> departments ;
        private static List<Model.Employee> employees;

        /// <summary>
        /// 集团列表
        /// </summary>
        public static List<Model.Bloc> Blocs
        {
            get
            {
                if (blocs != null && blocs.Count > 0)
                    return blocs;

                blocs = RegisterUser<Model.Bloc>(new DAL.BlocDAL());

                return blocs;
            }
        }

        /// <summary>
        /// 企业列表
        /// </summary>
        public static List<Model.Corporation> Corporations
        {
            get
            {
                if (corporations != null && corporations.Count > 0)
                    return corporations;

                corporations = RegisterUser<Model.Corporation>(new DAL.CorporationDAL());

                return corporations;
            }
        }

        /// <summary>
        /// 部门列表
        /// </summary>
        public static List<Model.Department> Departments
        {
            get
            {
                if (departments != null && departments.Count > 0)
                    return departments;

                departments = RegisterUser<Model.Department>(new DAL.DepartmentDAL());

                return departments;
            }
        }

        /// <summary>
        /// 员工列表
        /// </summary>
        public static List<Model.Employee> Employees
        {
            get
            {
                if (employees != null && employees.Count > 0)
                    return employees;

                employees = RegisterUser<Model.Employee>(new DAL.EmployeeDAL());

                return employees;
            }
        }

        private static List<T> RegisterUser<T>(DAL.BaseDAL<T> operate)
            where T : class
        {
            return operate.Load(a => true).ToList<T>();
        }
    }
}
