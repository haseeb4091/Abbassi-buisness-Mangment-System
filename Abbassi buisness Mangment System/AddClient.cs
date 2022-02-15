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
    public partial class AddClient : UserControl
    {
        DataTable dtClients = new DataTable();
        DataTable dtRooms = new DataTable();
        String imagePath = "";

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

            dtClients.Columns.Add("R_id", typeof(int));
            dtClients.Columns.Add("name");
            dtClients.Columns.Add("cnic");
            dtClients.Columns.Add("phone");
            dtClients.Columns.Add("address");
            dtClients.Columns.Add("image");
            dtClients.Columns.Add("rent", typeof(int));
            dtClients.Columns.Add("security", typeof(int));
            dtClients.Columns.Add("date_of_joining", typeof(DateTime));

            LoadRooms();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        void LoadRooms()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Home.con;
            cmd.CommandText = "SELECT Room,R_id FROM Rooms";
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dtRooms);
            cmd.ExecuteNonQuery();

            comboBox1.DataSource = dtRooms;
            comboBox1.DisplayMember = "Room";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int room = comboBox1.SelectedIndex;
            int r_id = int.Parse(dtRooms.Rows[room]["R_id"].ToString());

            dtClients.Rows.Add(r_id,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, imagePath,textBox5.Text, textBox6.Text, dateTimePicker1.Value.Date);
            dataGridView1.DataSource = dtClients;

            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; imagePath = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveOrdersToSaleTable();
        }
        public void MoveOrdersToSaleTable()
        {
            SqlBulkCopy objbulk = new SqlBulkCopy(Home.con);
            objbulk.DestinationTableName = "clients";

            objbulk.ColumnMappings.Add("R_id", "R_id");
            objbulk.ColumnMappings.Add("name", "name");
            objbulk.ColumnMappings.Add("cnic", "cnic");
            objbulk.ColumnMappings.Add("phone", "phone");
            objbulk.ColumnMappings.Add("address", "address");
            objbulk.ColumnMappings.Add("image", "image");
            objbulk.ColumnMappings.Add("rent", "rent");
            objbulk.ColumnMappings.Add("security", "security");
            objbulk.ColumnMappings.Add("date_of_joining", "date_of_joining");
            objbulk.WriteToServer(dtClients);

            // MessageBox.Show("moved");

        }
    }
}
