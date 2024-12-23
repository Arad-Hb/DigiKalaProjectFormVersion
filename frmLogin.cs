using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DigiKalaProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataAccess.UserRepository userRepository = new DataAccess.UserRepository();
            bool isLogin = userRepository.Login(txtLoginUserName.Text,txtLoginPassword.Text);
            if(isLogin)
            {
                frmMain frm = new frmMain(txtLoginUserName.Text);
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد!!!!");
            }
        }
        //private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyCode == Keys.V)
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
        //    }
        //}
        //private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyCode == Keys.V)
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
        //    }
        //}
        //private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (CheckUsernameAndPasswordCharacters(e.KeyChar.ToString()))
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (CheckUsernameAndPasswordCharacters(e.KeyChar.ToString()))
        //    {
        //        e.Handled = true;
        //    }
        //}

    }
}
