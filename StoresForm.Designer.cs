namespace Purchase
{
    partial class StoresForm
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.GroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StoreBranch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StoreSize = new DevExpress.XtraEditors.CalcEdit();
            this.StoreStatus = new System.Windows.Forms.CheckBox();
            this.StoreAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StoreMobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSize.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(852, 418);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(141, 40);
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "حفظ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(993, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 24);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "إضافة مخزن";
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.LineColor = System.Drawing.Color.CornflowerBlue;
            this.separatorControl1.Location = new System.Drawing.Point(345, 35);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(779, 23);
            this.separatorControl1.TabIndex = 29;
            // 
            // GroupName
            // 
            this.GroupName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GroupName.Location = new System.Drawing.Point(710, 126);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(197, 24);
            this.GroupName.TabIndex = 27;
            this.GroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(928, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "اسم المخزن";
            // 
            // GroupId
            // 
            this.GroupId.Enabled = false;
            this.GroupId.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GroupId.Location = new System.Drawing.Point(710, 75);
            this.GroupId.Name = "GroupId";
            this.GroupId.Size = new System.Drawing.Size(197, 24);
            this.GroupId.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(935, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "رقم المخزن";
            // 
            // StoreBranch
            // 
            this.StoreBranch.Location = new System.Drawing.Point(710, 168);
            this.StoreBranch.Name = "StoreBranch";
            this.StoreBranch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StoreBranch.Properties.Appearance.Options.UseFont = true;
            this.StoreBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StoreBranch.Size = new System.Drawing.Size(197, 22);
            this.StoreBranch.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(942, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "اسم الفرع";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(2, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "بيانات اساسية ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 23);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "بيانات اضافية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(935, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "حالة المخزن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(915, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "مساحة المخزن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(967, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "العنوان";
            // 
            // StoreSize
            // 
            this.StoreSize.Location = new System.Drawing.Point(712, 287);
            this.StoreSize.Name = "StoreSize";
            this.StoreSize.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StoreSize.Properties.Appearance.Options.UseFont = true;
            this.StoreSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StoreSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.StoreSize.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.StoreSize.Size = new System.Drawing.Size(197, 22);
            this.StoreSize.TabIndex = 44;
            // 
            // StoreStatus
            // 
            this.StoreStatus.AutoSize = true;
            this.StoreStatus.Checked = true;
            this.StoreStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StoreStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StoreStatus.Location = new System.Drawing.Point(830, 248);
            this.StoreStatus.Name = "StoreStatus";
            this.StoreStatus.Size = new System.Drawing.Size(56, 21);
            this.StoreStatus.TabIndex = 45;
            this.StoreStatus.Text = "نشط";
            this.StoreStatus.UseVisualStyleBackColor = true;
            // 
            // StoreAddress
            // 
            this.StoreAddress.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StoreAddress.Location = new System.Drawing.Point(712, 331);
            this.StoreAddress.Name = "StoreAddress";
            this.StoreAddress.Size = new System.Drawing.Size(197, 24);
            this.StoreAddress.TabIndex = 46;
            this.StoreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Location = new System.Drawing.Point(1043, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 113);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Location = new System.Drawing.Point(1043, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 150);
            this.panel2.TabIndex = 52;
            // 
            // StoreMobile
            // 
            this.StoreMobile.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StoreMobile.Location = new System.Drawing.Point(712, 374);
            this.StoreMobile.MaxLength = 14;
            this.StoreMobile.Name = "StoreMobile";
            this.StoreMobile.Size = new System.Drawing.Size(197, 24);
            this.StoreMobile.TabIndex = 54;
            this.StoreMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(967, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "تلفون";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.CancelBtn.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CancelBtn.Appearance.Options.UseBackColor = true;
            this.CancelBtn.Appearance.Options.UseFont = true;
            this.CancelBtn.Appearance.Options.UseForeColor = true;
            this.CancelBtn.Location = new System.Drawing.Point(691, 418);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.CancelBtn.Size = new System.Drawing.Size(141, 40);
            this.CancelBtn.TabIndex = 55;
            this.CancelBtn.Text = "إغلاق";
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // StoresForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.StoreMobile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StoreAddress);
            this.Controls.Add(this.StoreStatus);
            this.Controls.Add(this.StoreSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StoreBranch);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupId);
            this.Controls.Add(this.label1);
            this.Name = "StoresForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1152, 483);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSize.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.TextBox GroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GroupId;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit StoreBranch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox StoreStatus;
        private DevExpress.XtraEditors.CalcEdit StoreSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StoreAddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox StoreMobile;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton CancelBtn;
    }
}
