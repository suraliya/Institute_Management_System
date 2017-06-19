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
    public partial class frm_Load : Bunifu.Framework.UI.BunifuForm
    {
        public frm_Load()
        {
            InitializeComponent();
        }

        frm_MainLogin main = new frm_MainLogin();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            main.Show();
        }
    }
}
