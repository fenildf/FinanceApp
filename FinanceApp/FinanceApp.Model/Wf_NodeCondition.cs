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
    
    public partial class Wf_NodeCondition
    {
        public int ConditionId { get; set; }
        public int ConditionStatus { get; set; }
        public int NodeId { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public Nullable<int> ConditionType { get; set; }
        public Nullable<int> LogicType { get; set; }
    }
}
