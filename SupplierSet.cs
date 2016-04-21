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
    
    public partial class SupplierSet
    {
        public SupplierSet()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int Id { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierStartBalance { get; set; }
        public string SupplierStartBlnsDate { get; set; }
        public string SupplierTypeOfBalance { get; set; }
        public string SupplierStatus { get; set; }
        public string SupplierBranch { get; set; }
        public string SupplierBranchCurrency { get; set; }
        public string SupplierLedger { get; set; }
        public string SupplierSupplementingAccount { get; set; }
        public string SupplierCompanyName { get; set; }
        public string SupplierResponsible { get; set; }
        public string SupplierArea { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhone1 { get; set; }
        public string SupplierPhone2 { get; set; }
        public string SupplierWebsite { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierBankNoAccount { get; set; }
        public string SupplierBankName { get; set; }
        public string SupplierBankBranach { get; set; }
    
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
