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
    public partial class frm_CreateNewUser : Bunifu.Framework.UI.BunifuForm
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-R2IR8PE\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True ");
        SqlCommand cmd;
        public frm_CreateNewUser()
        {
            InitializeComponent();
        }

        private void frm_CreateNewUser_Load(object sender, EventArgs e)
        {
            cmb_Usertype.AddItem("Program Officer");
            cmb_Usertype.AddItem("Student");
            cmb_Usertype.AddItem("Lecture");
            cmb_Usertype.AddItem("Cashier");
            cmb_Usertype.AddItem("Director");

            cmb_quize.AddItem("What is your first school name ?");
            cmb_quize.AddItem("What is your favourite subject ?");
            cmb_quize.AddItem("What is your first pet name ?");
            cmb_quize.AddItem("What is your favourite hobby ?");
            cmb_quize.AddItem("What is your favourite sport ?");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT MAX(logID) FROM Login", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1 ;
                txt_userID.Text = id.ToString();
            }
            con.Close();
            
           
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            
            if (cmb_quize.selectedIndex == 0)
            {
                txt_quize.Text = "900";
               
            }

            if (cmb_quize.selectedIndex == 1)
            {
                txt_quize.Text = "901";
            }

            if (cmb_quize.selectedIndex == 2)
            {
                txt_quize.Text = "902";
            }

            if (cmb_quize.selectedIndex == 3)
            {
                txt_quize.Text = "903";
            }

            if (cmb_quize.selectedIndex == 4)
            {
                txt_quize.Text = "904";
            }

            try
            {
                if (txt_password.Text == txt_retypepassword.Text)
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Login VALUES ('" + txt_userID.Text + "' ,  '" + txt_username.Text + "' ,  '" + txt_password.Text + "' , '" + cmb_Usertype.selectedValue.ToString() + "' , '" + Convert.ToInt16(txt_quize.Text) + "' , '"+ txt_quizeAns.Text+"'  ) ", con);
                    int line = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                                 
                    if (line == 1)
                    {
                        MessageBox.Show("User added successfully... ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("User added not successfully... ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else if (txt_password.Text != txt_retypepassword.Text)
                {
                    MessageBox.Show("Password doesn't match... ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            catch(SqlException)
            {
                MessageBox.Show(" DB Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                  
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
