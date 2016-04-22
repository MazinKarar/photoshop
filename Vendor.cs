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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;
using System.Threading;


namespace Purchase
{
    public partial class Vendor : DevExpress.XtraEditors.XtraUserControl
    {
        private Purchase.AccountingSystem dbContext;
        public Vendor()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Purchase.AccountingSystem();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.CurrencySets.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource1.DataSource = dbContext.CurrencySets.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.AreasSets.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource2.DataSource = dbContext.AreasSets.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.BankSets.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource3.DataSource = dbContext.BankSets.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.BankBranches.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource4.DataSource = dbContext.BankBranches.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.TreeAccounts.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource5.DataSource = dbContext.TreeAccounts.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.TreeAccounts.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource6.DataSource = dbContext.TreeAccounts.Local.ToBindingList();
        }
        private List<string> Datos()
        {

            List<string> listDatos = new List<string>();

            using (var db = new AccountingSystem())
            {
                var dc = from c in db.VendorSets
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.VendorName,
                         };
                var list = dc.ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    listDatos.Add(list[i].VendorName.ToString());
                }

            }
            return listDatos;
        }
        private void fillsearch()
        {

            List<string> lista = Datos();
            search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.AddRange(lista.ToArray());
            search.AutoCompleteCustomSource = data;
            search.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void save_Click(object sender, EventArgs e)
        {
            

            if (VendName.Text.Equals("") || VendName.Text.Equals(" "))
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال اسم العميل");
            else if (VendBalance.Text.Equals("") || VendBalance.Text.Equals(" "))
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء الرصيد الابتدائي");
            else if (VendLedger.Text.Equals("") || VendLedger.Text.Equals(" "))
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار حساب الاستاذ");
            else if (VendSupplementingAccount.Text.Equals("") || VendSupplementingAccount.Text.Equals(" "))
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار الحساب المكمل");
            else
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(1000);
                news.Visible = true;
                save.Visible = false;
                update.Visible = true;
                using (var db = new AccountingSystem())
                {
                    var VendorSet = db.VendorSets.Create();
                    VendorSet.VendorId = VendCode.Text;
                    VendorSet.VendorName = VendName.Text;
                    VendorSet.VendorStartBalance = VendBalance.Text;
                    VendorSet.VendorStartBlnsDate = VendDateBalance.Value.ToString();
                    VendorSet.VendorTypeOfBalance = VendTypeBalance.Text;
                    VendorSet.VendorStatus = VendStatus.Checked.ToString();
                    VendorSet.VendorBranch = VendResponsbile.Text;
                    VendorSet.VendorBranchCurrency = VendCurrency.Text;
                    // VendorSet.VendorSupplementingAccount = VendSupplementingAccount.EditValue.ToString();
                    VendorSet.VendorLedger=VendLedger.EditValue.ToString();

                    VendorSet.VendorSupplementingAccount = VendSupplementingAccount.EditValue.ToString();
                    VendorSet.VendorCompanyName = VendNameCompany.Text;
                    VendorSet.VendorResponsible = VendBranch.Text;
                    VendorSet.VendorArea = VendArea.Text;
                    VendorSet.VendorAddress = VendAddress.Text;
                    VendorSet.VendorPhone1 = VendPhone1.Text;
                    VendorSet.VendorPhone2 = VendPhone2.Text;
                    VendorSet.VendorWebsite = VendWebsite.Text;
                    VendorSet.VendorEmail = VendEmail.Text;
                    VendorSet.VendorBankNoAccount = VendBankNoAccount.Text;
                    VendorSet.VendorBankName = VendBankName.Text;
                    VendorSet.VendorBankBranach = VendBankBranch.Text;
                    db.VendorSets.Add(VendorSet);
                    try
                    {

                        db.SaveChanges();
                    }
                    catch (Exception dbEx)
                    {
                        Exception raise = dbEx;
                        var val = dbEx.InnerException;
                        MessageBox.Show(val.ToString());
                    }
                    // MessageBox.Show("تم الحفظ بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fillsearch();
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void news_Click(object sender, EventArgs e)
        {
            save.Visible = true;
            update.Visible = false;

            using (var db = new AccountingSystem())
            {
                var dc = from c in db.VendorSets
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                         };
                var list = dc.ToList();
                int id = list.Count;
                VendCode.Text = (id + 1).ToString();
            }
            VendName.Text = "";
            VendBalance.Text = "";
            //VendDateBalance.Value = DateTime.Parse(list[0].VendorStartBalance.ToString());
            VendTypeBalance.Text = "";
            VendStatus.Checked = false;
            VendResponsbile.Text = "";
            VendCurrency.Text = "";
            VendSupplementingAccount.Text = "";
            VendNameCompany.Text = "";
            VendBranch.Text = "";
            VendArea.Text = "";
            VendAddress.Text = "";
            VendPhone1.Text = "";
            VendPhone2.Text = "";
            VendWebsite.Text = "";
            VendEmail.Text = "";
            VendBankNoAccount.Text = "";
            VendBankName.Text = "";
            VendBankBranch.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (VendName.Text.Equals("") || VendName.Text.Equals(" "))
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء ادخال اسم العميل");
            else if (VendBalance.Text.Equals("") || VendBalance.Text.Equals(" "))
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء الرصيد الابتدائي");
            else if (VendLedger.Text.Equals("") || VendLedger.Text.Equals(" "))
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار حساب الاستاذ");
            else if (VendSupplementingAccount.Text.Equals("") || VendSupplementingAccount.Text.Equals(" "))
                DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء اختيار الحساب المكمل");
            else
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(1000);
                //Wait pleaseWait = new Wait();
                //Application.DoEvents();
                //pleaseWait.Show();
                save.Visible = false;
                news.Visible = true;
                update.Visible = true;
                VendorSet Sup = new VendorSet();
                //InitializeComponent();
                using (var db = new AccountingSystem())
                {
                    try
                    {

                        var VendorSet = db.VendorSets.First(x => x.VendorId.Equals(VendCode.Text));
                        VendorSet.VendorId = VendCode.Text;
                        VendorSet.VendorName = VendName.Text;
                        VendorSet.VendorStartBalance = VendBalance.Text;
                        VendorSet.VendorStartBlnsDate = VendDateBalance.Value.ToString();
                        VendorSet.VendorTypeOfBalance = VendTypeBalance.Text;
                        VendorSet.VendorStatus = VendStatus.Checked.ToString();
                        VendorSet.VendorBranch = VendResponsbile.Text;
                        VendorSet.VendorBranchCurrency = VendCurrency.Text;
                        VendorSet.VendorSupplementingAccount = VendSupplementingAccount.EditValue.ToString();
                        VendorSet.VendorLedger = VendLedger.EditValue.ToString();
                        VendorSet.VendorCompanyName = VendNameCompany.Text;
                        VendorSet.VendorResponsible = VendBranch.Text;
                        VendorSet.VendorArea = VendArea.Text;
                        VendorSet.VendorAddress = VendAddress.Text;
                        VendorSet.VendorPhone1 = VendPhone1.Text;
                        VendorSet.VendorPhone2 = VendPhone2.Text;
                        VendorSet.VendorWebsite = VendWebsite.Text;
                        VendorSet.VendorEmail = VendEmail.Text;
                        VendorSet.VendorBankNoAccount = VendBankNoAccount.Text;
                        VendorSet.VendorBankName = VendBankName.Text;
                        VendorSet.VendorBankBranach = VendBankBranch.Text;
                        db.Entry(VendorSet).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                    {
                        Exception raise = dbEx;
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                                raise = new InvalidOperationException(message, raise);
                            }
                        }
                        throw raise;
                    }
                    catch (Exception dbEx)
                    {
                        Exception raise = dbEx;
                        var val = dbEx.InnerException;
                        MessageBox.Show(val.ToString());
                        //throw raise;
                    }
                }
                fillsearch();
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            news.Visible = true;
            update.Visible = true;
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.VendorSets
                         where c.VendorName.Equals(search.Text)
                         select new
                         {
                             c.Id,
                             c.VendorId,
                             c.VendorName,
                             c.VendorStartBalance,
                             c.VendorStartBlnsDate,
                             c.VendorTypeOfBalance,
                             c.VendorStatus,
                             c.VendorBranch,
                             c.VendorBranchCurrency,
                             c.VendorLedger,
                             c.VendorSupplementingAccount,
                             c.VendorCompanyName,
                             c.VendorResponsible,
                             c.VendorArea,
                             c.VendorAddress,
                             c.VendorPhone1,
                             c.VendorPhone2,
                             c.VendorWebsite,
                             c.VendorEmail,
                             c.VendorBankNoAccount,
                             c.VendorBankName,
                             c.VendorBankBranach
                         };
                var list = dc.ToList();
                if (list.Count != 0)
                {
                    VendCode.Text = list[0].VendorId;
                    VendName.Text = list[0].VendorName;
                    VendBalance.Text = list[0].VendorStartBalance;
                    //VendDateBalance.Value = DateTime.Parse(list[0].VendorStartBalance.ToString());
                    VendTypeBalance.Text = list[0].VendorTypeOfBalance;
                    if(list[0].VendorStatus.Equals("True"))
                        VendStatus.Checked = true;
                    else
                        VendStatus.Checked = false;
                    VendResponsbile.Text = list[0].VendorBranch;
                    VendCurrency.Text = list[0].VendorBranchCurrency;
                    VendSupplementingAccount.Text = list[0].VendorSupplementingAccount;
                    try
                    {
                        VendLedger.EditValue = int.Parse(list[0].VendorLedger);
                    }
                    catch (Exception es)
                    {
                        VendLedger.EditValue = -1;
                    }
                    VendNameCompany.Text = list[0].VendorCompanyName;
                    VendBranch.Text = list[0].VendorResponsible;
                    VendArea.Text = list[0].VendorArea;
                    VendAddress.Text = list[0].VendorAddress;
                    VendPhone1.Text = list[0].VendorPhone1;
                    VendPhone2.Text = list[0].VendorPhone2;
                    VendWebsite.Text = list[0].VendorWebsite;
                    VendEmail.Text = list[0].VendorEmail;
                    VendBankNoAccount.Text = list[0].VendorBankNoAccount;
                    VendBankName.Text = list[0].VendorBankName;
                    VendBankBranch.Text = list[0].VendorBankBranach;
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد عميل بهذا الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            update.Visible = false;
            news.Visible = true;

            using (var db = new AccountingSystem())
            {
                var dc = from c in db.VendorSets
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                         };
                var list = dc.ToList();
                int id = list.Count;
                VendCode.Text = (id + 1).ToString();
            }
            fillsearch();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form storeForm = new Form();
            storeForm.Controls.Add(new AddArea());
            storeForm.BackColor = System.Drawing.Color.White;
            storeForm.StartPosition = FormStartPosition.CenterScreen;
            storeForm.Width = 320;
            //storeForm.WindowState = FormWindowState.Maximized;
            DialogResult x = storeForm.ShowDialog();

            if (x == DialogResult.Cancel)
            {
                dbContext = new Purchase.AccountingSystem();
                bindingSource2.DataSource = dbContext.AreasSets.ToList();
                VendArea.Refresh();
            }
        }
        public class MyFlyoutDialog : FlyoutDialog
        {
            public MyFlyoutDialog(Form owner, FlyoutAction action, Control control)
                : base(owner, action)
            {
                FlyoutControl = control;
            }
        }

        private void VendBranch_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Form storeForm = new Form();
            storeForm.Controls.Add(new AddCurrnceys());
            storeForm.BackColor = System.Drawing.Color.White;
            storeForm.StartPosition = FormStartPosition.CenterScreen;
            storeForm.Width = 320;
            //storeForm.WindowState = FormWindowState.Maximized;
            DialogResult x = storeForm.ShowDialog();

            if (x == DialogResult.Cancel)
            {
                dbContext = new Purchase.AccountingSystem();
                bindingSource1.DataSource = dbContext.CurrencySets.ToList();
                VendCurrency.Refresh();
            }
        }

        private void VendBankName_EditValueChanged(object sender, EventArgs e)
        {
            using(var d = new AccountingSystem())
            {
                var dc = from ff in d.BankBranches where (ff.IdBank.Equals(VendBankName.EditValue.ToString()))
                         select new {ff.BranchName,ff.IdBank,ff.Id};
                 bindingSource4.DataSource = dc.ToList();
                 VendBranch.Refresh();
            }
                
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Form storeForm = new Form();
            storeForm.Controls.Add(new AddBank());
            storeForm.BackColor = System.Drawing.Color.White;
            storeForm.StartPosition = FormStartPosition.CenterScreen;
            storeForm.Width = 320;
            //storeForm.WindowState = FormWindowState.Maximized;
            DialogResult x = storeForm.ShowDialog();

            if (x == DialogResult.Cancel)
            {
                dbContext = new Purchase.AccountingSystem();
                bindingSource3.DataSource = dbContext.BankSets.ToList();
                VendBankName.Refresh();
            }
        }

       public void bankRefresh()
       {
           dbContext = new Purchase.AccountingSystem();
           dbContext.BankSets.Load();
           bindingSource3.DataSource = dbContext.BankSets.Local.ToBindingList();

           VendBankName.Refresh();
       }
    }
}
