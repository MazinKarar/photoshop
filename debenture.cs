//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Purchase
{
    using System;
    using System.Collections.Generic;
    
    public partial class debenture
    {
        public debenture()
        {
            this.debenturedetails = new HashSet<debenturedetail>();
        }
    
        public int DebentureID { get; set; }
        public string DebentureNo { get; set; }
        public Nullable<System.DateTime> DebentureDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> MDate { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Notes { get; set; }
        public string remarks { get; set; }
    
        public virtual ICollection<debenturedetail> debenturedetails { get; set; }
    }
}
