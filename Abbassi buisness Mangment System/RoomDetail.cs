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
    public partial class RoomDetail : UserControl
    {
        private static RoomDetail _instance;
        public static RoomDetail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RoomDetail();
                }
                return _instance;
            }
        }
        public RoomDetail()
        {
            InitializeComponent();
        }

        private void RoomDetail_Load(object sender, EventArgs e)
        {

        }
    }
}