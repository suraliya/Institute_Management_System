namespace WindowsFormsApplication1
{
    partial class frm_course_details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_course_details));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_detailstype = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_search = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(568, 18);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(191, 28);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "View Details Portal";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(393, 240);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(93, 39);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Silver;
            this.txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search.BackgroundImage")));
            this.txt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_search.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_search.Icon = ((System.Drawing.Image)(resources.GetObject("txt_search.Icon")));
            this.txt_search.Location = new System.Drawing.Point(649, 219);
            this.txt_search.Margin = new System.Windows.Forms.Padding(8);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(469, 70);
            this.txt_search.TabIndex = 2;
            this.txt_search.text = "search";
            this.txt_search.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(333, 122);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(153, 39);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Details type";
            // 
            // cmb_detailstype
            // 
            this.cmb_detailstype.BackColor = System.Drawing.Color.Transparent;
            this.cmb_detailstype.BorderRadius = 3;
            this.cmb_detailstype.ForeColor = System.Drawing.Color.White;
            this.cmb_detailstype.Items = new string[0];
            this.cmb_detailstype.Location = new System.Drawing.Point(649, 126);
            this.cmb_detailstype.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cmb_detailstype.Name = "cmb_detailstype";
            this.cmb_detailstype.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmb_detailstype.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmb_detailstype.selectedIndex = -1;
            this.cmb_detailstype.Size = new System.Drawing.Size(469, 35);
            this.cmb_detailstype.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_search.color = System.Drawing.Color.SeaGreen;
            this.btn_search.colorActive = System.Drawing.Color.DarkSlateGray;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImagePosition = 13;
            this.btn_search.ImageZoom = 50;
            this.btn_search.LabelPosition = 27;
            this.btn_search.LabelText = "search";
            this.btn_search.Location = new System.Drawing.Point(1119, 219);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(46, 70);
            this.btn_search.TabIndex = 5;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frm_course_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1303, 636);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_detailstype);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frm_course_details";
            this.Text = "frm_course_details";
            this.Load += new System.EventHandler(this.frm_course_details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuTextbox txt_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown cmb_detailstype;
        private Bunifu.Framework.UI.BunifuTileButton btn_search;
    }
}