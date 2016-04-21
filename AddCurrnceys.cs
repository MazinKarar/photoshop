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
using System.Data.Entity;

namespace Purchase
{
    public partial class AddCurrnceys : DevExpress.XtraEditors.XtraUserControl
    {
        public AddCurrnceys()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال اسم العملة");
            }
            else
            {
                using (var db = new AccountingSystem())
                {
                    var AreaSet = db.CurrencySets.Create();
                    AreaSet.CurrencyName = name.Text;
                    db.CurrencySets.Add(AreaSet);
                    db.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
