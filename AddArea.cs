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
    public partial class AddArea : DevExpress.XtraEditors.XtraUserControl
    {
        private Purchase.AccountingSystem dbContext;
        public AddArea()
        {
            InitializeComponent();
            dbContext = new Purchase.AccountingSystem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال اسم المنطقة");
            }
            else
            {
                using (var db = new AccountingSystem())
                {
                    var AreaSet = db.AreasSets.Create();
                    AreaSet.AreaName = name.Text;
                    db.AreasSets.Add(AreaSet);
                    db.SaveChanges();
                }
            }
        }

        private void AddArea_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
