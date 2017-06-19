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

namespace IMS_BunifuUI
{
    public class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        Database()
        {
            con = new SqlConnection("Data Source=DESKTOP-R2IR8PE\\SQLEXPRESS;Initial Catalog=Security;Integrated Security=True");
        }

        public void openCon()
        {
            con.Open();
        }

        public void closeCon()
        {
            con.Close();
        }

        public int SaveDeleteUpdate(string query)
        {
            int rw;

            openCon();
            cmd = new SqlCommand(query, con);
            rw = cmd.ExecuteNonQuery();
            cmd.Dispose();
            closeCon();

            return rw;
        }

        public DataTable viewAllData(string query)
        {
            openCon();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeCon();

            return dt;
        }
    }
}
