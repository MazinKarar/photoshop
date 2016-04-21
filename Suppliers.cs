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

namespace Purchase
{
    public partial class Suppliers : DevExpress.XtraEditors.XtraUserControl
    {
        Purchase.AccountingSystem dbContext;
        string AccountOne = "";
        public Suppliers()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            dbContext = new Purchase.AccountingSystem();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.CurrencySets.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource1.DataSource = dbContext.CurrencySets.Local.ToBindingList();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.AreasSets.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource2.DataSource = dbContext.AreasSets.Local.ToBindingList();
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
            SupLedger.Text = AccountOne;
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

        private void button1_Click(object sender, EventArgs e)
        {
            news.Enabled = true;
            save.Enabled = false;
            update.Enabled = true;
            using (var db = new AccountingSystem())
            {
                SupplierSet dd = new SupplierSet();
                //var SupplierSet = db.SupplierSets.Create();
                dd.SupplierId = SubCode.Text;
                dd.SupplierName = SubName.Text;
                dd.SupplierStartBalance = SubBalance.Text;
                dd.SupplierStartBlnsDate = SubDateBalance.Value.ToString();
                dd.SupplierTypeOfBalance = SubTypeBalance.Text;
                dd.SupplierStatus = SubStatus.Checked.ToString();
                dd.SupplierBranch = SupBranch.Text;
                dd.SupplierBranchCurrency = SupCurrency.Text;
                dd.SupplierSupplementingAccount = SupSupplementingAccount.EditValue.ToString();
                dd.SupplierLedger = SupLedger.EditValue.ToString();
                dd.SupplierCompanyName = SubNameCompany.Text;
                dd.SupplierResponsible = SubResponsbile.Text;
                dd.SupplierArea = SubArea.Text;
                dd.SupplierAddress = SubAddress.Text;
                dd.SupplierPhone1 = SubPhone1.Text;
                dd.SupplierPhone2 = SubPhone2.Text;
                dd.SupplierWebsite = SubWebsite.Text;
                dd.SupplierEmail = SubEmail.Text;
                dd.SupplierBankNoAccount = SubBankNoAccount.Text;
                dd.SupplierBankName = SubBankName.Text;
                dd.SupplierBankBranach = SubBankBranch.Text;
                db.SupplierSets.Add(dd);
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
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            update.Enabled = false;
            news.Enabled = true;    

            using (var db = new AccountingSystem())
            {
                var dc = from c in db.SupplierSets
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                         };
                var list = dc.ToList();
                int id = list.Count;
                SubCode.Text = (id+1).ToString();
            }
            fillsearch();
        }

