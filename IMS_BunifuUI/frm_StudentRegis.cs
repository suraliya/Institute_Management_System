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
    
    public partial class frm_StudentRegis : Bunifu.Framework.UI.BunifuForm
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-R2IR8PE\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True ");

        public frm_StudentRegis()
        {
            InitializeComponent();
        }

        private void frm_StudentRegis_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT MAX(stuID) FROM Student", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                txt_studntID.Text = id.ToString();
            }
           // con.Close();

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                SqlCommand cmd = new SqlCommand("insert into Student values('" + txt_studntID + "', '" + txt_fmane.Text + "','" + txt_mname.Text + "','" + txt_lname.Text + "','" + txt_addl1.Text + "','" + txt_addl2.Text + "','" + txt_addl3.Text + "','" + Datepicker1.Value + "','" + txt_nic.Text + "','" + txt_gender.Text + "','" + txt_parentname.Text + "','" + txt_age.Text + "','" + txt_contactnum.Text + "','" + txt_econnum.Text + "','" + txt_email.Text + "')", con);
                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    MessageBox.Show("Successfuly added", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not entered successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Data No added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Datepicker1_onValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Today.Year - Datepicker1.Value.Year).ToString();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            txt_studntID.Text = (Convert.ToInt16(txt_studntID.Text) + 1).ToString();
            txt_fmane.Text = "";
            txt_mname.Text = "";
            txt_lname.Text = "";
            txt_addl1.Text = "";
            txt_addl2.Text = "";
            txt_addl3.Text = "";
            txt_age.Text = "";
            txt_contactnum.Text = "";
            txt_econnum.Text = "";
            txt_email.Text = "";
            txt_nic.Text = "";
            txt_parentname.Text = "";
        }
    }
}
