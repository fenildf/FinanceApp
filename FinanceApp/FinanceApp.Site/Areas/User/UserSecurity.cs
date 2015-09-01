using System.Collections.Generic;
using FinanceApp.Common;
using FinanceApp.Model;
using FinanceApp.Site.Areas.Basic;

namespace FinanceApp.Site.Areas.User
{
    public class UserSecurity : UserModel
    {
        private Corporation corp;
        private Department dept;
        private List<Asset> assets;
        private Dictionary<StyleEnum, DetailCollection> authValues;
        private List<AuthGroup> authGroups;
        private List<Role> roles;
        private List<Menu> menus;
        private List<AuthOption> authOptions;
        private List<AuthOptionDetail> authOptionDetails;

        public UserSecurity()
        {
            corp = new Corporation();
            dept = new Department();
            assets = new List<Asset>();
            authValues = new Dictionary<StyleEnum, DetailCollection>();
            authGroups = new List<AuthGroup>();
            roles = new List<Role>();
            menus = new List<Menu>();
            authOptions = new List<AuthOption>();
            authOptionDetails = new List<AuthOptionDetail>();
        }

        public UserModel User { get; set; }

        /// <summary>
        /// 集团
        /// </summary>
        public Bloc Bloc { get; set; }

        /// <summary>
        /// 公司列表
        /// </summary>
        public Corporation Corp
        {
            get { return this.corp; }
            set { this.corp = value; }
        }

        /// <summary>
        /// 部门列表
        /// </summary>
        public Department Dept
        {
            get { return this.dept; }
            set { this.dept = value; }
        }

        /// <summary>
        /// 员工
        /// </summary>
        public Employee Emp { get; set; }

        /// <summary>
        /// 账户
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// 品种列表
        /// </summary>
        public List<Asset> Assets
        {
            get { return this.assets; }
            set { this.assets = value; }
        }

        /// <summary>
        /// 权限值词典
        /// </summary>
        public Dictionary<StyleEnum, DetailCollection> AuthValues
        {
            get { return this.authValues; }
            set { this.authValues = value; }
        }

        /// <summary>
        /// 权限组列表
        /// </summary>
        public List<AuthGroup> AuthGroups
        {
            get { return this.authGroups; }
            set { this.authGroups = value; }
        }

        /// <summary>
        /// 角色列表
        /// </summary>
        public List<Role> Roles
        {
            get { return this.roles; }
            set { this.roles = value; }
        }

        /// <summary>
        /// 菜单列表
        /// </summary>
        public List<Menu> Menus
        {
            get { return this.menus; }
            set { this.menus = value; }
        }

        public List<AuthOption> AuthOptions
        {
            get { return this.authOptions; }
            set { this.authOptions = value; }
        }

        public List<AuthOptionDetail> AuthOptionDetails
        {
            get { return this.authOptionDetails; }
            set { this.authOptionDetails = value; }
        }
    }
}
