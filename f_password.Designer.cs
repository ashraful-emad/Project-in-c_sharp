
using System;
using System.Windows.Forms;

namespace Hospital_management_system
{
    partial class form_f_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_f_password));
            this.btn_p_search = new System.Windows.Forms.Button();
            this.lbl_human = new System.Windows.Forms.Label();
            this.txt_human_check = new System.Windows.Forms.CheckBox();
            this.txt_enter_id = new System.Windows.Forms.TextBox();
            this.lbl_enter_id = new System.Windows.Forms.Label();
            this.lbl_hospital_management = new System.Windows.Forms.Label();
            this.txt_reset_password = new System.Windows.Forms.TextBox();
            this.lbl_reset_pass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_p_search
            // 
            this.btn_p_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_p_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_p_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_p_search.Location = new System.Drawing.Point(420, 472);
            this.btn_p_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_p_search.Name = "btn_p_search";
            this.btn_p_search.Size = new System.Drawing.Size(218, 58);
            this.btn_p_search.TabIndex = 101;
            this.btn_p_search.Text = "OK";
            this.btn_p_search.UseVisualStyleBackColor = false;
            this.btn_p_search.Visible = false;
            this.btn_p_search.Click += new System.EventHandler(this.btn_p_search_Click);
            // 
            // lbl_human
            // 
            this.lbl_human.AutoSize = true;
            this.lbl_human.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_human.Location = new System.Drawing.Point(415, 378);
            this.lbl_human.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_human.Name = "lbl_human";
            this.lbl_human.Size = new System.Drawing.Size(182, 25);
            this.lbl_human.TabIndex = 99;
            this.lbl_human.Text = "Are You Human ?";
            // 
            // txt_human_check
            // 
            this.txt_human_check.AutoSize = true;
            this.txt_human_check.Location = new System.Drawing.Point(642, 381);
            this.txt_human_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_human_check.Name = "txt_human_check";
            this.txt_human_check.Size = new System.Drawing.Size(63, 24);
            this.txt_human_check.TabIndex = 98;
            this.txt_human_check.Text = "Yes";
            this.txt_human_check.UseVisualStyleBackColor = true;
            this.txt_human_check.CheckedChanged += new System.EventHandler(this.txt_human_check_CheckedChanged);
            // 
            // txt_enter_id
            // 
            this.txt_enter_id.Location = new System.Drawing.Point(420, 231);
            this.txt_enter_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_enter_id.Multiline = true;
            this.txt_enter_id.Name = "txt_enter_id";
            this.txt_enter_id.Size = new System.Drawing.Size(302, 29);
            this.txt_enter_id.TabIndex = 97;
            this.txt_enter_id.TextChanged += new System.EventHandler(this.txt_enter_id_TextChanged);
            // 
            // lbl_enter_id
            // 
            this.lbl_enter_id.AutoSize = true;
            this.lbl_enter_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enter_id.Location = new System.Drawing.Point(278, 231);
            this.lbl_enter_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_enter_id.Name = "lbl_enter_id";
            this.lbl_enter_id.Size = new System.Drawing.Size(106, 25);
            this.lbl_enter_id.TabIndex = 96;
            this.lbl_enter_id.Text = "Enter  Id :";
            // 
            // lbl_hospital_management
            // 
            this.lbl_hospital_management.AutoSize = true;
            this.lbl_hospital_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hospital_management.Location = new System.Drawing.Point(291, 23);
            this.lbl_hospital_management.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hospital_management.Name = "lbl_hospital_management";
            this.lbl_hospital_management.Size = new System.Drawing.Size(592, 64);
            this.lbl_hospital_management.TabIndex = 95;
            this.lbl_hospital_management.Text = "Hospital Management";
            // 
            // txt_reset_password
            // 
            this.txt_reset_password.Location = new System.Drawing.Point(420, 294);
            this.txt_reset_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_reset_password.Multiline = true;
            this.txt_reset_password.Name = "txt_reset_password";
            this.txt_reset_password.Size = new System.Drawing.Size(302, 38);
            this.txt_reset_password.TabIndex = 103;
            // 
            // lbl_reset_pass
            // 
            this.lbl_reset_pass.AutoSize = true;
            this.lbl_reset_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reset_pass.Location = new System.Drawing.Point(188, 294);
            this.lbl_reset_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reset_pass.Name = "lbl_reset_pass";
            this.lbl_reset_pass.Size = new System.Drawing.Size(192, 25);
            this.lbl_reset_pass.TabIndex = 102;
            this.lbl_reset_pass.Text = "Reset  Password  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(302, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // form_f_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_reset_password);
            this.Controls.Add(this.lbl_reset_pass);
            this.Controls.Add(this.btn_p_search);
            this.Controls.Add(this.lbl_human);
            this.Controls.Add(this.txt_human_check);
            this.Controls.Add(this.txt_enter_id);
            this.Controls.Add(this.lbl_enter_id);
            this.Controls.Add(this.lbl_hospital_management);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_f_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_password";
            this.Load += new System.EventHandler(this.form_f_password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void link_lbl_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btn_p_search;
        private System.Windows.Forms.Label lbl_human;
        private System.Windows.Forms.CheckBox txt_human_check;
        private System.Windows.Forms.TextBox txt_enter_id;
        private System.Windows.Forms.Label lbl_enter_id;
        private System.Windows.Forms.Label lbl_hospital_management;
        private System.Windows.Forms.TextBox txt_reset_password;
        private System.Windows.Forms.Label lbl_reset_pass;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}