using System;
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
    public partial class InvoiceRequest : DevExpress.XtraEditors.XtraUserControl
    {
        double InvoiceTotal ;
        long ControlFlag;
        int InvoiceID;
        public InvoiceRequest(long flag,int? invoiceID)
        {
            //try
           // {
                InitializeComponent();
                InvoiceID = invoiceID.HasValue?(int)invoiceID:0;
                comboBoxEdit1.DataSource = InvoiceUtils.getAllSuppliers();
                colCategoryID.DataSource = InvoiceUtils.getAllCategory();
                numericUpDown1.Value = InvoiceUtils.getIvoiceCount() + 1;
                this.dataGridView1.DataError+=dataGridView1_DataError;
                InvoiceTotal = 0;
                ControlFlag = flag;
                if(flag==InvoiceWorkflowState.Request){
                    labelControl5.Hide();
                    xtraTabControl1.Hide();
                    separatorControl2.Hide();

                }
                else if(flag==InvoiceWorkflowState.Approvement){

                    labelControl2.Text = "الرجاء الضغظ على موافقة او رفض";
                    simpleButton1.Text = "موافقة";
                    simpleButton2.Text = "رفض";

                    Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                    numericUpDown1.Value = inv.InvoiceId;
                    comboBoxEdit1.SelectedValue = inv.SupplierId;
                    dateTimePicker1.Value = inv.InvoiceDate;
                    InvoiceTotal = (double)inv.Total;
                    InvoiceTotalLabel.Text = InvoiceTotal + "  المجموع الكلي";
                    colProductID.DataSource = InvoiceUtils.getAllProducts();
                    dataGridView1.DataSource = InvoiceUtils.getInvoiceDetils(InvoiceID);
                    dataGridView1.ReadOnly = true; 
                    xtraTabControl1.Hide();
                    labelControl5.Hide();
                    separatorControl2.Hide();
                }
                else if (flag == InvoiceWorkflowState.Payment) {
                    Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                    numericUpDown1.Value = inv.InvoiceId;
                    comboBoxEdit1.SelectedValue = inv.SupplierId;
                    dateTimePicker1.Value = inv.InvoiceDate;
                    InvoiceTotal = (double)inv.Total;
                    InvoiceTotalLabel.Text = InvoiceTotal + "  المجموع الكلي";
                    colProductID.DataSource = InvoiceUtils.getAllProducts();
                    dataGridView1.DataSource = InvoiceUtils.getInvoiceDetils(InvoiceID);
                    dataGridView1.ReadOnly = true; 

                    simpleButton1.Location =new Point( 800,simpleButton1.Location.Y);
                    simpleButton2.Location =new Point( 700,simpleButton2.Location.Y);
                    simpleButton1.Text = "حفظ";
                    simpleButton2.Text = "إلغاء";
                }
                else if (flag == InvoiceWorkflowState.Completed) {
                    Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                    numericUpDown1.Value = inv.InvoiceId;
                    comboBoxEdit1.SelectedValue = inv.SupplierId;
                    dateTimePicker1.Value = inv.InvoiceDate;
                    InvoiceTotal = (double)inv.Total;
                    InvoiceTotalLabel.Text = InvoiceTotal + "  المجموع الكلي";
                    colProductID.DataSource = InvoiceUtils.getAllProducts();
                    dataGridView1.DataSource = InvoiceUtils.getInvoiceDetils(InvoiceID);
                    dataGridView1.ReadOnly = true;

                    labelControl2.Text = "الرجاء الضغظ على تأكيد او إلغاء";
                    simpleButton1.Text = "تأكيد";
                    simpleButton2.Text = "إلغاء";
                }
                else if (flag == InvoiceWorkflowState.Return) {
                    Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                    numericUpDown1.Value = inv.InvoiceId;
                    comboBoxEdit1.SelectedValue = inv.SupplierId;
                    dateTimePicker1.Value = inv.InvoiceDate;
                    InvoiceTotal = (double)inv.Total;
                    InvoiceTotalLabel.Text = InvoiceTotal + "  المجموع الكلي";
                    colProductID.DataSource = InvoiceUtils.getAllProducts();
                    dataGridView1.DataSource = InvoiceUtils.getInvoiceDetils(InvoiceID);
                }
            //}
            //catch (Exception e)
            //{

            //}
         
        }
       

        private void InvoiceRequest_Load(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        void dataGridView1_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {
            
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex ==-1) return;
            else
            {
                if (e.ColumnIndex == 0)
                {
                    int catId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var x=dataGridView1.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell;
                    x.DataSource = InvoiceUtils.getAllCategoryProducts(catId);
                    //colProductID.DataSource = InvoiceUtils.getAllCategoryProducts(catId);
                }
                //getPrice
               
                    
                    //InvoiceTotalLabel
                if (e.ColumnIndex == 3||e.ColumnIndex==2)
                {
                    InvoiceTotal = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];
                        if (null == row.Cells[3].Value)
                            row.Cells[3].Value = 0;

                        if (null == row.Cells[2].Value)
                            row.Cells[2].Value = 0;

                        double price = 0;
                        int qty = 0;
                        bool bool1 = double.TryParse(row.Cells[2].Value.ToString(), out price);
                        qty = int.TryParse(row.Cells[3].Value.ToString(), out qty) ? qty : 0;
                        InvoiceTotal += price * qty;
                        
                    }
                    InvoiceTotalLabel.Text = InvoiceTotal + "  المجموع الكلي";
                }
               
            }
        }

    

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ControlFlag == InvoiceWorkflowState.Request)
            {
                DateTime invoiceDatetime = dateTimePicker1.Value;
                int supID = int.Parse(comboBoxEdit1.SelectedValue.ToString());
                Invoice inv = new Invoice { InvoiceDate = invoiceDatetime, SupplierId = supID, WorkflowState = InvoiceWorkflowState.Request, Total = InvoiceTotal };
                InvoiceUtils.Add<Invoice>(inv);
                DataGridViewComboBoxCell cat;
                DataGridViewComboBoxCell pro;
                //Product product;
                //Category category;
                int catId;
                int proID;
                double unPrise;
                int Qty;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    cat = row.Cells[0] as DataGridViewComboBoxCell;
                    pro = row.Cells[1] as DataGridViewComboBoxCell;
                    catId = int.Parse(cat.Value.ToString());
                    proID = int.Parse(pro.Value.ToString());
                    unPrise = double.Parse(row.Cells[2].Value.ToString());
                    Qty = int.Parse(row.Cells[3].Value.ToString());
                    //product = InvoiceUtils.Find<Product>(proID);
                    //category = InvoiceUtils.Find<Category>(catId);
                    InvoiceDetail inDet = new InvoiceDetail { InvoiceId = inv.InvoiceId, ProductId = proID, CategoryId = catId, UnitQuantity = Qty, UnitPrice = unPrise };
                    InvoiceUtils.Add<InvoiceDetail>(inDet);
                }
                XtraMessageBox.AllowCustomLookAndFeel = true;
                DevExpress.XtraEditors.XtraMessageBox.Show(LookAndFeel.ParentLookAndFeel,"تمت العملية بنجاج", "حفظ الفاتورة", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else  if (ControlFlag == InvoiceWorkflowState.Approvement)
            {
                Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                inv.WorkflowState = InvoiceWorkflowState.Approvement;
                int result = InvoiceUtils.Update<Invoice>(inv);
                if(result==0)
                    DevExpress.XtraEditors.XtraMessageBox.Show(LookAndFeel.ParentLookAndFeel, "تمت العملية بنجاج", "تصديق فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ControlFlag == InvoiceWorkflowState.Payment)
            {
                //more payment stuff
                Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                inv.WorkflowState = InvoiceWorkflowState.Completed;
                int result = InvoiceUtils.Update<Invoice>(inv);
                if (result == 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show(LookAndFeel.ParentLookAndFeel, "تمت العملية بنجاج", "البيانات المالية لفاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ControlFlag == InvoiceWorkflowState.Completed)
            {
                Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                inv.WorkflowState = InvoiceWorkflowState.Completed;
                int result = InvoiceUtils.Update<Invoice>(inv);
                if (result == 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show(LookAndFeel.ParentLookAndFeel, "تمت العملية بنجاج", "تأكيد إكمال فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ControlFlag == InvoiceWorkflowState.Return)
            {
                //more return stuff
                Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                inv.WorkflowState = InvoiceWorkflowState.Return;
                int result = InvoiceUtils.Update<Invoice>(inv);
                if (result == 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show(LookAndFeel.ParentLookAndFeel, "تمت العملية بنجاج", "إرجاع فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (ControlFlag == InvoiceWorkflowState.Approvement)
            {
                Invoice inv = InvoiceUtils.Find<Invoice>(InvoiceID);
                inv.WorkflowState = InvoiceWorkflowState.Rejected;
                int result = InvoiceUtils.Update<Invoice>(inv);
                if (result == 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show(LookAndFeel.ParentLookAndFeel, "تمت العملية بنجاج", "تصديق فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
        }

    }
}