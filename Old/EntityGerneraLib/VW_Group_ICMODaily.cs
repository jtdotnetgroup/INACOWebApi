//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityGerneraLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_Group_ICMODaily
    {
        public string FSrcID { get; set; }
        public System.DateTime 日期 { get; set; }
        public Nullable<int> 机台 { get; set; }
        public Nullable<int> 班组 { get; set; }
        public string 操作员 { get; set; }
        public decimal 计划数量 { get; set; }
        public decimal 派工数量 { get; set; }
        public decimal 完成数量 { get; set; }
        public decimal 合格数量 { get; set; }
        public string FMOBillNo { get; set; }
        public Nullable<int> FMOInterID { get; set; }
    }
}
