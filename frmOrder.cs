using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiKalaProject
{
   
    public partial class frmOrder : Form
    {
        DataAccess.CustomerRepository repo = new DataAccess.CustomerRepository();
        DataAccess.ProductRepository PrdRepo = new DataAccess.ProductRepository();
        DataAccess.OrderRepository orderRepo = new DataAccess.OrderRepository();
        int CurrentEmployeeID;
        int customerID;
        int orderID;
        int productID;
        int orderItemID;
        double TotalPayment=0;
        


        #region DataBinder
        private void BindCategoriesComboBox()
        {
            DataAccess.CategoryRepository CatRepo = new DataAccess.CategoryRepository();
            List<Category> categories =CatRepo.GetAll();
            categories.Insert(0, new Category { CategoryID = -1, CategoryName = "انتخاب رده" });
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DataSource = categories;

        }
        private void BindProductsComboBox(int ID)
        {
            List<ProductList> prd = PrdRepo.GetByParentID(ID);
            prd.Insert(0, new ProductList { ProductID = -1, ProductName = "انتخاب محصول" });
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ProductID";
            cmbProducts.DataSource = prd;
        }
        private void BindTotalPayment()
        {
            double SumTotalPrice= orderRepo.CalculateTotalPrice(orderID);
            double Tax = .1 * SumTotalPrice;
            double Service=.05 * SumTotalPrice;
            TotalPayment = SumTotalPrice+ Tax+ Service;
            lblTotalPayment.Text = TotalPayment.ToString();
            lblSumTotalPrice.Text = SumTotalPrice.ToString();
            lblTax.Text = Tax.ToString();
            lblService.Text = Service.ToString();
        }
        private void BindSelectedProductPanel()
        {
            var product= PrdRepo.GetById(productID);
            lblProductName.Text = product.ProductName;
            lblUnitPrice.Text=product.BasePrice.ToString();
            lblTotalPrice.Text = product.BasePrice.ToString();
        }
        private void BindGrid()
        {
            grdOrders.AutoGenerateColumns = false;
            grdOrders.DataSource = null;
            grdOrders.DataSource = orderRepo.GetOrderItems(orderID);
        }

        #endregion
        #region utility
        private void ClearProductPanel()
        {
            lblProductName.Text=null;
            lblUnitPrice.Text=null;
            lblTotalPrice.Text=null;
            nmrQuantity.Value = 1; 
        }
        private void GoToAddMode()
        {
            btnAddNew.Enabled = true;
            cmbCategories.Enabled = true;
            cmbProducts.Enabled = true;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = Color.Silver;
            btnCancel.BackColor = Color.Silver;
            btnAddNew.BackColor = Color.DarkTurquoise;
        }
        private void GoToEditMode()
        {
            btnAddNew.Enabled = false;
            cmbCategories.Enabled = false;
            cmbProducts.Enabled = false;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.BackColor = Color.DarkTurquoise;
            btnUpdate.BackColor = Color.DarkTurquoise;
            btnAddNew.BackColor = Color.Silver;
        }
        #endregion


        public frmOrder(int empId)
        {
            InitializeComponent();
            CurrentEmployeeID=empId;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(lstCustomer.Items.Count > 0)
            {
                lstCustomer.DataSource=null;
            }
            if(!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text.Length>=1) 
            { 
                List<CustomerList> lst=repo.Search(txtSearch.Text);
                lstCustomer.DisplayMember = "Information";
                lstCustomer.ValueMember = "CustomerID";
                lstCustomer.DataSource = lst;
                lstCustomer.Visible= true;
            }
        }

        private void lstCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customerID = Convert.ToInt32(lstCustomer.SelectedValue);
            var c=repo.GetById(customerID);
            lblFirstName.Text = c.FirstName;
            lblLastName.Text = c.LastName;
            lblMobile.Text = c.User.Mobile;
            lstCustomer.Visible = false;
            txtSearch.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            
            try
            {
                o.TotalPrice = TotalPayment;
                o.Describtion = txtDescribtion.Text;
                o.OrderDate = (DateTime)faDatePicker.SelectedDateTime;
                o.CustomerID = customerID;
                o.EmployeeID = CurrentEmployeeID;
                int result=orderRepo.RegisterOrder(o);
                orderID = result;
                lblOrderID.Text = orderID.ToString();
                MessageBox.Show("سر برگ فاکتور با موفقیت ثبت شد. شماره ی فاکتور:"+result);
                grpbOrderDetails.Enabled = true;
                BindCategoriesComboBox();
                BindProductsComboBox(3);
            }
            catch
            {
                MessageBox.Show("در ثبت فاکتور خطایی رخ داده است!!! لطفا اطلاعات صحیح وارد نمایید.");
            }            
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            err.Clear();
            int CatID = Convert.ToInt32(cmbCategories.SelectedValue);
            if (CatID == -1)
            {
                err.SetError(cmbCategories, "لطفا رده درست را انتخاب کنید!");
                return;
            }
            BindProductsComboBox(CatID);
            
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            err.Clear();
            productID = Convert.ToInt32(cmbProducts.SelectedValue);
            if (productID == -1)
            {
                err.SetError(cmbCategories, "لطفا محصول درست را انتخاب کنید!");
                return;
            }
            BindSelectedProductPanel();
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var productExists = orderRepo.ExistProductInOrder(orderID, Convert.ToInt32(cmbProducts.SelectedValue));
            
            if (productExists==null)
            {
                var od = new OrderItem()
                {
                    OrderID = orderID,
                    ProductID = Convert.ToInt32(cmbProducts.SelectedValue),
                    Quantity = Convert.ToInt32(nmrQuantity.Value),
                    UnitPrice = Convert.ToInt32(lblUnitPrice.Text),
                    TotalPrice = Convert.ToInt32(lblTotalPrice.Text)
                };
                orderRepo.RegisterOrderItems(od);
            }
            else
            {
                int q = productExists.Quantity + Convert.ToInt32(nmrQuantity.Value);
                orderRepo.UpdateQuantity(orderID, Convert.ToInt32(cmbProducts.SelectedValue),q);
            }
            BindGrid();
            BindTotalPayment();
            ClearProductPanel();
        }

        private void nmrQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                err.Clear();
                int quantity = Convert.ToInt32(nmrQuantity.Value);
                int unitPrice = Convert.ToInt32(lblUnitPrice.Text);
                lblTotalPrice.Text = (quantity * unitPrice).ToString();
            }
            catch
            {
                err.SetError(nmrQuantity, "تعداد را وارد کنید!");
            }
        }

        private void grdOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderItemID = Convert.ToInt32(grdOrders.Rows[e.RowIndex].Cells[0].Value);
            
            if (e.ColumnIndex == 7)
            {
                var od = orderRepo.GetOrderItemById(orderItemID);
                var EditingPrd = PrdRepo.GetById(od.ProductID);
                productID = od.ProductID;
                GoToEditMode();
                lblProductName.Text = EditingPrd.ProductName;
                nmrQuantity.Value =od.Quantity;
                lblUnitPrice.Text = od.UnitPrice.ToString();
                lblTotalPrice.Text = od.TotalPrice.ToString(); 
            }
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool s = orderRepo.Delete(orderItemID);
                    if (s)
                    {
                        BindGrid();
                        BindTotalPayment();
                        ClearProductPanel();
                        GoToAddMode();
                    }
                    else
                    {
                        MessageBox.Show("عملیات حذف انجام پذیر نمی باشد!!!!!!");
                    }

                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OrderItem od = new OrderItem 
            {   
                OrderItemID = orderItemID,
                OrderID = orderID,
                ProductID = productID,
                UnitPrice = Convert.ToInt32(lblUnitPrice.Text), 
                TotalPrice = Convert.ToInt32(lblTotalPrice.Text), 
                Quantity = Convert.ToInt32(nmrQuantity.Value) 
            };
            orderRepo.Update(od);
            BindGrid();
            BindTotalPayment();
            ClearProductPanel();
            GoToAddMode();
  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearProductPanel();
            BindGrid();
            GoToAddMode();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            GoToAddMode();
            BindCategoriesComboBox();
            BindProductsComboBox(3);
        }

    }
  
}
