namespace Purchase
{
    partial class AccountantTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantTree));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coldebit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcredit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colnote = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TreeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.TypeLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.EditBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.coldebit,
            this.colcredit,
            this.colnote,
            this.TreeName});
            this.treeList1.DataSource = this.bindingSource1;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AllowIncrementalSearch = true;
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Standard;
            this.treeList1.OptionsFind.AllowFindPanel = true;
            this.treeList1.OptionsFind.AlwaysVisible = true;
            this.treeList1.OptionsLayout.AddNewColumns = false;
            this.treeList1.OptionsView.ShowAutoFilterRow = true;
            this.treeList1.ParentFieldName = "parentId";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.TypeLookup});
            this.treeList1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeList1.RootValue = 1;
            this.treeList1.RowHeight = 25;
            this.treeList1.Size = new System.Drawing.Size(895, 371);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseUp);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.Caption = "رقم الحساب";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // coldebit
            // 
            this.coldebit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.coldebit.AppearanceCell.Options.UseFont = true;
            this.coldebit.Caption = "دائن";
            this.coldebit.FieldName = "debit";
            this.coldebit.Name = "coldebit";
            this.coldebit.Visible = true;
            this.coldebit.VisibleIndex = 2;
            this.coldebit.Width = 44;
            // 
            // colcredit
            // 
            this.colcredit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colcredit.AppearanceCell.Options.UseFont = true;
            this.colcredit.Caption = "مدين";
            this.colcredit.FieldName = "credit";
            this.colcredit.Name = "colcredit";
            this.colcredit.Visible = true;
            this.colcredit.VisibleIndex = 3;
            this.colcredit.Width = 44;
            // 
            // colnote
            // 
            this.colnote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colnote.AppearanceCell.Options.UseFont = true;
            this.colnote.Caption = "ملاحظة";
            this.colnote.FieldName = "note";
            this.colnote.Name = "colnote";
            this.colnote.Visible = true;
            this.colnote.VisibleIndex = 4;
            this.colnote.Width = 44;
            // 
            // TreeName
            // 
            this.TreeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TreeName.AppearanceCell.Options.UseFont = true;
            this.TreeName.Caption = "الأسم";
            this.TreeName.FieldName = "Name";
            this.TreeName.Name = "TreeName";
            this.TreeName.OptionsColumn.AllowEdit = false;
            this.TreeName.OptionsColumn.AllowMove = false;
            this.TreeName.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.TreeName.Visible = true;
            this.TreeName.VisibleIndex = 0;
            this.TreeName.Width = 44;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Purchase.TreeAccount);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // TypeLookup
            // 
            this.TypeLookup.AutoHeight = false;
            this.TypeLookup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeLookup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "النوع")});
            this.TypeLookup.DataSource = this.bindingSource1;
            this.TypeLookup.DisplayMember = "Name";
            this.TypeLookup.Name = "TypeLookup";
            this.TypeLookup.NullText = "";
            this.TypeLookup.ValueMember = "Id";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.EditBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.DeleteBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // EditBtn
            // 
            this.EditBtn.Caption = "تعديل";
            this.EditBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("EditBtn.Glyph")));
            this.EditBtn.Id = 0;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditBtn_ItemClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Caption = "حذف";
            this.DeleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Glyph")));
            this.DeleteBtn.Id = 1;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBtn_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "تحديث";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.EditBtn,
            this.DeleteBtn,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(895, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Size = new System.Drawing.Size(895, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 391);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(895, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 391);
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 371);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = null;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(895, 20);
            // 
            // AccountantTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AccountantTree";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(895, 391);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coldebit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcredit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnote;
        private DevExpress.XtraTreeList.Columns.TreeListColumn TreeName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem EditBtn;
        private DevExpress.XtraBars.BarButtonItem DeleteBtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit TypeLookup;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
