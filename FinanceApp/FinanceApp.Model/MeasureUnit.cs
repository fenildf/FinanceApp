//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MeasureUnit
    {
        public int MUId { get; set; }
        public string MUName { get; set; }
        public Nullable<int> BaseId { get; set; }
        public decimal TransformRate { get; set; }
        public int MUStatus { get; set; }
        public int CreatorId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<int> LastModifyId { get; set; }
        public Nullable<System.DateTime> LastModifyTime { get; set; }
    }
}
