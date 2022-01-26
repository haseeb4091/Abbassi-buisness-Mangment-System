using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Abbassi_buisness_Mangment_System
{
    public partial class Home : Form
    {
        public static SqlConnection con = new SqlConnection();
        String c = @"Data Source=APPLE40A5\SQLEXPRESS;Initial Catalog=abms;Integrated Security=True";
        public Home()
        {
            con.ConnectionString = c;
            con.Open();
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(DashBoard.Instance))
            {
                panel.Controls.Add(DashBoard.Instance);
                DashBoard.Instance.Dock = DockStyle.Fill;
                DashBoard.Instance.BringToFront();
            }
            else
            {
                DashBoard.Instance.BringToFront();
            }
        }

        private void btn_addrrom_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(RoomDetail.Instance))
            {
                panel.Controls.Add(RoomDetail.Instance);
                RoomDetail.Instance.Dock = DockStyle.Fill;
                RoomDetail.Instance.BringToFront();
            }
            else
            {
                RoomDetail.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(AddShops.Instance))
            {
                panel.Controls.Add(AddShops.Instance);
                AddShops.Instance.Dock = DockStyle.Fill;
                AddShops.Instance.BringToFront();
            }
            else
            {
                AddShops.Instance.BringToFront();
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
           if (!panel.Controls.Contains(ExpenseDetail.Instance))
            {
                panel.Controls.Add(ExpenseDetail.Instance);
                ExpenseDetail.Instance.Dock = DockStyle.Fill;
                ExpenseDetail.Instance.BringToFront();
            }
            else
            {
                ExpenseDetail.Instance.BringToFront();
            }

        }

        private void btnAddclient_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(AddClient.Instance))
            {
                panel.Controls.Add(AddClient.Instance);
                AddClient.Instance.Dock = DockStyle.Fill;
                AddClient.Instance.BringToFront();
            }
            else
            {
                AddClient.Instance.BringToFront();
            }
        }

        private void btnRecievePayment_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(RecievePayments.Instance))
            {
                panel.Controls.Add(RecievePayments.Instance);
                RecievePayments.Instance.Dock = DockStyle.Fill;
                RecievePayments.Instance.BringToFront();
            }
            else
            {
                RecievePayments.Instance.BringToFront();
            }
        }
    }
}
