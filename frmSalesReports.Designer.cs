namespace Purchase
{
    partial class frmSalesReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReports));
            this.RdoInvoice = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.rdoItem = new System.Windows.Forms.RadioButton();
            this.rdoCustomer = new System.Windows.Forms.RadioButton();
            this.FromDate = new DevExpress.XtraEditors.DateEdit();
            this.DateTo = new DevExpress.XtraEditors.DateEdit();
            this.lblto = new System.Windows.Forms.Label();
            this.cmbCustomerID = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbItem = new DevExpress.XtraEditors.LookUpEdit();
            this.txtInvoiceNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdReport = new DevExpress.XtraEditors.SimpleButton();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // RdoInvoice
            // 
            this.RdoInvoice.AutoSize = true;
            this.RdoInvoice.Location = new System.Drawing.Point(61, 21);
            this.RdoInvoice.Name = "RdoInvoice";
            this.RdoInvoice.Size = new System.Drawing.Size(78, 17);
            this.RdoInvoice.TabIndex = 7;
            this.RdoInvoice.TabStop = true;
            this.RdoInvoice.Text = "عرض فاتورة";
            this.RdoInvoice.UseVisualStyleBackColor = true;
            this.RdoInvoice.CheckedChanged += new System.EventHandler(this.RdoInvoice_CheckedChanged);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Location = new System.Drawing.Point(61, 55);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(148, 17);
            this.rdoList.TabIndex = 8;
            this.rdoList.TabStop = true;
            this.rdoList.Text = "قوائم التقارير في الفترة من";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoItem
            // 
            this.rdoItem.AutoSize = true;
            this.rdoItem.Location = new System.Drawing.Point(61, 87);
            this.rdoItem.Name = "rdoItem";
            this.rdoItem.Size = new System.Drawing.Size(106, 17);
            this.rdoItem.TabIndex = 9;
            this.rdoItem.TabStop = true;
            this.rdoItem.Text = "المبيعات بالاصناف";
            this.rdoItem.UseVisualStyleBackColor = true;
            this.rdoItem.CheckedChanged += new System.EventHandler(this.rdoItem_CheckedChanged);
            // 
            // rdoCustomer
            // 
            this.rdoCustomer.AutoSize = true;
            this.rdoCustomer.Location = new System.Drawing.Point(61, 123);
            this.rdoCustomer.Name = "rdoCustomer";
            this.rdoCustomer.Size = new System.Drawing.Size(122, 17);
            this.rdoCustomer.TabIndex = 10;
            this.rdoCustomer.TabStop = true;
            this.rdoCustomer.Text = "المبيعات لعميل معين";
            this.rdoCustomer.UseVisualStyleBackColor = true;
            this.rdoCustomer.CheckedChanged += new System.EventHandler(this.rdoCustomer_CheckedChanged);
            // 
            // FromDate
            // 
            this.FromDate.EditValue = new System.DateTime(2016, 4, 4, 16, 3, 5, 398);
            this.FromDate.Enabled = false;
            this.FromDate.Location = new System.Drawing.Point(213, 54);
            this.FromDate.Name = "FromDate";
            this.FromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.FromDate.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.FromDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.FromDate.Size = new System.Drawing.Size(96, 20);
            this.FromDate.TabIndex = 28;
            // 
            // DateTo
            // 
            this.DateTo.EditValue = new System.DateTime(2016, 4, 4, 16, 3, 5, 398);
            this.DateTo.Enabled = false;
            this.DateTo.Location = new System.Drawing.Point(360, 53);
            this.DateTo.Name = "DateTo";
            this.DateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTo.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.DateTo.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.DateTo.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.DateTo.Size = new System.Drawing.Size(88, 20);
            this.DateTo.TabIndex = 29;
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Location = new System.Drawing.Point(322, 57);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(24, 13);
            this.lblto.TabIndex = 30;
            this.lblto.Text = "الى";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.Enabled = false;
            this.cmbCustomerID.Location = new System.Drawing.Point(213, 122);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("رقم العميل", "CustomerId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "اسم العميل")});
            this.cmbCustomerID.Properties.DataSource = this.bindingSource1;
            this.cmbCustomerID.Properties.DisplayMember = "VendorName";
            this.cmbCustomerID.Properties.NullText = "";
            this.cmbCustomerID.Properties.ShowHeader = false;
            this.cmbCustomerID.Properties.ValueMember = "Id";
            this.cmbCustomerID.Size = new System.Drawing.Size(235, 20);
            this.cmbCustomerID.TabIndex = 31;
            // 
            // cmbItem
            // 
            this.cmbItem.Enabled = false;
            this.cmbItem.Location = new System.Drawing.Point(213, 86);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbItem.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("رقم العميل", "CustomerId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "اسم العميل")});
            this.cmbItem.Properties.DataSource = this.bindingSource2;
            this.cmbItem.Properties.DisplayMember = "Name";
            this.cmbItem.Properties.NullText = "";
            this.cmbItem.Properties.ShowHeader = false;
            this.cmbItem.Properties.ValueMember = "Code";
            this.cmbItem.Size = new System.Drawing.Size(235, 20);
            this.cmbItem.TabIndex = 32;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Location = new System.Drawing.Point(307, 20);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(141, 20);
            this.txtInvoiceNo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "رقم الفاتورة";
            // 
            // cmdReport
            // 
            this.cmdReport.Image = ((System.Drawing.Image)(resources.GetObject("cmdReport.Image")));
            this.cmdReport.Location = new System.Drawing.Point(153, 170);
            this.cmdReport.Name = "cmdReport";
            this.cmdReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdReport.Size = new System.Drawing.Size(96, 37);
            this.cmdReport.TabIndex = 6;
            this.cmdReport.Text = "عرض";
            // 
            // cmdClose
            // 
            this.cmdClose.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.Image")));
            this.cmdClose.Location = new System.Drawing.Point(290, 170);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClose.Size = new System.Drawing.Size(96, 37);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "إغلاق";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Purchase.Item);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Purchase.VendorSet);
            // 
            // frmSalesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.rdoCustomer);
            this.Controls.Add(this.rdoItem);
            this.Controls.Add(this.rdoList);
            this.Controls.Add(this.RdoInvoice);
            this.Controls.Add(this.cmdReport);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalesReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalesReports";
            this.Load += new System.EventHandler(this.frmSalesReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdReport;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private System.Windows.Forms.RadioButton RdoInvoice;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.RadioButton rdoItem;
        private System.Windows.Forms.RadioButton rdoCustomer;
        private DevExpress.XtraEditors.DateEdit FromDate;
        private DevExpress.XtraEditors.DateEdit DateTo;
        private System.Windows.Forms.Label lblto;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomerID;
        private DevExpress.XtraEditors.LookUpEdit cmbItem;
        private DevExpress.XtraEditors.TextEdit txtInvoiceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}