using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace Purchase
{
    public partial class ShowItems : DevExpress.XtraEditors.XtraUserControl
    {
        Purchase.AccountingSystem dbContext = new Purchase.AccountingSystem();
        public ShowItems()
        {
            InitializeComponent();

            dbContext.Wharehouses.Load();
            dbContext.ItemGroups.Load();
            dbContext.ItemMeasurementUnits.Load();
            dbContext.Items.Load();

            wharehousBindingSource.DataSource = dbContext.Wharehouses.Local.ToBindingList();
            itemGroupBindingSource.DataSource = dbContext.ItemGroups.Local.ToBindingList();
            itemBindingSource.DataSource = dbContext.Items.Local.ToBindingList();
        }
      

        private void MenuEditBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل تريد التعديل؟", "تأكيد", MessageBoxButtons.YesNo) !=
                 DialogResult.Yes)
                return;
            if (navigationPane1.SelectedPage.Caption.Equals("المخازن"))
            {
               string Id = StoreGrid.GetRowCellValue(StoreGrid.FocusedRowHandle,"Id").ToString();
               Form storeForm = new Form();
               storeForm.Controls.Add(new StoresForm(Id));
               storeForm.BackColor = System.Drawing.Color.White;
               storeForm.StartPosition = FormStartPosition.CenterScreen;
               storeForm.WindowState = FormWindowState.Maximized;
               DialogResult x = storeForm.ShowDialog();
               if (x == DialogResult.Cancel)
               {
                  dbContext= new Purchase.AccountingSystem();
                   wharehousBindingSource.DataSource =  dbContext.Wharehouses.ToList();
                   wharehousGridControl.RefreshDataSource();
               }
            }
            else
                if (navigationPane1.SelectedPage.Caption.Equals("الأصناف"))
                {
                   string code = ItemGrid.GetRowCellValue(ItemGrid.FocusedRowHandle, "Code").ToString();
                   string Id = ItemGrid.GetRowCellValue(ItemGrid.FocusedRowHandle, "Id").ToString();
                    Form ItemForm = new Form();
                    ItemForm.Controls.Add(new ItemsForm(code,Id));
                    ItemForm.BackColor = System.Drawing.Color.White;
                    ItemForm.StartPosition = FormStartPosition.CenterScreen;
                    ItemForm.WindowState = FormWindowState.Maximized;
                    ItemForm.DialogResult = DialogResult.Cancel;
                    DialogResult x = ItemForm.ShowDialog();

                    if (x == DialogResult.Cancel)
                    {
                        dbContext = new Purchase.AccountingSystem();
                        itemBindingSource.DataSource = dbContext.Items.ToList();
                        itemGridControl.RefreshDataSource();
                    }
                }
                else if (navigationPane1.SelectedPage.Caption.Equals("المجموعات"))
                {
                    string Id = ItemGroupGrid.GetRowCellValue(ItemGroupGrid.FocusedRowHandle, "Id").ToString();
                    Form GroupForm = new Form();
                    GroupForm.Controls.Add(new GroupForms(Id));
                    GroupForm.BackColor = System.Drawing.Color.White;
                    GroupForm.StartPosition = FormStartPosition.CenterScreen;
                    GroupForm.WindowState = FormWindowState.Maximized;
                    DialogResult x = GroupForm.ShowDialog();
                    if (x == DialogResult.Cancel)
                    {
                        dbContext = new Purchase.AccountingSystem();
                        itemGroupGridControl.DataSource = dbContext.ItemGroups.ToList();
                        itemGroupGridControl.RefreshDataSource();
                    }
                }
        }

      

        private void itemGroupGrid_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void StoresGrid_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد حفظ التعديلات؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            dbContext.SaveChanges();
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد حفظ التعديلات؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            
            dbContext.SaveChanges();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد حفظ التعديلات؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            
            dbContext.SaveChanges();
        }

        private void itemGridControl_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void itemGroupGridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void wharehousGridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

       

      

     

      
       

    }
}
