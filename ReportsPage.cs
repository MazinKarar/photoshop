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

namespace Purchase
{
    public partial class ReportsPage : DevExpress.XtraEditors.XtraUserControl
    {
        public ReportsPage()
        {
            InitializeComponent();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                //Form f = new Report();
                //f.ShowDialog();
            }
            catch (Exception) { }
        }
    }
}
