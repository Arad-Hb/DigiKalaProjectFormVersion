using DataAccess.Services;
using DomainModel.Models;
using FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiKalaProject
{
    public partial class frmCustomer : Form
    {
        DataAccess.UserRepository userRepo = new DataAccess.UserRepository();
        DataAccess.CustomerRepository customerRepo = new DataAccess.CustomerRepository();
        
        int userID;
        int customerID;
        public frmCustomer()
        {
            InitializeComponent();
        }
        
        #region DataBinders
        private void BindGrid()
        {
            grdCustomer.AutoGenerateColumns = false;
            grdCustomer.DataSource = null;
            grdCustomer.DataSource = customerRepo.GetAll();
        }
        #endregion
        #region Utility
        private void GoToAddMode()
        {
            btnAddNew.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void GoToEditMode()
        {
            btnAddNew.Enabled = false;
            btnCancel.Enabled = true;
            btnEdit.Enabled = true;
        }
        private void ClearForm()
        {
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    var txt = (TextBox)ctrl;
                    txt.Text = "";

                }
                if (ctrl is ComboBox)
                {
                    var cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
            }
        }
        #endregion
        



        private void btnAddNew_Click(object sender, EventArgs e)
        {
            bool IsActive = rdbActive.Checked;
            User user = new User { Password = txtPassword.Text, UserName = txtUserName.Text, Mobile = txtMobile.Text, Email = txtEmail.Text, IsActive = IsActive,RoleID=4 };
            int userid = userRepo.Add(user);
            Customer customer = new Customer {FirstName=txtFirstName.Text,LastName=txtLastName.Text,Address=txtAddress.Text,IsActive=IsActive,UserID= userid };
            customerRepo.Add(customer);
            ClearForm();
            BindGrid();
        }
        private void frmCustomer_Load_1(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            bool IsActive = rdbActive.Checked;
            User user = new User { Password = txtPassword.Text, UserName = txtUserName.Text, Mobile = txtMobile.Text, Email = txtEmail.Text, IsActive = IsActive,  UserID = userID, RoleID = 4 };
            Customer customer = new Customer { FirstName = txtFirstName.Text, LastName = txtLastName.Text, Address = txtAddress.Text, IsActive = IsActive ,CustomerID=customerID, UserID = userID };
            userRepo.Update(user);
            customerRepo.Update(customer);
            BindGrid();
            ClearForm();
            GoToAddMode();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            GoToAddMode();
            ClearForm();
            BindGrid();
        }
        private void grdCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerID = Convert.ToInt32(grdCustomer.Rows[e.RowIndex].Cells[0].Value);
            userID = Convert.ToInt32(grdCustomer.Rows[e.RowIndex].Cells[1].Value);
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!userRepo.HasRecords(userID))
                    {
                        bool s = customerRepo.Delete(customerID);
                        if (s)
                        {
                            BindGrid();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("عملیات حذف انجام پذیر نمی باشد!!!!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("این مورد دارای سوابق ثبتی می باشد و حذف آن ممکن نیست!!!!!");
                    }
                }
            }
            if (e.ColumnIndex == 11)
            {
                var cstmr = customerRepo.GetById(customerID);
                var usr = userRepo.GetById(userID);
                GoToEditMode();
                if (cstmr.IsActive)
                {
                    rdbActive.Checked = true;
                }
                else
                {
                    rdbDisactive.Checked = true;
                }
                txtFirstName.Text = cstmr.FirstName;
                txtLastName.Text = cstmr.LastName;
                txtAddress.Text = cstmr.Address;
                txtPassword.Text = usr.Password;
                txtUserName.Text = usr.UserName;
                txtEmail.Text = usr.Email;
                txtMobile.Text = usr.Mobile;
            }
        }




        //#region Checking
        //private void ValidatePersianText(TextBox textBox)
        //{
        //    Regex regex = new Regex("^[\u0600-\u06FF\\s]*$");
        //    if (!regex.IsMatch(textBox.Text))
        //    {
        //        MessageBox.Show("لطفا فقط حروف فارسی وارد کنید");
        //        textBox.Text = regex.Replace(textBox.Text, "");
        //        textBox.SelectionStart = textBox.Text.Length;
        //    }
        //}
        //private bool IsPersianCharacter(char c)
        //{
        //    return (c >= 0x0600 && c <= 0x06FF) ||
        //           (c >= 0xFB50 && c <= 0xFDFF) ||
        //           (c >= 0xFE70 && c <= 0xFeFF) ||
        //           c == ' ' || c == '\b';
        //}
        //private bool CheckInputs()
        //{
        //    bool result = true;
        //    foreach (System.Windows.Forms.Control ctrl in this.Controls)
        //    {
        //        if (ctrl is TextBox txt)
        //        {
        //            switch (txt.Name)
        //            {
        //                case "txtFirstName":
        //                    if (!CheckIsPersianLetters(txt.Text))
        //                    {
        //                        err.SetError(txtFirstName, "نام را به درستی وارد نمایید");
        //                        result = false;

        //                    }
        //                    break;

        //                case "txtLastName":
        //                    if (!CheckIsPersianLetters(txt.Text))
        //                    {
        //                        err.SetError(txtLastName, "نام خانوادگی را به درستی وارد نمایید");
        //                        result = false;

        //                    }
        //                    break;

        //                case "txtAddress":
        //                    if (!CheckAddress(txt.Text))
        //                    {
        //                        err.SetError(txtAddress, "آدرس را به درستی وارد نمایید");
        //                        result = false;

        //                    }
        //                    break;

        //                case "txtMobile":
        //                    if (!CheckIsNumericWithLength(txt.Text, 11))
        //                    {
        //                        err.SetError(txtMobile, "شماره موبایل را به درستی وارد نمایید");
        //                        result = false;

        //                    }
        //                    break;

        //                case "txtNationalCode":
        //                    if (!CheckIsNumericWithLength(txt.Text, 10))
        //                    {
        //                        err.SetError(txtNationalCode, "کد ملی را به درستی وارد نمایید");
        //                        result = false;

        //                    }
        //                    break;
        //            }
        //        }

        //    }
        //    foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
        //    {
        //        foreach (Control ctrl in groupBox.Controls)
        //        {
        //            if (ctrl is RadioButton rdb)
        //            {
        //                if (!rdbMan.Checked && !rdbWoman.Checked)
        //                {
        //                    err.SetError(grpGender, "لطفا جنسیت را انتخاب کنید!!");
        //                    result = false;
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
        //private bool CheckIsNumericWithLength(string input, int length)
        //{
        //    return !string.IsNullOrEmpty(input) &&
        //           input.Length == length &&
        //           long.TryParse(input, out _);
        //}
        //private bool CheckIsPersianLetters(string input)
        //{
        //    string pattern = @"^[\u0600-\u06FF\s]+$";
        //    return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);
        //}
        //private bool CheckAddress(string input)
        //{
        //    string pattern = @"^[\u0600-\u06FF0-9,.\-_ ]*$";
        //    return Regex.IsMatch(input, pattern);
        //}
        //#endregion

        //private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!((e.KeyChar >= '0' && e.KeyChar <= '9')))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtNationalCode_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyCode == Keys.V)
        //    {
        //        e.Handled = false;
        //        MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
        //    }
        //}

        //private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!((e.KeyChar >= '0' && e.KeyChar <= '9')))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyCode == Keys.V)
        //    {
        //        e.Handled = false;
        //        MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
        //    }
        //}

        //private void txtPatientAddress_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!((e.KeyChar >= '\u0600' && e.KeyChar <= '\u06FF') ||
        //        (e.KeyChar >= '0' && e.KeyChar <= '9') ||
        //        (e.KeyChar >= '\u0660' && e.KeyChar <= '\u0669') ||
        //        e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == ','))
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void txtPatientName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!IsPersianCharacter(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void txtPatientName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyCode == Keys.V)
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
        //    }
        //}
        //private void txtPatientName_TextChanged(object sender, EventArgs e)
        //{
        //    ValidatePersianText(txtPatientName);
        //}
    }
}
