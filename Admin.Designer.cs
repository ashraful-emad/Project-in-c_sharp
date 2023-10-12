
namespace Hospital_management_system
{
    partial class form_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_admin));
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_hospital_management = new System.Windows.Forms.Label();
            this.btn_ad_show = new System.Windows.Forms.Button();
            this.btn_ad_dlt = new System.Windows.Forms.Button();
            this.btn_a_modify = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_admin = new System.Windows.Forms.DateTimePicker();
            this.rbtn_ad_female = new System.Windows.Forms.RadioButton();
            this.rbtn__ad_male = new System.Windows.Forms.RadioButton();
            this.lbl_information = new System.Windows.Forms.Label();
            this.txt_ad_password = new System.Windows.Forms.TextBox();
            this.lbl_set_pass = new System.Windows.Forms.Label();
            this.txt_ad_name = new System.Windows.Forms.TextBox();
            this.txt__ad_phn_num = new System.Windows.Forms.TextBox();
            this.txt_ad_address = new System.Windows.Forms.TextBox();
            this.txt_ad_email = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_phn_num = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_ad_id = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_admin.Location = new System.Drawing.Point(406, 94);
            this.lbl_admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(235, 47);
            this.lbl_admin.TabIndex = 78;
            this.lbl_admin.Text = "Admin  List";
            // 
            // lbl_hospital_management
            // 
            this.lbl_hospital_management.AutoSize = true;
            this.lbl_hospital_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hospital_management.Location = new System.Drawing.Point(264, 14);
            this.lbl_hospital_management.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hospital_management.Name = "lbl_hospital_management";
            this.lbl_hospital_management.Size = new System.Drawing.Size(592, 64);
            this.lbl_hospital_management.TabIndex = 77;
            this.lbl_hospital_management.Text = "Hospital Management";
            // 
            // btn_ad_show
            // 
            this.btn_ad_show.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ad_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_show.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ad_show.Location = new System.Drawing.Point(1005, 777);
            this.btn_ad_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ad_show.Name = "btn_ad_show";
            this.btn_ad_show.Size = new System.Drawing.Size(126, 58);
            this.btn_ad_show.TabIndex = 79;
            this.btn_ad_show.Text = "Show";
            this.btn_ad_show.UseVisualStyleBackColor = false;
            this.btn_ad_show.Click += new System.EventHandler(this.btn_ad_show_Click);
            // 
            // btn_ad_dlt
            // 
            this.btn_ad_dlt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ad_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ad_dlt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ad_dlt.Location = new System.Drawing.Point(498, 777);
            this.btn_ad_dlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ad_dlt.Name = "btn_ad_dlt";
            this.btn_ad_dlt.Size = new System.Drawing.Size(126, 58);
            this.btn_ad_dlt.TabIndex = 80;
            this.btn_ad_dlt.Text = "Delete";
            this.btn_ad_dlt.UseVisualStyleBackColor = false;
            this.btn_ad_dlt.Click += new System.EventHandler(this.btn_ad_dlt_Click);
            // 
            // btn_a_modify
            // 
            this.btn_a_modify.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_a_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a_modify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_a_modify.Location = new System.Drawing.Point(50, 777);
            this.btn_a_modify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_a_modify.Name = "btn_a_modify";
            this.btn_a_modify.Size = new System.Drawing.Size(126, 58);
            this.btn_a_modify.TabIndex = 81;
            this.btn_a_modify.Text = "Modify";
            this.btn_a_modify.UseVisualStyleBackColor = false;
            this.btn_a_modify.Click += new System.EventHandler(this.btn_a_modify_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_back.Location = new System.Drawing.Point(1174, 939);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(80, 48);
            this.btn_back.TabIndex = 82;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Location = new System.Drawing.Point(669, 212);
            this.dataGridView_admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.RowHeadersWidth = 62;
            this.dataGridView_admin.Size = new System.Drawing.Size(585, 542);
            this.dataGridView_admin.TabIndex = 83;
            // 
            // dateTimePicker_admin
            // 
            this.dateTimePicker_admin.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_admin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_admin.Location = new System.Drawing.Point(236, 395);
            this.dateTimePicker_admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_admin.Name = "dateTimePicker_admin";
            this.dateTimePicker_admin.Size = new System.Drawing.Size(386, 30);
            this.dateTimePicker_admin.TabIndex = 101;
            // 
            // rbtn_ad_female
            // 
            this.rbtn_ad_female.AutoSize = true;
            this.rbtn_ad_female.Location = new System.Drawing.Point(504, 565);
            this.rbtn_ad_female.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_ad_female.Name = "rbtn_ad_female";
            this.rbtn_ad_female.Size = new System.Drawing.Size(87, 24);
            this.rbtn_ad_female.TabIndex = 100;
            this.rbtn_ad_female.TabStop = true;
            this.rbtn_ad_female.Text = "Female";
            this.rbtn_ad_female.UseVisualStyleBackColor = true;
            this.rbtn_ad_female.CheckedChanged += new System.EventHandler(this.rbtn_ad_female_CheckedChanged);
            // 
            // rbtn__ad_male
            // 
            this.rbtn__ad_male.AutoSize = true;
            this.rbtn__ad_male.Location = new System.Drawing.Point(236, 565);
            this.rbtn__ad_male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn__ad_male.Name = "rbtn__ad_male";
            this.rbtn__ad_male.Size = new System.Drawing.Size(68, 24);
            this.rbtn__ad_male.TabIndex = 99;
            this.rbtn__ad_male.TabStop = true;
            this.rbtn__ad_male.Text = "Male";
            this.rbtn__ad_male.UseVisualStyleBackColor = true;
            this.rbtn__ad_male.CheckedChanged += new System.EventHandler(this.rbtn__ad_male_CheckedChanged);
            // 
            // lbl_information
            // 
            this.lbl_information.AutoSize = true;
            this.lbl_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_information.Location = new System.Drawing.Point(417, 156);
            this.lbl_information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(207, 40);
            this.lbl_information.TabIndex = 98;
            this.lbl_information.Text = "Information";
            // 
            // txt_ad_password
            // 
            this.txt_ad_password.Location = new System.Drawing.Point(236, 708);
            this.txt_ad_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ad_password.Multiline = true;
            this.txt_ad_password.Name = "txt_ad_password";
            this.txt_ad_password.Size = new System.Drawing.Size(386, 29);
            this.txt_ad_password.TabIndex = 97;
            // 
            // lbl_set_pass
            // 
            this.lbl_set_pass.AutoSize = true;
            this.lbl_set_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_set_pass.Location = new System.Drawing.Point(24, 708);
            this.lbl_set_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_set_pass.Name = "lbl_set_pass";
            this.lbl_set_pass.Size = new System.Drawing.Size(164, 25);
            this.lbl_set_pass.TabIndex = 96;
            this.lbl_set_pass.Text = "Set Password  :";
            // 
            // txt_ad_name
            // 
            this.txt_ad_name.Location = new System.Drawing.Point(236, 212);
            this.txt_ad_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ad_name.Multiline = true;
            this.txt_ad_name.Name = "txt_ad_name";
            this.txt_ad_name.Size = new System.Drawing.Size(386, 29);
            this.txt_ad_name.TabIndex = 95;
            // 
            // txt__ad_phn_num
            // 
            this.txt__ad_phn_num.Location = new System.Drawing.Point(236, 331);
            this.txt__ad_phn_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt__ad_phn_num.Multiline = true;
            this.txt__ad_phn_num.Name = "txt__ad_phn_num";
            this.txt__ad_phn_num.Size = new System.Drawing.Size(386, 29);
            this.txt__ad_phn_num.TabIndex = 93;
            // 
            // txt_ad_address
            // 
            this.txt_ad_address.Location = new System.Drawing.Point(236, 494);
            this.txt_ad_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ad_address.Multiline = true;
            this.txt_ad_address.Name = "txt_ad_address";
            this.txt_ad_address.Size = new System.Drawing.Size(386, 29);
            this.txt_ad_address.TabIndex = 92;
            // 
            // txt_ad_email
            // 
            this.txt_ad_email.Location = new System.Drawing.Point(236, 632);
            this.txt_ad_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ad_email.Multiline = true;
            this.txt_ad_email.Name = "txt_ad_email";
            this.txt_ad_email.Size = new System.Drawing.Size(386, 29);
            this.txt_ad_email.TabIndex = 91;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(102, 632);
            this.lbl_mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(84, 25);
            this.lbl_mail.TabIndex = 90;
            this.lbl_mail.Text = "Email  :";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(90, 565);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(102, 25);
            this.lbl_gender.TabIndex = 89;
            this.lbl_gender.Text = "Gender  :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(80, 494);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(111, 25);
            this.lbl_address.TabIndex = 88;
            this.lbl_address.Text = "Address  :";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(2, 395);
            this.lbl_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(183, 25);
            this.lbl_dob.TabIndex = 87;
            this.lbl_dob.Text = "Date of birthday  :";
            // 
            // lbl_phn_num
            // 
            this.lbl_phn_num.AutoSize = true;
            this.lbl_phn_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phn_num.Location = new System.Drawing.Point(24, 331);
            this.lbl_phn_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phn_num.Name = "lbl_phn_num";
            this.lbl_phn_num.Size = new System.Drawing.Size(165, 25);
            this.lbl_phn_num.TabIndex = 86;
            this.lbl_phn_num.Text = "Phone number :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(111, 218);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(81, 25);
            this.lbl_name.TabIndex = 84;
            this.lbl_name.Text = "Name :";
            // 
            // txt_ad_id
            // 
            this.txt_ad_id.Location = new System.Drawing.Point(236, 272);
            this.txt_ad_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ad_id.Multiline = true;
            this.txt_ad_id.Name = "txt_ad_id";
            this.txt_ad_id.Size = new System.Drawing.Size(386, 29);
            this.txt_ad_id.TabIndex = 103;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(147, 278);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(49, 25);
            this.lbl_ID.TabIndex = 102;
            this.lbl_ID.Text = "Id  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 549);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1108, 939);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 106;
            this.pictureBox3.TabStop = false;
            // 
            // form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1306, 1011);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_ad_id);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dateTimePicker_admin);
            this.Controls.Add(this.rbtn_ad_female);
            this.Controls.Add(this.rbtn__ad_male);
            this.Controls.Add(this.lbl_information);
            this.Controls.Add(this.txt_ad_password);
            this.Controls.Add(this.lbl_set_pass);
            this.Controls.Add(this.txt_ad_name);
            this.Controls.Add(this.txt__ad_phn_num);
            this.Controls.Add(this.txt_ad_address);
            this.Controls.Add(this.txt_ad_email);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_phn_num);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.dataGridView_admin);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_a_modify);
            this.Controls.Add(this.btn_ad_dlt);
            this.Controls.Add(this.btn_ad_show);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_hospital_management);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_hospital_management;
        private System.Windows.Forms.Button btn_ad_show;
        private System.Windows.Forms.Button btn_ad_dlt;
        private System.Windows.Forms.Button btn_a_modify;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_admin;
        private System.Windows.Forms.RadioButton rbtn_ad_female;
        private System.Windows.Forms.RadioButton rbtn__ad_male;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.TextBox txt_ad_password;
        private System.Windows.Forms.Label lbl_set_pass;
        public System.Windows.Forms.TextBox txt_ad_name;
        private System.Windows.Forms.TextBox txt__ad_phn_num;
        private System.Windows.Forms.TextBox txt_ad_address;
        private System.Windows.Forms.TextBox txt_ad_email;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_phn_num;
        private System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.TextBox txt_ad_id;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}