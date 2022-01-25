﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abbassi_buisness_Mangment_System
{
    public partial class Home : Form
    {
        public Home()
        {
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
    }
}
