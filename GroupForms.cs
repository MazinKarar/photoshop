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
    public partial class GroupForms : DevExpress.XtraEditors.XtraUserControl
    {
        Boolean isEditForm = false;
        int i;
        public GroupForms()
        {
            InitializeComponent();
            using (var db = new AccountingSystem())
            {
                var dc = 0 ;
                try
                {
                     dc = (from c in db.ItemGroups
                              select c.Id).Max();
                }catch(Exception )
                { }
                GroupId.Text = (int.Parse(dc.ToString()) + 1) + "";
            }
        }

        public GroupForms(string id)
        {
            ItemGroup updatedItem = new ItemGroup();
            InitializeComponent();
                GroupId.Text = id;
                using (var db = new AccountingSystem())
                {
                    i = int.Parse(id);
                    updatedItem = db.ItemGroups.First(x => x.Id == i);
                    isEditForm = true;
                    GroupName.Text = updatedItem.Name;
                }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            simpleButton2.DialogResult = DialogResult.Cancel;
            this.ParentForm.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (GroupName.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("الرجاء ادخال اسم المجموعة");
            }
            else
            {
                using (var db = new AccountingSystem())
                {
                    var groupEntity = db.ItemGroups.Create();

                    groupEntity.Name = GroupName.Text;

                    groupEntity.Type = groupStatus.Checked ? 1 : 0;

                    try
                    {
                        if (isEditForm)
                        {
                            groupEntity.Id = i;
                            db.Entry(groupEntity).State = System.Data.Entity.EntityState.Modified;
                        }
                        else
                        db.ItemGroups.Add(groupEntity);

                        db.SaveChanges();

                        if (!isEditForm)
                        {
                            GroupName.Text = "";
                            GroupId.Text = (int.Parse(GroupId.Text) + 1) + "";
                            groupStatus.Checked = false;
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
            }
        }
      
    }
}
