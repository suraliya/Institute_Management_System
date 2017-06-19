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
    public partial class frm_AddNewModule : Bunifu.Framework.UI.BunifuForm
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-R2IR8PE\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True ");
        public frm_AddNewModule()
        {
            InitializeComponent();
        }

        private void frm_AddNewModule_Load(object sender, EventArgs e)
        {
            try
            {


                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(moduleID) FROM Module", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    txt_mod_id.Text = id.ToString();
                }
                //con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // con.Open();
                SqlCommand cmd = new SqlCommand("insert into Module values('" + txt_mod_id.Text + "','" + txtx_course_id.Text + "','" + txt_mod_name.Text + "','" + txt_sem.Text + "','" + txt_teach_hours.Text + "')", con);
                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                    MessageBox.Show("Success", "information");
                else
                    MessageBox.Show("Unsuccess", "information");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txt_mod_id.Text = (Convert.ToInt32(txt_mod_id.Text) + 1).ToString();
            txtx_course_id.Text = "";
            txt_sem.Text = "";
            txt_teach_hours.Text = "";
        }
    }
}
