//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Login
    {
        public int Sl_No { get; set; }
        public string UserID { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public int LoginAttempts { get; set; }
        public bool IsLocked { get; set; }
    }
}
