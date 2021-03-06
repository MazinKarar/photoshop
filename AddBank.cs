﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Threading;

namespace Purchase
{
    public partial class AddBank : DevExpress.XtraEditors.XtraUserControl
    {
        Purchase.AccountingSystem dbContext;
        public AddBank()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Purchase.AccountingSystem();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.BankSets.Load();
            // This l bindingSource1.DataSource = dbContext.BankSets.Local.Select(b => b.BankName).Distinct().ToList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContextine of code is generated by Data Source Configuration Wizard
           
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.BankSets.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource1.DataSource = dbContext.BankSets.Local.ToBindingList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BankName.Text.Equals("")||BankBranch.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ملئ كل الحقول");
            }
            else
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(1000);
                using (var db = new AccountingSystem())
                {
                    var BankBranh1 = db.BankBranches.Create();
                    BankBranh1.BranchName = BankBranch.Text;
                    BankBranh1.IdBank = BankName.EditValue.ToString();
                    db.BankBranches.Add(BankBranh1);
                    db.SaveChanges();
                    BankBranch.Text = "";
                    splashScreenManager1.CloseWaitForm();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form storeForm = new AddBanks();
            //storeForm.Controls.Add(new AddBanks());
            storeForm.BackColor = System.Drawing.Color.White;
            storeForm.StartPosition = FormStartPosition.CenterScreen;
            storeForm.Width = 320;
            //storeForm.WindowState = FormWindowState.Maximized;
            DialogResult x = storeForm.ShowDialog();

            if (x == DialogResult.Cancel)
            {
                dbContext = new Purchase.AccountingSystem();
                bindingSource1.DataSource = dbContext.BankSets.ToList();
                BankName.Refresh();
            }
        }

        private void AddBank_Load(object sender, EventArgs e)
        {

        }
        public void bankRefresh()
        {
            dbContext = new Purchase.AccountingSystem();
            bindingSource1.DataSource = dbContext.BankSets.Local.ToBindingList();
            BankName.Refresh();
        }

    }
}
