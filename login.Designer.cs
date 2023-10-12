
using System;
using System.ComponentModel;

namespace Hospital_management_system
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.link_lbl_fogotten_pass = new System.Windows.Forms.LinkLabel();
            this.txt_for_signup = new System.Windows.Forms.Label();
            this.lbl_create_account = new System.Windows.Forms.Label();
            this.link_lbl_signup = new System.Windows.Forms.LinkLabel();
            this.lbl_hospital_management = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chk_Show = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userid.Location = new System.Drawing.Point(296, 351);
            this.lbl_userid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(139, 33);
            this.lbl_userid.TabIndex = 56;
            this.lbl_userid.Text = "User ID :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(278, 462);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(169, 33);
            this.lbl_password.TabIndex = 57;
            this.lbl_password.Text = "Password :";
            // 
            // txt_userid
            // 
            this.txt_userid.BackColor = System.Drawing.Color.MistyRose;
            this.txt_userid.Location = new System.Drawing.Point(482, 351);
            this.txt_userid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_userid.Multiline = true;
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(284, 29);
            this.txt_userid.TabIndex = 58;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.MistyRose;
            this.txt_password.Location = new System.Drawing.Point(482, 462);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(284, 29);
            this.txt_password.TabIndex = 59;
            // 
            // link_lbl_fogotten_pass
            // 
            this.link_lbl_fogotten_pass.AutoSize = true;
            this.link_lbl_fogotten_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl_fogotten_pass.Location = new System.Drawing.Point(516, 609);
            this.link_lbl_fogotten_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_lbl_fogotten_pass.Name = "link_lbl_fogotten_pass";
            this.link_lbl_fogotten_pass.Size = new System.Drawing.Size(189, 22);
            this.link_lbl_fogotten_pass.TabIndex = 60;
            this.link_lbl_fogotten_pass.TabStop = true;
            this.link_lbl_fogotten_pass.Text = "Forgotten password..?";
            this.link_lbl_fogotten_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_fogotten_pass_LinkClicked);
            // 
            // txt_for_signup
            // 
            this.txt_for_signup.AutoSize = true;
            this.txt_for_signup.Location = new System.Drawing.Point(350, 532);
            this.txt_for_signup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_for_signup.Name = "txt_for_signup";
            this.txt_for_signup.Size = new System.Drawing.Size(0, 20);
            this.txt_for_signup.TabIndex = 61;
            // 
            // lbl_create_account
            // 
            this.lbl_create_account.AutoSize = true;
            this.lbl_create_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_create_account.Location = new System.Drawing.Point(296, 745);
            this.lbl_create_account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_create_account.Name = "lbl_create_account";
            this.lbl_create_account.Size = new System.Drawing.Size(349, 29);
            this.lbl_create_account.TabIndex = 62;
            this.lbl_create_account.Text = "Click here for create an account";
            // 
            // link_lbl_signup
            // 
            this.link_lbl_signup.AutoSize = true;
            this.link_lbl_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl_signup.Location = new System.Drawing.Point(682, 745);
            this.link_lbl_signup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_lbl_signup.Name = "link_lbl_signup";
            this.link_lbl_signup.Size = new System.Drawing.Size(95, 29);
            this.link_lbl_signup.TabIndex = 63;
            this.link_lbl_signup.TabStop = true;
            this.link_lbl_signup.Text = "Sign up";
            this.link_lbl_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_signup_LinkClicked);
            // 
            // lbl_hospital_management
            // 
            this.lbl_hospital_management.AutoSize = true;
            this.lbl_hospital_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hospital_management.Location = new System.Drawing.Point(291, 62);
            this.lbl_hospital_management.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hospital_management.Name = "lbl_hospital_management";
            this.lbl_hospital_management.Size = new System.Drawing.Size(592, 64);
            this.lbl_hospital_management.TabIndex = 64;
            this.lbl_hospital_management.Text = "Hospital Management";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(503, 532);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(153, 54);
            this.btn_login.TabIndex = 66;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_sus_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(987, 815);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 67;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(218, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(218, 436);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // chk_Show
            // 
            this.chk_Show.AutoSize = true;
            this.chk_Show.Location = new System.Drawing.Point(796, 465);
            this.chk_Show.Name = "chk_Show";
            this.chk_Show.Size = new System.Drawing.Size(148, 24);
            this.chk_Show.TabIndex = 71;
            this.chk_Show.Text = "Show Password";
            this.chk_Show.UseVisualStyleBackColor = true;
            this.chk_Show.CheckedChanged += new System.EventHandler(this.chk_Show_CheckedChanged);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1098, 628);
            this.Controls.Add(this.chk_Show);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_hospital_management);
            this.Controls.Add(this.link_lbl_signup);
            this.Controls.Add(this.lbl_create_account);
            this.Controls.Add(this.txt_for_signup);
            this.Controls.Add(this.link_lbl_fogotten_pass);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_userid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.LinkLabel link_lbl_fogotten_pass;
        private System.Windows.Forms.Label txt_for_signup;
        private System.Windows.Forms.Label lbl_create_account;
        private System.Windows.Forms.LinkLabel link_lbl_signup;
        private System.Windows.Forms.Label lbl_hospital_management;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chk_Show;
    }
}

