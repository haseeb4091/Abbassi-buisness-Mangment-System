using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Abbassi_buisness_Mangment_System.DAO
{
    class DAO
    {
        
        public static int InsertInto(string name,DataTable dt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Home.con;
            cmd.CommandText = $"Insert Into { name} values {dt}";
            int r=cmd.ExecuteNonQuery();
            if (r > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
