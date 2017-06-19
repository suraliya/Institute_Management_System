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
    public partial class frm_MainLogin : Form
    {
        public frm_MainLogin()
        {
            InitializeComponent();
        }

        frm_ProgramOfficer prog = new frm_ProgramOfficer();
        frm_Student stu = new frm_Student();
        frm_Lecture lec = new frm_Lecture();
        frm_Cashier cash = new frm_Cashier();
        frm_Director dir = new frm_Director();        

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MainLogin_Load(object sender, EventArgs e)
        {
            cmb_UserType.AddItem("Program Officer");
            cmb_UserType.AddItem("Student");
            cmb_UserType.AddItem("Lecture");
            cmb_UserType.AddItem("Cashier");
            cmb_UserType.AddItem("Director");
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //try
            //{

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-R2IR8PE\\SQLEXPRESS;Initial Catalog=institute;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter(" SELECT COUNT(*) FROM Login WHERE userID = '" + txt_UserName.Text + "' AND userPass = '" + txt_Password.Text + "' AND uType = '" + cmb_UserType.selectedValue.ToString() + "' ", con);

                da.Fill(dt);
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    MessageBox.Show("Please Fill detals...", "Info", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            //}

            if (dt.Rows[0][0].ToString() == "1")
            {
                if (cmb_UserType.selectedIndex == 0)
                {
                    prog.Show();                    
                    txt_UserName.Text = " ";
                    txt_Password.Text = " ";
                }

                if (cmb_UserType.selectedIndex == 1)
                {
                    stu.Show();
                    txt_UserName.Text = " ";
                    txt_Password.Text = " ";
                }

                if (cmb_UserType.selectedIndex == 2)
                {
                    cash.Show();
                    this.Hide();
                }

                if (cmb_UserType.selectedIndex == 3)
                {
                    dir.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Your Password or Username does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        frm_FogotPassword fogot = new frm_FogotPassword();

        private void link_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fogot.Show();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txt_UserName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
