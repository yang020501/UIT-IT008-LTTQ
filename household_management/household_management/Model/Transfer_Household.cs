//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace household_management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transfer_Household
    {
        public int Stt { get; set; }
        public string Id { get; set; }
        public string Id_Owner { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Old_Id_Household { get; set; }
        public string Old_Address { get; set; }
        public string New_Id_Household { get; set; }
        public string New_Address { get; set; }
    
        public virtual Household_Registration Household_Registration { get; set; }
        public virtual Household_Registration Household_Registration1 { get; set; }
        public virtual Population Population { get; set; }
    }
}
