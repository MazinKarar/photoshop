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

namespace Purchase
{
    public partial class StoresForm : DevExpress.XtraEditors.XtraUserControl
    {
        Boolean isEditForm = false;
        int i;
        public StoresForm()
        {
            InitializeComponent();

            GetId();
            
        }

        private void GetId()
        {
            using (var db = new AccountingSystem())
            {
                var dc = 0;
                try
                {
                    dc = (from c in db.Wharehouses
                          select c.Id).Max();
                }
                catch (Exception) { }
                GroupId.Text = (int.Parse(dc.ToString()) + 1) + "";
            }
        }

        public StoresForm(string Id)
        {
            InitializeComponent();
            if (!Id.Equals("AddStore"))
            {
                Wharehous updatedItem = new Wharehous();
                using (var db = new AccountingSystem())
                {
                    i = int.Parse(Id);
                    updatedItem = db.Wharehouses.First(x => x.Id == i);
                    isEditForm = true;


                    GroupId.Text = updatedItem.Id.ToString();
                    GroupName.Text = updatedItem.StoreName;
                    StoreBranch.EditValue = updatedItem.BranchID;
                    StoreMobile.Text = updatedItem.Mobile;
                    StoreSize.Text = updatedItem.Size + "";
                    StoreStatus.Checked = (bool)updatedItem.Status;
                    StoreAddress.Text = updatedItem.Address;
                }
            }
            else GetId();

            CancelBtn.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (GroupName.Text.Equals(""))
                ErrorMessage = "الرجاء ادخال الأسم";
            else if (StoreMobile.Text.Equals(""))
                ErrorMessage = "الرجاء ادخال التلفون";
            else if (StoreSize.Text.Equals(""))
                ErrorMessage = "الرجاء ادخال المساحة";
            else if (StoreAddress.Text.Equals(""))
                ErrorMessage = "الرجاء ادخال العنوان";
            else if (StoreBranch.Text.Equals(""))
                ErrorMessage = "الرجاء اختيار الفرع";
          
                 using (var db = new AccountingSystem())
                {
                    var StoreEntity = db.Wharehouses.Create();

            if(ErrorMessage.Equals(""))
            {
                
                    StoreEntity.StoreName = GroupName.Text;
                    StoreEntity.Status = StoreStatus.Checked;
                    StoreEntity.Mobile = StoreMobile.Text;
                    StoreEntity.Size = int.Parse(StoreSize.Text);
                    StoreEntity.Address = StoreAddress.Text;
                    StoreEntity.BranchID = int.Parse(StoreBranch.Text);

                    if (isEditForm)
                    {
                        StoreEntity.Id = i;
                        db.Entry(StoreEntity).State = System.Data.Entity.EntityState.Modified;
                    } 
                    else
                    db.Wharehouses.Add(StoreEntity);

                    try
                    {
                        db.SaveChanges();

                        if (!isEditForm)
                        {
                            GroupName.Text = "";
                            StoreStatus.Checked = false;
                            StoreMobile.Text = "";
                            StoreSize.Text = "";
                            StoreAddress.Text = "";
                            StoreBranch.Text = "";
                            GroupId.Text = (int.Parse(GroupId.Text) + 1) + "";
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
                        MessageBox.Show(val.ToString());
                    }
                }
            else
                MessageBox.Show(ErrorMessage);
                }
           
               
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelBtn.DialogResult = DialogResult.Cancel;
            this.ParentForm.Close();
        }
    }
}
