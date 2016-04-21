using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace Purchase
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        Purchase.AccountingSystem dbContext = new Purchase.AccountingSystem();
        public Login()
        {
            InitializeComponent();
            dbContext.Users.Load();
            dxErrorProvider1.SetIconAlignment(UserName, ErrorIconAlignment.MiddleRight);
            dxErrorProvider1.SetIconAlignment(Passoword, ErrorIconAlignment.MiddleRight);
            dbContext.Users.Load();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج؟", "تأكيد", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (UserName.Text.Equals(""))
                ErrorMessage = "الرجاء ادخال الأسم";
            else if (Passoword.Text.Equals(""))
                ErrorMessage = "الرجاء ادخال كلمة المرور";
            if (ErrorMessage.Equals(""))
            {
              
                    User i = new User();
                    if (dbContext.Users.Any(o => o.UName == UserName.Text))
                    {
                        i = dbContext.Users.Where(m => m.UName.ToLower() == UserName.Text.ToLower()).First();
                        dxErrorProvider1.ClearErrors();
                        if (i.UPassword.Equals(Passoword.Text))
                        {
                            new MainAr(i.UName, i.UGroup).Show();
                            this.Hide();
                        }

                        else
                            dxErrorProvider1.SetError(Passoword, "كلمة المرور غير صحيحة");
                    }
                    else
                        dxErrorProvider1.SetError(UserName, "هذا المستخدم غير موجود");
               
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //ayman test
            // test comment
        }

    
    }
}