﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceApp.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NFMT_User_ConnectStr : DbContext
    {
        public NFMT_User_ConnectStr()
            : base("name=NFMT_User_ConnectStr")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AuthGroup> AuthGroup { get; set; }
        public virtual DbSet<AuthGroupDetail> AuthGroupDetail { get; set; }
        public virtual DbSet<AuthOperate> AuthOperate { get; set; }
        public virtual DbSet<AuthOption> AuthOption { get; set; }
        public virtual DbSet<AuthOptionDetail> AuthOptionDetail { get; set; }
        public virtual DbSet<AuthOptionDetailEmp_Ref> AuthOptionDetailEmp_Ref { get; set; }
        public virtual DbSet<Bloc> Bloc { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<CorpDept> CorpDept { get; set; }
        public virtual DbSet<CorpDetailAttach> CorpDetailAttach { get; set; }
        public virtual DbSet<Corporation> Corporation { get; set; }
        public virtual DbSet<CorporationDetail> CorporationDetail { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DeptEmp> DeptEmp { get; set; }
        public virtual DbSet<EmpAuthGroup> EmpAuthGroup { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeContact> EmployeeContact { get; set; }
        public virtual DbSet<EmpMenu> EmpMenu { get; set; }
        public virtual DbSet<EmpRole> EmpRole { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleDept> RoleDept { get; set; }
        public virtual DbSet<RoleDeptMenu> RoleDeptMenu { get; set; }
        public virtual DbSet<RoleMenu> RoleMenu { get; set; }
        public virtual DbSet<RoleMenuOperate> RoleMenuOperate { get; set; }
    }
}