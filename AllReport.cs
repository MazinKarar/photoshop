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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraReports.UI;

namespace Purchase
{
    public partial class AllReport : DevExpress.XtraEditors.XtraUserControl
    {
        public AllReport()
        {
            InitializeComponent();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
           // RptVendor report = new RptVendor();
           // ReportPrintTool printTool = new ReportPrintTool(report);
           // printTool.ShowPreviewDialog();
           
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {

        }
    }
}
