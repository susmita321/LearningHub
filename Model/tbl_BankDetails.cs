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
    
    public partial class tbl_BankDetails
    {
        public System.Guid Id { get; set; }
        public string AccountNo { get; set; }
        public string IFSCCODE { get; set; }
        public string UPIID { get; set; }
        public string BranchCode { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        public virtual tbl_User tbl_User { get; set; }
    }
}
