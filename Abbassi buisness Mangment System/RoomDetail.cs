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

            private void tbSubmit_Click(object sender, EventArgs e)
            {
             SqlCommand cmd = new SqlCommand();
             cmd.Connection = Home.con;
             cmd.CommandText = "Insert Into Rooms Values (@Room,@Plaza,@Portion,@Owner,@Rent,@Security)";
             cmd.Parameters.AddWithValue("@Room", tbRoomname.Text);
             cmd.Parameters.AddWithValue("@Plaza", tbPlaza.Text);
             cmd.Parameters.AddWithValue("@Portion", tbPortion.Text);
             cmd.Parameters.AddWithValue("@Owner", tbOwner.Text);
             cmd.Parameters.AddWithValue("@Rent", tbRent.Text);
             cmd.Parameters.AddWithValue("@Security", tbSecurity.Text);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Success");
            }
            /*DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Room", typeof(string)));
            dt.Columns.Add(new DataColumn("Plaza", typeof(string)));
            dt.Columns.Add(new DataColumn("Portion", typeof(string)));
            dt.Columns.Add(new DataColumn("Owner", typeof(String)));
            dt.Columns.Add(new DataColumn("Rent", typeof(int)));
            dt.Columns.Add(new DataColumn("Security", typeof(int)));
            //Add rows  
            dt.Rows.Add("1000", "Code1", "Phone1", "sdf", 1200, 12000);
            DAO.DAO.InsertInto("Rooms", dt);
            */

        }
        }
    }
