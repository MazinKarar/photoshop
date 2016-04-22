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
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(1000);
                using (var db = new AccountingSystem())
                {
                    var Bank = db.BankSets.Create();
                    Bank.BankName = BankName.Text;
                    db.BankSets.Add(Bank);
                    db.SaveChanges();
                    BankName.Text = "";
                    splashScreenManager1.CloseWaitForm();
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