using DataAccess;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiKalaProject
{
    public partial class frmProduct : Form
    {
        DataAccess.ProductRepository repo = new DataAccess.ProductRepository();
        int id;
        public frmProduct()
        {
            InitializeComponent();
        }
        #region DataBinders
        private void BindGrid()
        {
            grdProduct.AutoGenerateColumns = false;
            grdProduct.DataSource = null;
            grdProduct.DataSource = repo.GetAll();
        }
        private void BindCategoryCombo()
        {
            DataAccess.CategoryRepository repo = new DataAccess.CategoryRepository();
            List<Category> categories = repo.GetAll();
            categories.Insert(0,new Category { CategoryID=-1,CategoryName="انتخاب رده"});
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = categories;
        }
        #endregion
        #region Utility
        private void GoToAddMode()
        {
            btnAdd.Enabled = true;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void GoToEditMode()
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            err.Clear();    
            int CatID=Convert.ToInt32(cmbCategory.SelectedValue);
            if (CatID == -1)
            {
                err.SetError(cmbCategory,"لطفا رده درست را انتخاب کنید!");
                return;
            }
            try
            {
                long BasePrice = Convert.ToInt32(txtBasePrice.Text);
                double Rate = Convert.ToDouble(txtRate.Text);
            }
            catch { err.SetError(txtBasePrice, "لطفا قیمت یا امتیاز را به عدد وارد نمایید"); }
            bool isSaleable = rdbActive.Checked;
            Product prd = new Product { ProductName = txtProductName.Text, BasePrice = Convert.ToInt32(txtBasePrice.Text), Description = txtDescription.Text,Rate=Convert.ToDouble(txtRate.Text),IsSaleable= isSaleable, CategoryID=CatID };
            repo.Add(prd);
            ClearForm();
            BindGrid();
            GoToAddMode();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = "https://img.global.news.samsung.com/in/wp-content/uploads/2019/01/Galaxy-10yrs_High-Res..jpg";
            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            BindGrid();
            BindCategoryCombo();
            GoToAddMode() ;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isSaleable= rdbActive.Checked;
            Product product = new Product {
                ProductID = id,
                ProductName = txtProductName.Text,
                BasePrice = Convert.ToInt32(txtBasePrice.Text),
                Description = txtDescription.Text,
                Rate = Convert.ToDouble(txtRate.Text),
                IsSaleable =isSaleable,
                CategoryID= Convert.ToInt32(cmbCategory.SelectedValue)
                };
            repo.Update(product);
            BindGrid();
            ClearForm();
            GoToAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            BindGrid();
            GoToAddMode();
        }

       

        private void grdProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdProduct.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("آیا مطمین هستید؟", "هشدار!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    repo.Delete(id);
                    BindGrid();
                    GoToAddMode();
                }
            }
            if (e.ColumnIndex == 8)
            {
                var prd = repo.GetById(id);
                GoToEditMode();
                if (prd.IsSaleable)
                {
                    rdbActive.Checked = true;
                }
                else
                {
                    rdbDisactive.Checked = true;
                }
                txtProductName.Text = prd.ProductName;
                txtBasePrice.Text = prd.BasePrice.ToString();
                txtDescription.Text = prd.Description;
                txtRate.Text = prd.Rate.ToString();
                cmbCategory.SelectedValue = prd.CategoryID;
            }
        }


    }
}
