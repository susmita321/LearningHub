//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearningHub.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_StockDetails
    {
        public System.Guid StockId { get; set; }
        public Nullable<System.DateTime> StockDate { get; set; }
        public Nullable<decimal> GST { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.Guid> Bookid { get; set; }
        public Nullable<int> StockQty { get; set; }
        public Nullable<int> BalanceQty { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        public virtual tbl_BookDetails tbl_BookDetails { get; set; }
    }
}