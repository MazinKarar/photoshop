﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace Purchase
{
    public partial class constraint : DevExpress.XtraEditors.XtraUserControl
    {
        Purchase.AccountingSystem dbContext = new Purchase.AccountingSystem();

        Boolean isEditForm = false;
        string Id = "";
        int i = 0;
        //ConnectDB conect = new ConnectDB();

        public constraint()
        {
            InitializeComponent();
            Ini();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource5.DataSource = dbContext.debenturedetails.Where(c => c.AccountID == 0).ToList();
            using (var db = new AccountingSystem())
            {
                var dc = 0;
                try 
                {
                     dc = db.debentures.ToList().Max(e => Convert.ToInt32(e.DebentureNo));
                    DebentureNo.Text = (int.Parse(dc.ToString()) + 1) + "";
                }
                catch(Exception r)
                {
                    DebentureNo.Text = 1 + "";
                }
             
            }
        }

        public constraint(string id)
        {
            this.Id = id;
            isEditForm = true;
            InitializeComponent();
             i = int.Parse(Id);
              Ini();
            // debentureBindingSource.DataSource = dbContext.debenturedetails.Where(c => c.DebentureID == i).ToList();
            using (var db = new AccountingSystem())
            {

                var dc = from c in db.debentures
                         where c.DebentureID.Equals(i)
                         select new
                         {
                             c.DebentureNo,
                             c.Notes,
                             c.DebentureDate,
                             c.remarks
                         };
                var list = dc.ToList();
                if (list.Count != 0)
                {
                    DebentureNo.Text = list[0].DebentureNo;
                    note.Text = list[0].Notes;
                    date.DateTime = (DateTime)list[0].DebentureDate;
                    nodes.Text = list[0].remarks;
                }
            }
            using (var db = new AccountingSystem())
            {
                var dc = from c in db.debenturedetails
                         where c.DebentureID.Equals(i)
                         select new
                         {
                             c.Amount,
                             c.Payed,
                            
                         };
                var list = dc.ToList();
                if (list.Count != 0)
                {
                    double sum = 0;
                    double sum1 = 0;

                      for (int x = 0; x < list.Count; x++)
                        {
                            sum = sum + double.Parse(list[x].Amount.ToString());
                            sum1 = sum1 + double.Parse(list[x].Payed.ToString());
                        }
                        textcrd.Text = sum.ToString();
                        textdebt.Text = sum1.ToString();
                        sumcrd.Text = sum.ToString();
                        sumdebt.Text = sum1.ToString();
                }
                
            }
            bindingSource5.DataSource = dbContext.debenturedetails.Local.ToBindingList();
            dbContext.debenturedetails.Where(c => c.DebentureID == i).Load();
            Ini();
            bindingSource5.DataSource = dbContext.debenturedetails.Where(c => c.DebentureID == i).ToList();
            //itemBindingSource.DataSource = dbContextItems.Items.Where(c => c.Code == Code).ToList();
        
        }

        private void Ini()
        {
            date.DateTime = DateTime.Now;
            dbContext.debenturedetails.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource4.DataSource = dbContext.debenturedetails.Local.ToBindingList();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource1.DataSource = dbContext.debenturedetails.Where(c => c.AccountID == 0).ToList();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.TreeAccounts.Load();
            // This line of code is generated by Data Source Configuration Wizard
            bindingSource2.DataSource = dbContext.TreeAccounts.Local.ToBindingList();
            treeAccountBindingSource.DataSource = dbContext.TreeAccounts.Where(c => c.active == true).ToList();
        }
        private void editFormUserControl1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {

            using (var db = new AccountingSystem())
            {
                var debenturedetails = db.debenturedetails.Create();//Master Object
                var Debenture = db.debentures.Create();//Master Object
                Debenture.DebentureNo = DebentureNo.Text;
                Debenture.Notes = note.Text;
                Debenture.remarks = nodes.Text;
                Debenture.MDate = DateTime.Now;
                Debenture.UserID = 1;
                Debenture.Sequence = 1;
                Debenture.Amount = 1;
                Debenture.DebentureDate = date.DateTime;

                if (DetGridView != null && !isEditForm)
                {

                    for (int b = 0; b < gridView1.RowCount; b++)
                    {
                        Purchase.debenturedetail DetailsEntity = new Purchase.debenturedetail();

                        var x = int.Parse(gridView1.GetRowCellValue(b, "Amount").ToString());
                        var y = int.Parse(gridView1.GetRowCellValue(b, "Payed").ToString());
                        DetailsEntity.Amount = int.Parse(gridView1.GetRowCellValue(b, "Amount").ToString());
                        DetailsEntity.Payed = int.Parse(gridView1.GetRowCellValue(b, "Payed").ToString());
                        DetailsEntity.AccountID = int.Parse(gridView1.GetRowCellValue(b, "AccountID").ToString());
                        DetailsEntity.ValueDate = DateTime.Now;
                        Debenture.debenturedetails.Add(DetailsEntity);//add details in master object 
                    }
                }
                string Message = "";
                if (DebentureNo.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال الرقم القيد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (note.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال البيان", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    if (double.Parse(textcrd.Text) == 0 || double.Parse(textdebt.Text) == 0 || double.Parse(textcrd.Text) != double.Parse(textdebt.Text))
                    {
                        MessageBox.Show("مجموع القيود الدائنة لايساوي المدينة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView1.Focus();
                        return;
                    }
                    else
                    {
                        if (!isEditForm)
                        {
                            db.debentures.Add(Debenture);
                        }
                        else
                        {

                             
                            int i = int.Parse(Id);
                         //   MessageBox.Show(i.ToString());
                            var Debentur = db.debentures.First(x => x.DebentureID.Equals(i));
                            Debentur.DebentureNo = DebentureNo.Text;
                            Debentur.Notes = note.Text;
                            Debentur.MDate = DateTime.Now;
                            Debentur.remarks = nodes.Text;
                            Debentur.UserID = 1;
                            Debentur.Sequence = 1;
                            Debentur.Amount = 1;
                            Debentur.DebentureDate = date.DateTime;

                            var widgets = db.debenturedetails.Where(x => x.DebentureID.Equals(i));
                            foreach (debenturedetail widget in widgets)
                            {
                                db.debenturedetails.Remove(widget);
                            }
                            if (DetGridView != null)
                            {

                                for (int b = 0; b < gridView1.RowCount; b++)
                                {

                                    Purchase.debenturedetail DetailsEntity = new Purchase.debenturedetail();
                                    var x = int.Parse(gridView1.GetRowCellValue(b, "Amount").ToString());
                                    var y = int.Parse(gridView1.GetRowCellValue(b, "Payed").ToString());
                                    DetailsEntity.Amount = int.Parse(gridView1.GetRowCellValue(b, "Amount").ToString());
                                    DetailsEntity.Payed = int.Parse(gridView1.GetRowCellValue(b, "Payed").ToString());
                                    DetailsEntity.AccountID = int.Parse(gridView1.GetRowCellValue(b, "AccountID").ToString());
                                    DetailsEntity.ValueDate = DateTime.Now;
                                    Debentur.debenturedetails.Add(DetailsEntity);//add details in master object
                                }
                            }
                          //  Debentur.debenturedetails.Add(DetailsEntity);
                            db.Entry(Debentur).State = System.Data.Entity.EntityState.Modified;

           
                        }

                        try
                        {

                            db.SaveChanges();
                            if (isEditForm)
                            Message = "تم التعديل بنجاح";
                            if (!isEditForm)
                            {
                                Message = "تم الحفظ بنجاح";
                                note.Text = "";
                                date.DateTime = DateTime.Now;
                                textcrd.Text = 0+"";
                                textcrd.Text = 0 + "";
                                textdebt.Text = 0 + "";
                                sumcrd.Text = 0 + "";
                                sumdebt.Text = 0 + "";
                                nodes.Text = "";
                                for (int b = 0; b < gridView1.RowCount; b++)
                                {
                                    gridView1.SelectRow(b);
                                    gridView1.DeleteRow(b);
                                    gridView1.SelectAll();
                                    gridView1.DeleteSelectedRows();
                                }
                                using (var dbs = new AccountingSystem())
                                {
                                    
                                    var dc = dbs.debentures.ToList().Max(i => Convert.ToInt32(i.DebentureNo));
                                    DebentureNo.Text = (int.Parse(dc.ToString()) + 1) + "";
                                }
                              
                                                                 
                                
                            }
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                        {
                            Exception raise = dbEx;
                            foreach (var validationErrors in dbEx.EntityValidationErrors)
                            {
                                foreach (var validationError in validationErrors.ValidationErrors)
                                {
                                    string message = string.Format("{0}:{1}",
                                        validationErrors.Entry.Entity.ToString(),
                                        validationError.ErrorMessage);
                                    raise = new InvalidOperationException(message, raise);
                                }
                            }
                            throw raise;
                        }
                        catch (Exception dbEx)
                        {
                            Exception raise = dbEx;
                            var val = dbEx.InnerException;
                            //MessageBox.Show(val.ToString());
                            MessageBox.Show("هذا الحساب غير موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //throw raise;
                        }
                    }
                if(Message !="")
                MessageBox.Show(Message);
            }
        }


        private void AddConstraint_Click(object sender, EventArgs e)
        {
        }

        private void AddConstraint_Click_1(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void daen_Paint(object sender, EventArgs e)
        {

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            double sum = 0;
            double sum1 = 0;
            if (gridView1.RowCount != 0)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    sum = sum + double.Parse(gridView1.GetRowCellValue(i, "Amount").ToString());
                    sum1 = sum1 + double.Parse(gridView1.GetRowCellValue(i, "Payed").ToString());
                }
                textcrd.Text = sum.ToString();
                textdebt.Text = sum1.ToString();
                sumcrd.Text = sum.ToString();
                sumdebt.Text = sum1.ToString();
            }

        }
      
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Amount", 0);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Payed", 0);

        }

        private void gridView1_ColumnChanged(object sender, EventArgs e)
        {
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Amount" && double.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Amount").ToString()) > 0)
                {
                    double credit = double.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Amount").ToString());
                    double debt = double.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Payed").ToString());
                    if (credit > 0 && debt > 0)
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Payed", 0);
                    }
                }
                else if (e.Column.FieldName == "Payed" && double.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Payed").ToString()) > 0)
                {
                    double credit = double.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Amount").ToString());
                    double debt = double.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Payed").ToString());
                    if (credit > 0 && debt > 0)
                    {
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Amount", 0);
                    }
                }
            }
            catch(Exception c)
            {
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Amount", 0);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Payed", 0);
            }
            
        }

        private void nodes_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void constraint_Load(object sender, EventArgs e)
        {

        }

        private void DebentureNo_EditValueChanged(object sender, EventArgs e)
        {
            using (var db = new AccountingSystem())
            {
                if (db.debentures.Any(o => o.DebentureNo == DebentureNo.Text))
                {
                    if (!DebentureNo.Text.Equals(DebentureNo) && !isEditForm)
                        dxErrorProvider1.SetError(DebentureNo, "هذا الرقم موجود", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                    else
                        dxErrorProvider1.ClearErrors();
                }
                else
                {
                    dxErrorProvider1.ClearErrors();

                }
                    
            }
        }
    }
}
