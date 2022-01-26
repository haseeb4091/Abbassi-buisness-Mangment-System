using System;
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
    public partial class RecievePayments : UserControl
    {
        private static RecievePayments _instance;
        public static RecievePayments Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RecievePayments();
                }
                return _instance;
            }
        }
        public RecievePayments()
        {
            Home.con.Open();
            InitializeComponent();
        }
    }
}
