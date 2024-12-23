using DomainModel.Models;
using DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiKalaProject
{
    public partial class frmOrderReport : Form
    {
        DataAccess.OrderRepository orderRepo = new DataAccess.OrderRepository();
        List<OrderReportListItem> reportList;
        DateTime? SearchingFromDate;
        DateTime? SearchingToDate;
        int? SearchOrderID;
        int? SearchCustomerID;


        #region DataBinder
        private void BindGrid()
        {
            grdOrderReport.AutoGenerateColumns = false;
            grdOrderReport.DataSource = null;
            grdOrderReport.DataSource = reportList;
        }
        private void BindGridDateToPersian()
        {
            FrameWork.DateTimeUtility utility = new FrameWork.DateTimeUtility();

            foreach (DataGridViewRow row in grdOrderReport.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 1)
                    {
                        cell.Value= utility.GetPersianDate(Convert.ToDateTime(cell.Value));
                    }
                }
            }
        }
        #endregion
        public frmOrderReport()
        {
            InitializeComponent();
        }

        private void frmOrderReport_Load(object sender, EventArgs e)
        {
            reportList = orderRepo.GetAllOrderReportItems();
            BindGrid();
            BindGridDateToPersian();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            OrderSearchModel sm = new OrderSearchModel
            {
                FromDate = SearchingFromDate,
                ToDate= SearchingToDate,
                OrderID= SearchOrderID,
                CustomerID= SearchCustomerID
            };
            reportList = orderRepo.SearchOrder(sm);
            BindGrid();
            BindGridDateToPersian();
        }

        private void DatePickerFromDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            SearchingFromDate = (DateTime?)DatePickerFromDate.SelectedDateTime;
        }
        
        private void DatePickerToDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            SearchingToDate = (DateTime?)DatePickerToDate.SelectedDateTime;
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            string OID = txtOrderID.Text;
            if (string.IsNullOrEmpty(OID))
            {
                SearchOrderID = null;
            }
            else 
            {
                SearchOrderID = Convert.ToInt32(OID);
            }
            
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            string CID= txtCustomerID.Text;
            if (string.IsNullOrEmpty(CID))
            {
                SearchCustomerID =null;
            }
            else
            {
                SearchCustomerID = Convert.ToInt32(CID);
            }
        }

        private void grdOrderReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderItemID = Convert.ToInt32(grdOrderReport.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 6)
            {
                frmOrderItemsReport frm = new frmOrderItemsReport(orderItemID);
                frm.Show();
            }
        }


        private void btnShowAll_Click(object sender, EventArgs e)
        {
            reportList = orderRepo.GetAllOrderReportItems();
            BindGrid();
            BindGridDateToPersian();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            //lblDateTime.Text = FrameWork.PersianDateString.ToPersianDateString();
            FrameWork.DateTimeUtility utility = new FrameWork.DateTimeUtility();
            lblDateTime.Text = utility.GetCurrentDateTime();
        }
    }
}
