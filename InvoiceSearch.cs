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
    public partial class InvoiceSearch : DevExpress.XtraEditors.XtraUserControl
    {
        private Invoice invoice = null;
        public InvoiceSearch()
        {
            InitializeComponent();
            dataGridView1.DataSource = InvoiceUtils.getAllInvoice();
        }

        private void InvoiceSearch_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                if (e.ColumnIndex == 5)
                {
                    int invID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    invoice = InvoiceUtils.Find<Invoice>(invID);
                    dataGridView2.DataSource = InvoiceUtils.getInvoiceDetais(invoice.InvoiceId);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}