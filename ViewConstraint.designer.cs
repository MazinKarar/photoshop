namespace Purchase
{
    partial class ViewConstraint
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
            this.components = new System.ComponentModel.Container();
            this.debentureGridControl = new DevExpress.XtraGrid.GridControl();
            this.debentureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DebGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDebentureNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebentureDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.remarks = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.debentureGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debentureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // debentureGridControl
            // 
            this.debentureGridControl.DataSource = this.debentureBindingSource;
            this.debentureGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debentureGridControl.Location = new System.Drawing.Point(0, 0);
            this.debentureGridControl.MainView = this.DebGrid;
            this.debentureGridControl.Name = "debentureGridControl";
            this.debentureGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.debentureGridControl.ShowOnlyPredefinedDetails = true;
            this.debentureGridControl.Size = new System.Drawing.Size(882, 400);
            this.debentureGridControl.TabIndex = 1;
            this.debentureGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DebGrid});
            this.debentureGridControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.debentureGridControl_MouseUp);
            // 
            // debentureBindingSource
            // 
            this.debentureBindingSource.DataSource = typeof(Purchase.debenture);
            // 
            // DebGrid
            // 
            this.DebGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDebentureNo,
            this.colDebentureDate,
            this.colNotes,
            this.remarks});
            this.DebGrid.GridControl = this.debentureGridControl;
            this.DebGrid.Name = "DebGrid";
            this.DebGrid.OptionsView.ShowFooter = true;
            // 
            // colDebentureNo
            // 
            this.colDebentureNo.Caption = "رقم القيد";
            this.colDebentureNo.FieldName = "DebentureID";
            this.colDebentureNo.Name = "colDebentureNo";
            this.colDebentureNo.Visible = true;
            this.colDebentureNo.VisibleIndex = 0;
            // 
            // colDebentureDate
            // 
            this.colDebentureDate.Caption = "تاريخ القيد";
            this.colDebentureDate.FieldName = "DebentureDate";
            this.colDebentureDate.Name = "colDebentureDate";
            this.colDebentureDate.Visible = true;
            this.colDebentureDate.VisibleIndex = 1;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "البيان";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 2;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "تعديل";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageUri.Uri = "Edit";
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "حذف";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageUri.Uri = "Delete";
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "تحديث";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageUri.Uri = "Refresh";
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(882, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 400);
            this.barDockControlBottom.Size = new System.Drawing.Size(882, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 400);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(882, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 400);
            // 
            // remarks
            // 
            this.remarks.Caption = "الملاحظات";
            this.remarks.FieldName = "remarks";
            this.remarks.Name = "remarks";
            this.remarks.Visible = true;
            this.remarks.VisibleIndex = 3;
            // 
            // ViewConstraint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.debentureGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ViewConstraint";
            this.Size = new System.Drawing.Size(882, 400);
            ((System.ComponentModel.ISupportInitialize)(this.debentureGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debentureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl debentureGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DebGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colDebentureNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDebentureDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource debentureBindingSource;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Columns.GridColumn remarks;

    }
}
