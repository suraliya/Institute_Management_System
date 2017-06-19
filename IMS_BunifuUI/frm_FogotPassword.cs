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
    
    public partial class frm_FogotPassword : Bunifu.Framework.UI.BunifuForm
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-R2IR8PE\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True ");
        SqlCommand cmd;        
       
        public frm_FogotPassword()
        {
            InitializeComponent();
        }

        

        
        private void frm_FogotPassword_Load(object sender, EventArgs e)
        {
            cmb_quize.AddItem("What is your first school name ?");
            cmb_quize.AddItem("What is your favourite subject ?");
            cmb_quize.AddItem("What is your first pet name ?");
            cmb_quize.AddItem("What is your favourite hobby ?");
            cmb_quize.AddItem("What is your favourite sport ?");
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_StuRegis_Click(object sender, EventArgs e)
        {

        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            
            if (txt_RTPassword.Text == txt_Npassword.Text)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand(" UPDATE Login SET userPass = '" + txt_Npassword.Text + "' WHERE userID = '" + txt_userName.Text + "' AND quizeAns = '" + txt_answer.Text + "' ", con);
                    int line = cmd.ExecuteNonQuery();
                    con.Close();

                    if(line == 1)
                    {
                        MessageBox.Show(" Password Successfully Changed... ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show(" Password does not updated... check again... ", "Warning", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                    }
                }

                catch(SqlException)
                {
                    MessageBox.Show("Operation Error... check and try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Password doesn't match...", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }         

            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_quize_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
