using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;

namespace Purchase
{
    public partial class MainAr : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmSales SalesForm = new frmSales();
        InvoiceRequest invRequest = new InvoiceRequest(InvoiceWorkflowState.Request,null);
        InvoiceRequest invCompleted = new InvoiceRequest(InvoiceWorkflowState.Completed, null);
        public MainAr()
        {
            InitializeComponent();
           
            // Handling the QueryControl event that will populate all automatically generated Documents
            backstageViewClientControl2.Controls.Add(invRequest);
            backstageViewClientControl3.Controls.Add(invCompleted);

        }
        public MainAr(string userName,string Permission)
        {
            InitializeComponent();
            using (var db = new AccountingSystem())
            {
                int perId= int.Parse(Permission);
                PermissionControl per = new PermissionControl();
                    per = db.PermissionControls.Where(m => m.Id == perId ).First();
                if (per.CAdmin)
                 PageAdmin.Visible = true;
                if (per.CAccount)
                 PageAccountant.Visible = true;
                if (per.CBuys)
                    PagePurchase.Visible = true;
                if (per.CSells)
                    PageSales.Visible = true;
                if (per.CVendorSupplier)
                    PageSV.Visible = true;
                if (per.CWarehouse)
                    PageStore.Visible = true;
               
            }
            Username.Caption = userName;
            // Handling the QueryControl event that will populate all automatically generated Documents
        }

     
        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Control item = new ShowItems();
                documentManager1.View.AddDocument(item).Caption = "عرض";
                int index = tabbedView1.Documents.Count - 1;
                DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
                tabbedView1.Controller.Select(doc);
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

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Control item = new ItemsForm();
                
                documentManager1.View.AddDocument(item).Caption = "الأصناف";
                int index = tabbedView1.Documents.Count-1;

                DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
                tabbedView1.Controller.Select(doc);
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

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            FlyoutAction action = new FlyoutAction();
            action.Caption = "المجموعات";
            MyFlyoutDialog dialog = new MyFlyoutDialog(this, action, new GroupForms());
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

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Control item = new StoresForm();
                documentManager1.View.AddDocument(item).Caption="المخازن";
                int index = tabbedView1.Documents.Count - 1;
                DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
                tabbedView1.Controller.Select(doc);
            }
            catch (Exception) { }
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Control item = new ReportsPage();
                documentManager1.View.AddDocument(item).Caption = "المخازن";
                int index = tabbedView1.Documents.Count - 1;
                DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
                tabbedView1.Controller.Select(doc);
            }
            catch (Exception) { }
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControl Sup = new Suppliers();
            try
            {
              
                Control item = new Suppliers();
                documentManager1.View.AddDocument(item).Caption = "الموردين";
                int index = tabbedView1.Documents.Count - 1;
                DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
                tabbedView1.Controller.Select(doc);
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.ToString());
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new Vendor();
            documentManager1.View.AddDocument(item).Caption = "العملاء";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new VenforVendpliersReview();
            documentManager1.View.AddDocument(item).Caption = "عرض";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new AddUser();
            documentManager1.View.AddDocument(item).Caption = "المستخدمين";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new UserView();
            documentManager1.View.AddDocument(item).Caption = "عرض المستخدمين";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSales f = new frmSales();
            f.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new AccountantTree();
            documentManager1.View.AddDocument(item).Caption = "شجرة الحسابات";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new AddTreeAccount();
            documentManager1.View.AddDocument(item).Caption = "إضافة حساب";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new AllReport();
            documentManager1.View.AddDocument(item).Caption = "التقارير";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new InvoiceRequest(InvoiceWorkflowState.Request,null);
            documentManager1.View.AddDocument(item).Caption = "إذن شراء";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new InvoiceSearching(InvoiceWorkflowState.Approvement);
            documentManager1.View.AddDocument(item).Caption = "فاتورة شراء";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new constraint();
            documentManager1.View.AddDocument(item).Caption = "إضافة قيد";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new ViewConstraint();
            documentManager1.View.AddDocument(item).Caption ="عرض القيود";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new InvoiceSearching(InvoiceWorkflowState.Return);
            documentManager1.View.AddDocument(item).Caption = "مرتجع مشتريات";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new InvoiceSearching(InvoiceWorkflowState.Approvement);
            documentManager1.View.AddDocument(item).Caption = "طلبات الشراء";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            Control item = new InvoiceSearching(InvoiceWorkflowState.Payment);
            documentManager1.View.AddDocument(item).Caption = "طلبات شراء مصدقة";
            int index = tabbedView1.Documents.Count - 1;
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document doc = tabbedView1.Documents[index] as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            tabbedView1.Controller.Select(doc);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            System.Windows.Forms.Application.Exit();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
            {
 	            base.OnFormClosing(e);

                if (e.CloseReason == CloseReason.WindowsShutDown) return;

                // Confirm user wants to close
                switch (MessageBox.Show(this, "هل تريد الخروج؟", "خروج", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }      
            }

     

         

      
    }
}