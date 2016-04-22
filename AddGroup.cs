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
using System.Threading;

namespace Purchase
{
    public partial class AddGroup : DevExpress.XtraEditors.XtraForm
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void news_Click(object sender, EventArgs e)
        {
            update.Visible = false;
            save.Visible = true;
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.Groups
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                         };
                var list = dc.ToList();
                int id = list.Count;
                GroupId.Text = (id + 1).ToString();
            }
            search.Text = "";
            Admin.Checked = false;
            Sells.Checked = false;
            Buys.Checked = false;
            Warehouse.Checked = false;
            Account.Checked = false;
            VendorSupplier.Checked = false;
            Other.Checked = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            news.Visible = true;
            save.Visible = false;
            update.Visible = true;
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(1000);
            using (var db = new AccountingSystem())
            {
                var group = db.Groups.Create();
                group.Name = search.Text;
                var Control = db.PermissionControls.Create();
                Control.CGroupId = GroupId.Text;
                Control.CAdmin = Admin.Checked;
                Control.CSells = Sells.Checked;
                Control.CBuys = Buys.Checked;
                Control.CWarehouse = Warehouse.Checked;
                Control.CAccount = Account.Checked;
                Control.CVendorSupplier = VendorSupplier.Checked;
                Control.COther = Other.Checked;
                db.PermissionControls.Add(Control);
                db.Groups.Add(group);
                

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
                MessageBox.Show("تم الحفظ بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillsearch();
            splashScreenManager1.CloseWaitForm();
        }

        private void update_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(1000);
            using (var db = new AccountingSystem())
            {
                try
                {

                    var Control = db.PermissionControls.First(x => x.CGroupId.Equals(GroupId.Text.ToString()));
                    Control.CAdmin = Admin.Checked;
                    Control.CSells = Sells.Checked;
                    Control.CBuys = Buys.Checked;
                    Control.CWarehouse = Warehouse.Checked;
                    Control.CAccount = Account.Checked;
                    Control.CVendorSupplier = VendorSupplier.Checked;
                    Control.COther = Other.Checked;
                    db.Entry(Control).State = System.Data.Entity.EntityState.Modified;
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

        private void AddGroup_Load(object sender, EventArgs e)
        {
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.Groups
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                         };
                var list = dc.ToList();
                int id = list.Count;
                GroupId.Text = (id + 1).ToString();
            }
            fillsearch();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            news.Visible = true;
            update.Visible = true;
            using (var db = new AccountingSystem())
            {
                var na = from b in db.Groups where b.Name.Equals(search.Text) select new { b.Id };
                var lis = na.ToList();
                string Gid = lis[0].Id.ToString();
                if (lis.Count != 0)
                {
                    var dc = from c in db.PermissionControls
                             where c.CGroupId.Equals(Gid)
                             select new
                             {
                                 c.CGroupId,
                                 c.CAdmin,
                                 c.CSells,
                                 c.CBuys,
                                 c.CWarehouse,
                                 c.CVendorSupplier,
                                 c.CAccount,
                                 c.COther,
                             };
                    var list = dc.ToList();
                    if (list.Count != 0)
                    {
                        
                            Other.Checked = list[0].COther;
                      
                            Account.Checked = list[0].CAccount;
                       
                            Admin.Checked = list[0].CAdmin;
                      
                            Sells.Checked = list[0].CSells;
                       
                            Buys.Checked = list[0].CBuys;
                       
                            Warehouse.Checked = list[0].CWarehouse;
                       
                            VendorSupplier.Checked = list[0].CVendorSupplier;
                        
                        GroupId.Text = list[0].CGroupId;
                    }
                    else
                    {
                        MessageBox.Show("عفوا لا يوجد عميل بهذا الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private List<string> Datos()
        {

            List<string> listDatos = new List<string>();

            using (var db = new AccountingSystem())
            {
                var dc = from c in db.Groups
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                             c.Name
                         };
                var list = dc.ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    listDatos.Add(list[i].Name.ToString());
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}