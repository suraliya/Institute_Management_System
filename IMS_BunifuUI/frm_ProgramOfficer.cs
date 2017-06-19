using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_BunifuUI
{
    public partial class frm_ProgramOfficer : Bunifu.Framework.UI.BunifuForm
    {
        frm_AddNewCourse addc = new frm_AddNewCourse();
        frm_CreateNewUser nuser = new frm_CreateNewUser();

        public frm_ProgramOfficer()
        {
            InitializeComponent();
        }
      
        private void frm_ProgramOfficer_Load(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
                      
            this.Hide();
        }


        frm_StudentRegis stureg = new frm_StudentRegis();
        private void btn_StuRegis_Click(object sender, EventArgs e)
        {
            stureg.Show();
        }

        private void crd_StuReg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CourDetai_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            nuser.Show();
        }

        private void btn_AddCource_Click(object sender, EventArgs e)
        {
            addc.Show();
        }

        frm_AddNewModule addmod = new frm_AddNewModule();
        private void btn_addco_Click(object sender, EventArgs e)
        {
            addmod.Show();
        }

        private void btn_LecDetai_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }
    }
}
