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
    public partial class AddClient : UserControl
    {
        private static AddClient _instance;
        public static AddClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddClient();
                }
                return _instance;
            }
        }
        public AddClient()
        {
            InitializeComponent();
        }
    }
}
