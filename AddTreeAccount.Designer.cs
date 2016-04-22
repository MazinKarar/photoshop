namespace Purchase
{
    partial class AddTreeAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountLevel = new DevExpress.XtraEditors.LookUpEdit();
            this.AccountTreeSource = new System.Windows.Forms.BindingSource();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.AccountSubLevel = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSource2 = new System.Windows.Forms.BindingSource();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.AccountName = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.AsChachCheck = new DevExpress.XtraEditors.CheckEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.AccountStauts = new DevExpress.XtraEditors.CheckEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AccountDate = new DevExpress.XtraEditors.DateEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.AccountNotes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.accountIsParent = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTreeSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountSubLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsChachCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStauts.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIsParent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1079, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 81);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(137, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 98);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "نوع الحساب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(978, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "يتدرج من حساب";
            // 
            // AccountLevel
            // 
            this.AccountLevel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AccountTreeSource, "type", true));
            this.AccountLevel.Location = new System.Drawing.Point(805, 57);
            this.AccountLevel.Name = "AccountLevel";
            this.AccountLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AccountLevel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "الأسم")});
            this.AccountLevel.Properties.DataSource = this.bindingSource1;
            this.AccountLevel.Properties.DisplayMember = "Name";
            this.AccountLevel.Properties.NullText = "-اختر-";
            this.AccountLevel.Properties.ValueMember = "Id";
            this.AccountLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountLevel.Size = new System.Drawing.Size(158, 20);
            this.AccountLevel.TabIndex = 2;
            this.AccountLevel.EditValueChanged += new System.EventHandler(this.AccountLevel_EditValueChanged);
            // 
            // AccountTreeSource
            // 
            this.AccountTreeSource.DataSource = typeof(Purchase.TreeAccount);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Purchase.TreeAccount);
            // 
            // AccountSubLevel
            // 
            this.AccountSubLevel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AccountTreeSource, "parentId", true));
            this.AccountSubLevel.Location = new System.Drawing.Point(805, 124);
            this.AccountSubLevel.Name = "AccountSubLevel";
            this.AccountSubLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AccountSubLevel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "الأسم")});
            this.AccountSubLevel.Properties.DataSource = this.bindingSource2;
            this.AccountSubLevel.Properties.DisplayMember = "Name";
            this.AccountSubLevel.Properties.NullText = "-اختر-";
            this.AccountSubLevel.Properties.ValueMember = "Id";
            this.AccountSubLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountSubLevel.Size = new System.Drawing.Size(158, 20);
            this.AccountSubLevel.TabIndex = 5;
            this.AccountSubLevel.EditValueChanged += new System.EventHandler(this.AccountSubLevel_EditValueChanged);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Purchase.TreeAccount);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1079, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 155);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(137, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 98);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "نوع الحساب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "البيانات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(997, 167);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "رقم الحساب";
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AccountTreeSource, "Id", true));
            this.AccountNumber.Enabled = false;
            this.AccountNumber.Location = new System.Drawing.Point(805, 164);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountNumber.Size = new System.Drawing.Size(158, 20);
            this.AccountNumber.TabIndex = 7;
            // 
            // AccountName
            // 
            this.AccountName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AccountTreeSource, "Name", true));
            this.AccountName.Location = new System.Drawing.Point(686, 201);
            this.AccountName.Name = "AccountName";
            this.AccountName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountName.Size = new System.Drawing.Size(277, 20);
            this.AccountName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(992, 204);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "اسم الحساب";
            // 
            // AsChachCheck
            // 
            this.AsChachCheck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AccountTreeSource, "ismoney", true));
            this.AsChachCheck.Location = new System.Drawing.Point(802, 244);
            this.AsChachCheck.Name = "AsChachCheck";
            this.AsChachCheck.Properties.Caption = "يتعامل على انه حساب نقدي ";
            this.AsChachCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AsChachCheck.Size = new System.Drawing.Size(161, 19);
            this.AsChachCheck.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1031, 286);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "الحالة";
            // 
            // AccountStauts
            // 
            this.AccountStauts.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AccountTreeSource, "active", true));
            this.AccountStauts.Location = new System.Drawing.Point(914, 283);
            this.AccountStauts.Name = "AccountStauts";
            this.AccountStauts.Properties.Caption = "نشط";
            this.AccountStauts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountStauts.Size = new System.Drawing.Size(49, 19);
            this.AccountStauts.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(1079, 269);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 139);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(137, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(75, 98);
            this.panel6.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "نوع الحساب";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "الحالة";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(968, 316);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "تاريخ فتح الحساب";
            // 
            // AccountDate
            // 
            this.AccountDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AccountTreeSource, "dt", true));
            this.AccountDate.EditValue = null;
            this.AccountDate.Location = new System.Drawing.Point(805, 313);
            this.AccountDate.Name = "AccountDate";
            this.AccountDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AccountDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AccountDate.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.AccountDate.Size = new System.Drawing.Size(157, 20);
            this.AccountDate.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(993, 350);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "ملاحظات";
            // 
            // AccountNotes
            // 
            this.AccountNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AccountTreeSource, "note", true));
            this.AccountNotes.Location = new System.Drawing.Point(655, 350);
            this.AccountNotes.Multiline = true;
            this.AccountNotes.Name = "AccountNotes";
            this.AccountNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AccountNotes.Size = new System.Drawing.Size(308, 58);
            this.AccountNotes.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(978, 60);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "طبيعة الحساب";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.SaveBtn.Appearance.Options.UseFont = true;
            this.SaveBtn.Location = new System.Drawing.Point(972, 429);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 43);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.CancelBtn.Appearance.Options.UseFont = true;
            this.CancelBtn.Location = new System.Drawing.Point(805, 429);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(129, 43);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "إغلاق";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // accountIsParent
            // 
            this.accountIsParent.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.AccountTreeSource, "isparent", true));
            this.accountIsParent.Location = new System.Drawing.Point(696, 244);
            this.accountIsParent.Name = "accountIsParent";
            this.accountIsParent.Properties.Caption = "لديه فروع";
            this.accountIsParent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accountIsParent.Size = new System.Drawing.Size(76, 19);
            this.accountIsParent.TabIndex = 20;
            // 
            // AddTreeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.accountIsParent);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AccountNotes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AccountDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.AccountStauts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AsChachCheck);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AccountNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AccountSubLevel);
            this.Controls.Add(this.AccountLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTreeAccount";
            this.Size = new System.Drawing.Size(1197, 492);
            this.Load += new System.EventHandler(this.AddTreeAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTreeSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountSubLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsChachCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountStauts.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountIsParent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit AccountLevel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit AccountSubLevel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit AccountNumber;
        private DevExpress.XtraEditors.TextEdit AccountName;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.CheckEdit AsChachCheck;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.CheckEdit AccountStauts;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.DateEdit AccountDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AccountNotes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraEditors.SimpleButton CancelBtn;
        private System.Windows.Forms.BindingSource AccountTreeSource;
        private DevExpress.XtraEditors.CheckEdit accountIsParent;
    }
}
