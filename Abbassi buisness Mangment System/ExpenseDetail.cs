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
    public partial class ExpenseDetail : UserControl
    {
        private static ExpenseDetail _instance;
        public static ExpenseDetail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExpenseDetail();
                }
                return _instance;
            }
        }
        public ExpenseDetail()
        {
            InitializeComponent();
        }


    }
}