        private List<string> Datos()
        {
            
            List<string> listDatos = new List<string>();
            
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.SupplierSets
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.SupplierName,
                         };
                 var list = dc.ToList();
                 for (int i = 0; i < list.Count; i++)
                 {
                     listDatos.Add(list[i].SupplierName.ToString());
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            save.Enabled = false;
            news.Enabled = true;
            update.Enabled = true;
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.SupplierSets
                         where c.SupplierName.Equals(search.Text)
                         select new
                         {
                             c.Id,
                             c.SupplierId,
                             c.SupplierName,
                             c.SupplierStartBalance,
                             c.SupplierStartBlnsDate,
                             c.SupplierTypeOfBalance,
                             c.SupplierStatus,
                             c.SupplierBranch,
                             c.SupplierBranchCurrency,
                             c.SupplierLedger,
                             c.SupplierSupplementingAccount,
                             c.SupplierCompanyName,
                             c.SupplierResponsible,
                             c.SupplierArea,
                             c.SupplierAddress,
                             c.SupplierPhone1,
                             c.SupplierPhone2,
                             c.SupplierWebsite,
                             c.SupplierEmail,
                             c.SupplierBankNoAccount,
                             c.SupplierBankName,
                             c.SupplierBankBranach
                         };
                var list = dc.ToList();
                if (list.Count != 0)
                {
                    SubCode.Text =list[0].SupplierId;
                    SubName.Text =list[0].SupplierName;
                    SubBalance.Text =list[0].SupplierStartBalance;
                    //SubDateBalance.Value = DateTime.Parse(list[0].SupplierStartBalance.ToString());
                    SubTypeBalance.Text = list[0].SupplierTypeOfBalance;
                    if(list[0].SupplierStatus.Equals("True"))
                        SubStatus.Checked = true;
                    else
                        SubStatus.Checked = false;
                    SupBranch.Text = list[0].SupplierBranch;
                    SupCurrency.Text =list[0].SupplierBranchCurrency ;
                    SupLedger.EditValue = list[0].SupplierLedger;
                    SupSupplementingAccount.EditValue =list[0].SupplierSupplementingAccount ;
                    SubNameCompany.Text = list[0].SupplierCompanyName;
                    SubResponsbile.Text = list[0].SupplierResponsible;
                    SubArea.Text = list[0].SupplierArea;
                    SubAddress.Text = list[0].SupplierAddress;
                    SubPhone1.Text = list[0].SupplierPhone1;
                    SubPhone2.Text = list[0].SupplierPhone2;
                    SubWebsite.Text = list[0].SupplierWebsite;
                    SubEmail.Text = list[0].SupplierEmail;
                    SubBankNoAccount.Text = list[0].SupplierBankNoAccount;
                    SubBankName.Text = list[0].SupplierBankName;
                    SubBankBranch.Text = list[0].SupplierBankBranach;
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد عميل بهذا الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            //Wait pleaseWait = new Wait();
            //Application.DoEvents();
            //pleaseWait.Show();
            save.Enabled = false;
            news.Enabled = true;
            update.Enabled = true;
            SupplierSet Sup = new SupplierSet();
            //InitializeComponent();
            using (var db = new AccountingSystem())
            {
                try
                {

                var SupplierSet = db.SupplierSets.First(x => x.SupplierId.Equals(SubCode.Text));
                SupplierSet.SupplierId = SubCode.Text;
                SupplierSet.SupplierName = SubName.Text;
                SupplierSet.SupplierStartBalance = SubBalance.Text;
                SupplierSet.SupplierStartBlnsDate = SubDateBalance.Value.ToString();
                SupplierSet.SupplierTypeOfBalance = SubTypeBalance.Text;
                SupplierSet.SupplierStatus = SubStatus.Checked.ToString();
                SupplierSet.SupplierBranch = SupBranch.Text;
                SupplierSet.SupplierBranchCurrency = SupCurrency.Text;
                SupplierSet.SupplierSupplementingAccount = SupSupplementingAccount.EditValue.ToString();
                SupplierSet.SupplierLedger = SupLedger.EditValue.ToString();
                SupplierSet.SupplierCompanyName = SubNameCompany.Text;
                SupplierSet.SupplierResponsible = SubResponsbile.Text;
                SupplierSet.SupplierArea = SubArea.Text;
                SupplierSet.SupplierAddress = SubAddress.Text;
                SupplierSet.SupplierPhone1 = SubPhone1.Text;
                SupplierSet.SupplierPhone2 = SubPhone2.Text;
                SupplierSet.SupplierWebsite = SubWebsite.Text;
                SupplierSet.SupplierEmail = SubEmail.Text;
                SupplierSet.SupplierBankNoAccount = SubBankNoAccount.Text;
                SupplierSet.SupplierBankName = SubBankName.Text;
                SupplierSet.SupplierBankBranach = SubBankBranch.Text;
                db.Entry(SupplierSet).State = System.Data.Entity.EntityState.Modified;
                
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
            //pleaseWait. ;
            //pleaseWait.Close(TimeSpan.FromSeconds(0));
            //MessageBox.Show("تم التحديث بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void news_Click(object sender, EventArgs e)
        {
            save.Enabled = true;
            update.Enabled = false;

            using (var db = new AccountingSystem())
            {
                var dc = from c in db.SupplierSets
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                         };
                var list = dc.ToList();
                int id = list.Count;
                SubCode.Text = (id + 1).ToString();
            }
            SubName.Text = "";
            SubBalance.Text = "";
            //SubDateBalance.Value = DateTime.Parse(list[0].SupplierStartBalance.ToString());
            //SubTypeBalance.Text = "";
            SubStatus.Checked = false;
            SupBranch.Text = "";
            SupCurrency.Text = "";
            SupSupplementingAccount.Text = "";
            SubNameCompany.Text = "";
            SubResponsbile.Text = "";
            SubArea.Text = "";
            SubAddress.Text = "";
            SubPhone1.Text = "";
            SubPhone2.Text = "";
            SubWebsite.Text = "";
            SubEmail.Text = "";
            SubBankNoAccount.Text = "";
            SubBankName.Text = "";
            SubBankBranch.Text = "";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FlyoutAction action = new FlyoutAction();
            action.Caption = "المناطق";
            MainAr c= new MainAr();
            MyFlyoutDialog dialog = new MyFlyoutDialog(this.ParentForm ,action , new AddArea());
            dialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Width = 200;
            dialog.ShowDialog();
        }
        public class MyFlyoutDialog : FlyoutDialog
        {
            public MyFlyoutDialog(Form owner, FlyoutAction action, Control control)
                : base(owner, action)
            {
                FlyoutControl = control;
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FlyoutAction action = new FlyoutAction();
            action.Caption = "العملات";
            MainAr c = new MainAr();
            MyFlyoutDialog dialog = new MyFlyoutDialog(this.ParentForm, action, new AddCurrnceys());
            dialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Width = 200;
            dialog.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            FlyoutAction action = new FlyoutAction();
            action.Caption = "البنوك";
            MainAr c = new MainAr();
            MyFlyoutDialog dialog = new MyFlyoutDialog(this.ParentForm, action, new AddBank());
            dialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Width = 200;
            dialog.ShowDialog();
        }

        private void SubBankName_EditValueChanged(object sender, EventArgs e)
        {
            using(var d = new AccountingSystem()){
                var dc = from ff in d.BankBranches
                         where (ff.IdBank.Equals(SubBankName.EditValue.ToString()))
                         select new { ff.BranchName, ff.Id };
                bindingSource4.DataSource = dc.ToList();
                SubBankBranch.Refresh();
            }
        }
        public void bankRefresh()
        {
            bindingSource3.DataSource = dbContext.BankSets.Local.ToBindingList();
        }
        private void SubBankBranch_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FlyoutAction action = new FlyoutAction();
            action.Caption = "الحسابات";
            MainAr c = new MainAr();
            MyFlyoutDialog dialog = new MyFlyoutDialog(this.ParentForm, action, new SelectAccounts());
            dialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Width = 200;
            dialog.ShowDialog();
            
        }
        public void SetAccountOne(String s,int id)
        {

            AccountOne = s;
            SupLedger.Text = s;
            //textBox1.L = s;
            SupLedger.EditValue = id;
            MessageBox.Show(s);
            SupLedger.Refresh();
        }
    }
}
