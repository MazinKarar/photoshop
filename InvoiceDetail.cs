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
    
    public partial class InvoiceDetail
    {
        public long Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public double UnitPrice { get; set; }
        public long UnitQuantity { get; set; }
        public Nullable<long> cuid { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<long> duid { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
        public Nullable<int> State { get; set; }
    
        public virtual ItemGroup ItemGroup { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Item Item { get; set; }
    }
}
