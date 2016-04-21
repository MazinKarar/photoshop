﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace Purchase
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Purchase.AccountingSystem dbContext = new Purchase.AccountingSystem();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.InvoiceDetails.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource1.DataSource = dbContext.InvoiceDetails.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Items.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource2.DataSource = dbContext.Items.Local.ToBindingList();
        }

    
    }
}