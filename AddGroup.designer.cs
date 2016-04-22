namespace Purchase
{
    partial class AddGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroup));
            this.panel3 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupId = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.Other = new DevExpress.XtraEditors.CheckEdit();
            this.VendorSupplier = new DevExpress.XtraEditors.CheckEdit();
            this.Account = new DevExpress.XtraEditors.CheckEdit();
            this.Admin = new DevExpress.XtraEditors.CheckEdit();
            this.Warehouse = new DevExpress.XtraEditors.CheckEdit();
            this.Buys = new DevExpress.XtraEditors.CheckEdit();
            this.Sells = new DevExpress.XtraEditors.CheckEdit();
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.news = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Purchase.WaitForm1), true, true);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Other.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sells.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.GroupId);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Other);
            this.panel3.Controls.Add(this.VendorSupplier);
            this.panel3.Controls.Add(this.Account);
            this.panel3.Controls.Add(this.Admin);
            this.panel3.Controls.Add(this.Warehouse);
            this.panel3.Controls.Add(this.Buys);
            this.panel3.Controls.Add(this.Sells);
            this.panel3.Location = new System.Drawing.Point(12, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 236);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(147, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(194, 20);
            this.search.TabIndex = 60;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(102, 30);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(39, 35);
            this.simpleButton1.TabIndex = 59;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(347, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "رقم المجموعة";
            // 
            // GroupId
            // 
            this.GroupId.EditValue = "";
            this.GroupId.Enabled = false;
            this.GroupId.Location = new System.Drawing.Point(275, 12);
            this.GroupId.Name = "GroupId";
            this.GroupId.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.GroupId.Properties.Appearance.Options.UseForeColor = true;
            this.GroupId.Properties.NullText = "[EditValue is null]";
            this.GroupId.Size = new System.Drawing.Size(66, 20);
            this.GroupId.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(347, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 55;
            this.label9.Text = "اسم المجموعة";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Other
            // 
            this.Other.Location = new System.Drawing.Point(165, 129);
            this.Other.Name = "Other";
            this.Other.Properties.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Other.Properties.Appearance.Options.UseFont = true;
            this.Other.Properties.Appearance.Options.UseForeColor = true;
            this.Other.Properties.Caption = "مهام اخرى";
            this.Other.Size = new System.Drawing.Size(127, 27);
            this.Other.TabIndex = 6;
            // 
            // VendorSupplier
            // 
            this.VendorSupplier.Location = new System.Drawing.Point(165, 96);
            this.VendorSupplier.Name = "VendorSupplier";
            this.VendorSupplier.Properties.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorSupplier.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.VendorSupplier.Properties.Appearance.Options.UseFont = true;
            this.VendorSupplier.Properties.Appearance.Options.UseForeColor = true;
            this.VendorSupplier.Properties.Caption = "العملاء والموردين";
            this.VendorSupplier.Size = new System.Drawing.Size(127, 27);
            this.VendorSupplier.TabIndex = 5;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(280, 191);
            this.Account.Name = "Account";
            this.Account.Properties.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Account.Properties.Appearance.Options.UseFont = true;
            this.Account.Properties.Appearance.Options.UseForeColor = true;
            this.Account.Properties.Caption = "الحسابات";
            this.Account.Size = new System.Drawing.Size(127, 27);
            this.Account.TabIndex = 4;
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(280, 63);
            this.Admin.Name = "Admin";
            this.Admin.Properties.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Admin.Properties.Appearance.Options.UseFont = true;
            this.Admin.Properties.Appearance.Options.UseForeColor = true;
            this.Admin.Properties.Caption = "التحكم في ادارة النظام";
            this.Admin.Size = new System.Drawing.Size(127, 27);
            this.Admin.TabIndex = 3;
            // 
            // Warehouse
            // 
            this.Warehouse.Location = new System.Drawing.Point(298, 162);
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Properties.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warehouse.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Warehouse.Properties.Appearance.Options.UseFont = true;
            this.Warehouse.Properties.Appearance.Options.UseForeColor = true;
            this.Warehouse.Properties.Caption = "المخازن";
            this.Warehouse.Size = new System.Drawing.Size(109, 27);
            this.Warehouse.TabIndex = 2;
            // 
            // Buys
            // 
            this.Buys.Location = new System.Drawing.Point(298, 129);
            this.Buys.Name = "Buys";
            this.Buys.Properties.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buys.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Buys.Properties.Appearance.Options.UseFont = true;
            this.Buys.Properties.Appearance.Options.UseForeColor = true;
            this.Buys.Properties.Caption = "المشريات";
            this.Buys.Size = new System.Drawing.Size(109, 27);
            this.Buys.TabIndex = 1;
            // 
            // Sells
            // 
            this.Sells.Location = new System.Drawing.Point(298, 96);
            this.Sells.Name = "Sells";
            this.Sells.Properties.Appearance.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sells.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Sells.Properties.Appearance.Options.UseFont = true;
            this.Sells.Properties.Appearance.Options.UseForeColor = true;
            this.Sells.Properties.Caption = "المبيعات";
            this.Sells.Size = new System.Drawing.Size(109, 27);
            this.Sells.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(272, 353);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 32);
            this.cancel.TabIndex = 55;
            this.cancel.Text = "الغاء";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(362, 353);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 32);
            this.update.TabIndex = 54;
            this.update.Text = "تحديث";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // news
            // 
            this.news.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.news.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.news.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.news.ForeColor = System.Drawing.Color.White;
            this.news.Location = new System.Drawing.Point(272, 307);
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(75, 32);
            this.news.TabIndex = 53;
            this.news.Text = "جديد";
            this.news.UseVisualStyleBackColor = false;
            this.news.Click += new System.EventHandler(this.news_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.Highlight;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(362, 307);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 32);
            this.save.TabIndex = 52;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(162, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 46);
            this.label2.TabIndex = 58;
            this.label2.Text = "إضافة مجموعة";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // AddGroup
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.update);
            this.Controls.Add(this.news);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مجموعة";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Other.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sells.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.CheckEdit Other;
        private DevExpress.XtraEditors.CheckEdit VendorSupplier;
        private DevExpress.XtraEditors.CheckEdit Account;
        private DevExpress.XtraEditors.CheckEdit Admin;
        private DevExpress.XtraEditors.CheckEdit Warehouse;
        private DevExpress.XtraEditors.CheckEdit Buys;
        private DevExpress.XtraEditors.CheckEdit Sells;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button news;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit GroupId;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox search;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}