using DomainModel.ViewModel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DigiKalaProject
{
    public partial class frmMain : Form
    {
        string userName;
        
        public frmMain(string UserName)
        {
            InitializeComponent();
            //this.MaximumSize = new System.Drawing.Size(1500,1500);
            this.WindowState = FormWindowState.Maximized;
            userName = UserName;
            
        }

        private void مدیریتکارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm= new frmEmployee();
            bool exist = false;
            foreach(Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmEmployee)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if(!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            } 
        }

        private void دستهبندیهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmCategory)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }


        }

        private void محصولاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmProduct)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }


        }

        private void مدیریتمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmCustomer)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrameWork.DateTimeUtility utility = new FrameWork.DateTimeUtility();
            lblDateTime.Text = utility.GetCurrentDateTime();
        }

        private void ثبتفاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Employee emp = new DataAccess.EmployeeRepository().GetByUserName(userName);
            int employeeId = emp.EmployeeID;
            frmOrder frm = new frmOrder(employeeId);
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmOrder)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void گزارشفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmOrderReport frm = new frmOrderReport();
            bool exist = false;
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (OpenedForm is frmOrderReport)
                {
                    OpenedForm.Activate();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                frm.MdiParent = this;
                frm.Show();
            }

        }

    }
}
