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
    public partial class frmOrderItemsReport : Form
    {
        DataAccess.OrderRepository orderRepo = new DataAccess.OrderRepository();
        int OrderID;

        private void BindGrid()
        {
            grdOrderItemsReport.AutoGenerateColumns = false;
            grdOrderItemsReport.DataSource = null;
            grdOrderItemsReport.DataSource = orderRepo.GetOrderItems(OrderID);
        }
        public frmOrderItemsReport(int orderID)
        {
            InitializeComponent();
            OrderID = orderID;
        }

        private void grdOrderItemsReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrderItemsReport_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
