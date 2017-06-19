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
    public partial class frm_AddLecture : Bunifu.Framework.UI.BunifuForm
    {
        public frm_AddLecture()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-R2IR8PE\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True ");
        //SqlCommand cmd;

        private void frm_AddLecture_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT  MAX(lectureID) FROM Lecture", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                txt_lectureID.Text = id.ToString();
            }
            con.Close();


        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Lecture values('" + txt_lectureID.Text + "','" + txt_lecname.Text + "','" + txt_lecadd.Text + "','" + txt_email.Text + "','" + txt_contnum.Text + "','" + txt_qualification.Text + "')", con);
            int r = cmd.ExecuteNonQuery();
            if (r == 1)
                MessageBox.Show("Success", "information");
            else
                MessageBox.Show("Unsuccess", "information");
            con.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
