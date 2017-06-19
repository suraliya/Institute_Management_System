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
    public partial class frm_Student : Bunifu.Framework.UI.BunifuForm
    {
        public frm_Student()
        {
            InitializeComponent();
        }

        private void frm_Student_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
