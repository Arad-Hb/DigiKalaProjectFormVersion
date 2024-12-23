using DataAccess;
using DomainModel.Models;
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
    public partial class frmCategory : Form
    {
        DataAccess.CategoryRepository repo = new DataAccess.CategoryRepository();
        int id;
        public frmCategory()
        {
            InitializeComponent();
        }

        #region DataBinders
        private void BindGrid()
        {
            grdCategory.AutoGenerateColumns = false;
            grdCategory.DataSource = null;
            grdCategory.DataSource = repo.GetAll();
        }
        #endregion
        #region Utility
        private void GoToAddMode()
        {
            btnAdd.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void GoToEditMode()
        {
            btnAdd.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category cat = new Category { CategoryName = txtCategoryName.Text,ParentID=Convert.ToInt32(txtParentID.Text),ChildCount= Convert.ToInt32(txtChildCount.Text), Description = txtDescription.Text };
            repo.Add(cat);
            ClearForm();
            BindGrid();
            GoToAddMode();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }

        private void grdCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(grdCategory.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا مطمین هستید؟", "هشدار!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    bool hasProduct = repo.HasProduct(id);
                    if (!hasProduct)
                    {
                        repo.Delete(id);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("این دسته بندی دارای محصولات زیرمجموعه می باشد و حذف آن ممکن نمی باشد.");
                    }
                }
            }
            if (e.ColumnIndex == 7)
            {
                var cat = repo.GetById(id);
                GoToEditMode();
                txtCategoryName.Text = cat.CategoryName;
                txtChildCount.Text = cat.ChildCount.ToString();
                txtDescription.Text = cat.Description;
                txtParentID.Text = cat.ParentID.ToString();
                txtLineage.Text = cat.Lineage;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Category category = new Category {CategoryID=id,CategoryName=txtCategoryName.Text, ChildCount =Convert.ToInt32(txtChildCount.Text), ParentID = Convert.ToInt32(txtParentID.Text), Description=txtDescription.Text,Lineage=txtLineage.Text};
            repo.Update(category);
            BindGrid();
            ClearForm();
            GoToAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BindGrid();
            ClearForm();
            GoToAddMode();
        }

        
    }
}
