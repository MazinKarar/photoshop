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

namespace Purchase
{
    public partial class AddBanks : DevExpress.XtraEditors.XtraForm
    {
        public AddBanks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BankName.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال اسم البنك");
            }
            else
            {
                using (var db = new AccountingSystem())
                {
                    var Bank = db.BankSets.Create();
                    Bank.BankName = BankName.Text;
                    db.BankSets.Add(Bank);
                    db.SaveChanges();
                    Vendor v = new Vendor();
                    v.bankRefresh();
                    Suppliers s = new Suppliers();
                    s.bankRefresh();
                    AddBank b = new AddBank();
                    b.bankRefresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBanks_Load(object sender, EventArgs e)
        {

        }
    }
}