using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Purchase
{
    public partial class AccountantTree : UserControl
    {
        Purchase.AccountingSystem dbContext = new Purchase.AccountingSystem();
        public AccountantTree()
        {
            InitializeComponent();
            dbContext.TreeAccounts.Load();
            bindingSource1.DataSource = dbContext.TreeAccounts.Local.ToBindingList();
        }

        private void EditBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل تريد التعديل؟", "تأكيد", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;
            int id = int.Parse(treeList1.FocusedNode.GetValue("Id").ToString());
            Form storeForm = new Form();
            storeForm.Controls.Add(new AddTreeAccount(id));
            storeForm.BackColor = System.Drawing.Color.White;
            storeForm.StartPosition = FormStartPosition.CenterScreen;
            storeForm.WindowState = FormWindowState.Maximized;
            DialogResult x = storeForm.ShowDialog();
            if (x == DialogResult.Cancel)
            RefreshTreeList();
            
        }

        private void treeList1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshTreeList();
        }

        private void RefreshTreeList()
        {
            dbContext = new Purchase.AccountingSystem();
            bindingSource1.DataSource = dbContext.TreeAccounts.ToList();
            treeList1.RefreshDataSource();
        }

        private void DeleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الحساب؟", "تأكيد", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;
            treeList1.Nodes.Remove(treeList1.FocusedNode);
            dbContext.SaveChanges();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

     
    }
}
