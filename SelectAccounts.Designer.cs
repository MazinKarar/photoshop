namespace Purchase
{
    partial class SelectAccounts
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.coldebit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcredit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colnote = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TreeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.TypeLookup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.coldebit,
            this.colcredit,
            this.colnote,
            this.TreeName});
            this.treeList1.DataSource = this.bindingSource2;
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
            this.treeList1.Size = new System.Drawing.Size(1003, 409);
            this.treeList1.TabIndex = 2;
            this.treeList1.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            // 
            // coldebit
            // 
            this.coldebit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.coldebit.AppearanceCell.Options.UseFont = true;
            this.coldebit.Caption = "دائن";
            this.coldebit.FieldName = "debit";
            this.coldebit.Name = "coldebit";
            this.coldebit.Visible = true;
            this.coldebit.VisibleIndex = 1;
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
            this.colcredit.VisibleIndex = 2;
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
            this.colnote.VisibleIndex = 3;
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
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Purchase.TreeAccount);
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
            this.TypeLookup.DisplayMember = "Name";
            this.TypeLookup.Name = "TypeLookup";
            this.TypeLookup.NullText = "";
            this.TypeLookup.ValueMember = "Id";
            // 
            // SelectAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Name = "SelectAccounts";
            this.Size = new System.Drawing.Size(1003, 409);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeLookup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coldebit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcredit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnote;
        private DevExpress.XtraTreeList.Columns.TreeListColumn TreeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit TypeLookup;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}
