using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Abbassi_buisness_Mangment_System
{

    public partial class AddShops : UserControl
    {
        private static AddShops _instance;
        public static AddShops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddShops();
                }
                return _instance;
            }
        }
        public AddShops()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Home.con;

                if( textBox1.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
                {
                    MessageBox.Show("Please enter valid data!");
                    return;
                }
                cmd.CommandText = "INSERT INTO shops Values(@name,@owner,@rent,@security)";
                cmd.Parameters.AddWithValue("name", textBox1.Text);
                cmd.Parameters.AddWithValue("owner", textBox3.Text);
                cmd.Parameters.AddWithValue("rent", textBox4.Text);
                cmd.Parameters.AddWithValue("security", textBox5.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Shop added successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
           

        }
    }
}
