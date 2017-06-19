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
    public partial class frm_AddNewCourse : Bunifu.Framework.UI.BunifuForm
    {
        public frm_AddNewCourse()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-R2IR8PE\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True ");
        
        private void frm_AddNewCourse_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(lectureID) FROM Course", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    txt_courseID.Text = id.ToString();
                }
               // con.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try {
                //con.Open();

                SqlCommand cmd = new SqlCommand("INSERT into Course VALUES ('" + txt_courseID.Text + "' ,  '" + txt_coursename.Text + "','" + txt_coursedue.Text + "','" + txt_coursefee.Text + "')", con);
                int r = cmd.ExecuteNonQuery();
                //cmd.Dispose();
                con.Close();

                if (r == 1)
                    MessageBox.Show("Success", "information");
                else
                    MessageBox.Show("Unsuccess", "information");
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
