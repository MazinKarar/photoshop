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
    public partial class AddBranch : DevExpress.XtraEditors.XtraForm
    {
        public AddBranch()
        {
            InitializeComponent();
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {
            update.Visible = false;
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.Branches
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                         };
                var list = dc.ToList();
                int id = list.Count;
                Id.Text = (id + 1).ToString();
            }
            fillsearch();
        }
        private List<string> Datos()
        {

            List<string> listDatos = new List<string>();

            using (var db = new AccountingSystem())
            {
                var dc = from c in db.Branches
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                             c.BName
                         };
                var list = dc.ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    listDatos.Add(list[i].BName.ToString());
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
            news.Visible = true;
            save.Visible = false;
            update.Visible = true;
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(1000);
            using (var db = new AccountingSystem())
            {

                var Branch = db.Branches.Create();
                Branch.BName = search.Text;
                Branch.BId = Id.Text;
                Branch.BStatus = Status.Checked.ToString();
                Branch.BPhone1 = Phone1.Text;
                Branch.BPhone2 = Phone2.Text;
                Branch.BAddress = Address.Text;
                db.Branches.Add(Branch);


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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            news.Visible = true;
            update.Visible = true;
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.Branches
                         where c.BName.Equals(search.Text)
                         select new
                         {
                             c.BId,
                             c.BName,
                             c.BStatus,
                             c.BPhone1,
                             c.BPhone2,
                             c.BAddress,
                         };
                var list = dc.ToList();
                if (list.Count != 0)
                {
                    if (list[0].BStatus.Equals("True"))
                        Status.Checked = true;
                    else
                        Status.Checked = false;
                    Id.Text = list[0].BId;
                    search.Text = list[0].BName;
                    Phone1.Text = list[0].BPhone1;
                    Phone2.Text = list[0].BPhone2;
                    Address.Text = list[0].BAddress;
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد فرع بهذا الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void news_Click(object sender, EventArgs e)
        {
            update.Visible = false;
            save.Visible = true;
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.Branches
                         //where c.Id.Equals(InvoiceID)
                         select new
                         {
                             c.Id,
                         };
                var list = dc.ToList();
                int id = list.Count;
                Id.Text = (id + 1).ToString();
            }
            search.Text = "";
            Status.Checked = false;
            Address.Text = "";
            Phone2.Text = "";
            Phone1.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(1000);
            using (var db = new AccountingSystem())
            {
                try
                {

                    var Branch = db.Branches.First(x => x.BId.Equals(Id.Text.ToString()));
                    Branch.BName = search.Text;
                    Branch.BId = Id.Text;
                    Branch.BStatus = Status.Checked.ToString();
                    Branch.BPhone1 = Phone1.Text;
                    Branch.BPhone2 = Phone2.Text;
                    Branch.BAddress = Address.Text;
                    db.Branches.Add(Branch);
                    db.Entry(Branch).State = System.Data.Entity.EntityState.Modified;
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}