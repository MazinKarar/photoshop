namespace Purchase
{
    partial class UserView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1143, 507);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1034, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 37);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "استخراج";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "جميع مستخدي النظام";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1143, 447);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Purchase.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUCode,
            this.colUName,
            this.colUBranch,
            this.colUStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUStatus, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colUCode
            // 
            this.colUCode.Caption = "رقم المستخدم";
            this.colUCode.FieldName = "UCode";
            this.colUCode.Name = "colUCode";
            this.colUCode.Visible = true;
            this.colUCode.VisibleIndex = 0;
            this.colUCode.Width = 105;
            // 
            // colUName
            // 
            this.colUName.Caption = "اسم المستخدم";
            this.colUName.FieldName = "UName";
            this.colUName.Name = "colUName";
            this.colUName.Visible = true;
            this.colUName.VisibleIndex = 1;
            this.colUName.Width = 332;
            // 
            // colUBranch
            // 
            this.colUBranch.Caption = "الفرع";
            this.colUBranch.FieldName = "UBranch";
            this.colUBranch.Name = "colUBranch";
            this.colUBranch.Visible = true;
            this.colUBranch.VisibleIndex = 2;
            this.colUBranch.Width = 688;
            // 
            // colUStatus
            // 
            this.colUStatus.Caption = "الحالة";
            this.colUStatus.FieldName = "UStatus";
            this.colUStatus.Name = "colUStatus";
            this.colUStatus.Visible = true;
            this.colUStatus.VisibleIndex = 4;
            this.colUStatus.Width = 269;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(1143, 507);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colUCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUName;
        private DevExpress.XtraGrid.Columns.GridColumn colUBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colUStatus;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
