using System;
using DomainModel.Models;
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
    public partial class frmEmployee : Form
    {
        DataAccess.UserRepository userRepo = new DataAccess.UserRepository();
        DataAccess.EmployeeRepository employeeRepo = new DataAccess.EmployeeRepository();

        int userID;
        int employeeID;

        #region DataBinders
        private void BindGrid()
        {
            
            grdEmployee.AutoGenerateColumns = false;
            grdEmployee.DataSource = null;
            grdEmployee.DataSource = employeeRepo.GetAll();
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
        public frmEmployee()
        {
            InitializeComponent();
        }


        private void frmEmployee_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();  
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            bool IsActive = rdbActive.Checked;
            User user = new User { Password = txtPassword.Text, UserName = txtUserName.Text, Mobile = txtMobile.Text, Email = txtEmail.Text, IsActive = IsActive,RoleID=3};
            int userid= userRepo.Add(user);
            Employee employee = new Employee { FirstName = txtFirstName.Text, LastName = txtLastName.Text, Address = txtAddress.Text, IsActive = IsActive, UserID=userid};
            employeeRepo.Add(employee);
            ClearForm();
            BindGrid();
        }

        private void grdEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeID = Convert.ToInt32(grdEmployee.Rows[e.RowIndex].Cells[0].Value);
            userID = Convert.ToInt32(grdEmployee.Rows[e.RowIndex].Cells[1].Value);
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!userRepo.HasRecords(userID))
                    {
                        bool s = employeeRepo.Delete(employeeID);
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
                var emp = employeeRepo.GetById(employeeID);
                var usr = userRepo.GetById(userID);
                GoToEditMode();
                if (emp.IsActive)
                {
                    rdbActive.Checked = true;
                }
                else
                {
                    rdbDisactive.Checked = true;
                }
                txtFirstName.Text = emp.FirstName;
                txtLastName.Text = emp.LastName;
                txtAddress.Text = emp.Address;
                txtPassword.Text = usr.Password;
                txtUserName.Text = usr.UserName;
                txtEmail.Text = usr.Email;
                txtMobile.Text = usr.Mobile;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool IsActive = rdbActive.Checked;
            User user = new User { Password = txtPassword.Text, UserName = txtUserName.Text, Mobile = txtMobile.Text, Email = txtEmail.Text, IsActive = IsActive, UserID = userID ,RoleID=3};
            Employee employee = new Employee { FirstName = txtFirstName.Text, LastName = txtLastName.Text, Address = txtAddress.Text, IsActive = IsActive, EmployeeID = employeeID, UserID = userID };
            userRepo.Update(user);
            employeeRepo.Update(employee);
            BindGrid();
            ClearForm();
            GoToAddMode();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            ClearForm();
            BindGrid();
        }

    }
}
