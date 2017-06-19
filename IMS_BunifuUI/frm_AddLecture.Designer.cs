namespace IMS_BunifuUI
{
    partial class frm_AddLecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddLecture));
            this.btn_exit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_clear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_qualification = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_contnum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_lecadd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_lecname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_lectureID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.ActiveBorderThickness = 1;
            this.btn_exit.ActiveCornerRadius = 20;
            this.btn_exit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_exit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_exit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.ButtonText = "Exit";
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_exit.IdleBorderThickness = 1;
            this.btn_exit.IdleCornerRadius = 20;
            this.btn_exit.IdleFillColor = System.Drawing.Color.White;
            this.btn_exit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_exit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_exit.Location = new System.Drawing.Point(517, 490);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(181, 43);
            this.btn_exit.TabIndex = 41;
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ActiveBorderThickness = 1;
            this.btn_clear.ActiveCornerRadius = 20;
            this.btn_clear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_clear.ActiveForecolor = System.Drawing.Color.White;
            this.btn_clear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.ButtonText = "Clear";
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_clear.IdleBorderThickness = 1;
            this.btn_clear.IdleCornerRadius = 20;
            this.btn_clear.IdleFillColor = System.Drawing.Color.White;
            this.btn_clear.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_clear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_clear.Location = new System.Drawing.Point(281, 490);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(181, 43);
            this.btn_clear.TabIndex = 40;
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_qualification
            // 
            this.txt_qualification.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_qualification.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_qualification.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_qualification.BorderThickness = 3;
            this.txt_qualification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qualification.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_qualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_qualification.isPassword = false;
            this.txt_qualification.Location = new System.Drawing.Point(294, 421);
            this.txt_qualification.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qualification.Name = "txt_qualification";
            this.txt_qualification.Size = new System.Drawing.Size(256, 42);
            this.txt_qualification.TabIndex = 39;
            this.txt_qualification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_contnum
            // 
            this.txt_contnum.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_contnum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contnum.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_contnum.BorderThickness = 3;
            this.txt_contnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contnum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_contnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contnum.isPassword = false;
            this.txt_contnum.Location = new System.Drawing.Point(294, 354);
            this.txt_contnum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contnum.Name = "txt_contnum";
            this.txt_contnum.Size = new System.Drawing.Size(256, 42);
            this.txt_contnum.TabIndex = 38;
            this.txt_contnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_email
            // 
            this.txt_email.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_email.BorderThickness = 3;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email.isPassword = false;
            this.txt_email.Location = new System.Drawing.Point(294, 278);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(481, 42);
            this.txt_email.TabIndex = 37;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_lecadd
            // 
            this.txt_lecadd.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_lecadd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lecadd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_lecadd.BorderThickness = 3;
            this.txt_lecadd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lecadd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_lecadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lecadd.isPassword = false;
            this.txt_lecadd.Location = new System.Drawing.Point(294, 206);
            this.txt_lecadd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lecadd.Name = "txt_lecadd";
            this.txt_lecadd.Size = new System.Drawing.Size(481, 42);
            this.txt_lecadd.TabIndex = 36;
            this.txt_lecadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_lecname
            // 
            this.txt_lecname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_lecname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lecname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_lecname.BorderThickness = 3;
            this.txt_lecname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lecname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_lecname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lecname.isPassword = false;
            this.txt_lecname.Location = new System.Drawing.Point(294, 150);
            this.txt_lecname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lecname.Name = "txt_lecname";
            this.txt_lecname.Size = new System.Drawing.Size(481, 42);
            this.txt_lecname.TabIndex = 35;
            this.txt_lecname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_register
            // 
            this.btn_register.ActiveBorderThickness = 1;
            this.btn_register.ActiveCornerRadius = 20;
            this.btn_register.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_register.ActiveForecolor = System.Drawing.Color.White;
            this.btn_register.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_register.BackColor = System.Drawing.SystemColors.Control;
            this.btn_register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_register.BackgroundImage")));
            this.btn_register.ButtonText = "Register";
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_register.IdleBorderThickness = 1;
            this.btn_register.IdleCornerRadius = 20;
            this.btn_register.IdleFillColor = System.Drawing.Color.White;
            this.btn_register.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_register.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_register.Location = new System.Drawing.Point(53, 490);
            this.btn_register.Margin = new System.Windows.Forms.Padding(5);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(181, 43);
            this.btn_register.TabIndex = 34;
            this.btn_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_lectureID
            // 
            this.txt_lectureID.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_lectureID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lectureID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_lectureID.BorderThickness = 3;
            this.txt_lectureID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lectureID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_lectureID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lectureID.isPassword = false;
            this.txt_lectureID.Location = new System.Drawing.Point(294, 87);
            this.txt_lectureID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lectureID.Name = "txt_lectureID";
            this.txt_lectureID.Size = new System.Drawing.Size(256, 42);
            this.txt_lectureID.TabIndex = 33;
            this.txt_lectureID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(123, 441);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(100, 20);
            this.bunifuCustomLabel13.TabIndex = 32;
            this.bunifuCustomLabel13.Text = "Qualification:";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(94, 364);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(129, 20);
            this.bunifuCustomLabel12.TabIndex = 31;
            this.bunifuCustomLabel12.Text = "Contact Number:";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(171, 298);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel11.TabIndex = 30;
            this.bunifuCustomLabel11.Text = "Email:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(151, 226);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(72, 20);
            this.bunifuCustomLabel7.TabIndex = 29;
            this.bunifuCustomLabel7.Text = "Address:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(110, 161);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(113, 20);
            this.bunifuCustomLabel3.TabIndex = 28;
            this.bunifuCustomLabel3.Text = "Lecture Name:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(135, 107);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(88, 20);
            this.bunifuCustomLabel2.TabIndex = 27;
            this.bunifuCustomLabel2.Text = "Lecture ID:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(267, 28);
            this.bunifuCustomLabel1.TabIndex = 26;
            this.bunifuCustomLabel1.Text = "Lecture Registration Portal";
            // 
            // frm_AddLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 575);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_qualification);
            this.Controls.Add(this.txt_contnum);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lecadd);
            this.Controls.Add(this.txt_lecname);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_lectureID);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "frm_AddLecture";
            this.Text = "frm_AddLecture";
            this.Load += new System.EventHandler(this.frm_AddLecture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_exit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_clear;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_qualification;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_contnum;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_email;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_lecadd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_lecname;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_register;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_lectureID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}