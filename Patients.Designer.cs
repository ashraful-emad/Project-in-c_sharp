
namespace Hospital_management_system
{
    partial class form_patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_patients));
            this.lbl_patients = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_p_phn = new System.Windows.Forms.TextBox();
            this.txt_p_id = new System.Windows.Forms.TextBox();
            this.txt_patients_name = new System.Windows.Forms.TextBox();
            this.lbl_hospital_management = new System.Windows.Forms.Label();
            this.txt_p_address = new System.Windows.Forms.TextBox();
            this.dateTimePicker_patients = new System.Windows.Forms.DateTimePicker();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.txt_blood_group = new System.Windows.Forms.ComboBox();
            this.txt_major_d = new System.Windows.Forms.TextBox();
            this.btn_p_show = new System.Windows.Forms.Button();
            this.dataGridView_p = new System.Windows.Forms.DataGridView();
            this.lbl_p_name = new System.Windows.Forms.Label();
            this.lbl_p_id = new System.Windows.Forms.Label();
            this.lbl_p_phn = new System.Windows.Forms.Label();
            this.lbl_p_add = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_p_date = new System.Windows.Forms.Label();
            this.lbl_blood = new System.Windows.Forms.Label();
            this.lbl_diease = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_patients
            // 
            this.lbl_patients.AutoSize = true;
            this.lbl_patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_patients.Location = new System.Drawing.Point(476, 96);
            this.lbl_patients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_patients.Name = "lbl_patients";
            this.lbl_patients.Size = new System.Drawing.Size(258, 47);
            this.lbl_patients.TabIndex = 76;
            this.lbl_patients.Text = "Patients List";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_back.Location = new System.Drawing.Point(1021, 930);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(70, 45);
            this.btn_back.TabIndex = 75;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dlt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_dlt.Location = new System.Drawing.Point(242, 875);
            this.btn_dlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(126, 58);
            this.btn_dlt.TabIndex = 74;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = false;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modify.Location = new System.Drawing.Point(242, 762);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(126, 58);
            this.btn_modify.TabIndex = 73;
            this.btn_modify.Text = "Modify";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(64, 762);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 58);
            this.btn_add.TabIndex = 72;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_p_phn
            // 
            this.txt_p_phn.AccessibleName = "";
            this.txt_p_phn.Location = new System.Drawing.Point(202, 302);
            this.txt_p_phn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_p_phn.Multiline = true;
            this.txt_p_phn.Name = "txt_p_phn";
            this.txt_p_phn.Size = new System.Drawing.Size(354, 36);
            this.txt_p_phn.TabIndex = 70;
            this.txt_p_phn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_p_id
            // 
            this.txt_p_id.AccessibleName = "";
            this.txt_p_id.Location = new System.Drawing.Point(202, 229);
            this.txt_p_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_p_id.Multiline = true;
            this.txt_p_id.Name = "txt_p_id";
            this.txt_p_id.Size = new System.Drawing.Size(354, 38);
            this.txt_p_id.TabIndex = 69;
            this.txt_p_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_patients_name
            // 
            this.txt_patients_name.AccessibleName = "";
            this.txt_patients_name.Location = new System.Drawing.Point(202, 168);
            this.txt_patients_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_patients_name.Multiline = true;
            this.txt_patients_name.Name = "txt_patients_name";
            this.txt_patients_name.Size = new System.Drawing.Size(354, 32);
            this.txt_patients_name.TabIndex = 68;
            this.txt_patients_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_hospital_management
            // 
            this.lbl_hospital_management.AutoSize = true;
            this.lbl_hospital_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hospital_management.Location = new System.Drawing.Point(320, 14);
            this.lbl_hospital_management.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hospital_management.Name = "lbl_hospital_management";
            this.lbl_hospital_management.Size = new System.Drawing.Size(592, 64);
            this.lbl_hospital_management.TabIndex = 67;
            this.lbl_hospital_management.Text = "Hospital Management";
            // 
            // txt_p_address
            // 
            this.txt_p_address.AccessibleName = "";
            this.txt_p_address.Location = new System.Drawing.Point(202, 378);
            this.txt_p_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_p_address.Multiline = true;
            this.txt_p_address.Name = "txt_p_address";
            this.txt_p_address.Size = new System.Drawing.Size(354, 36);
            this.txt_p_address.TabIndex = 77;
            this.txt_p_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker_patients
            // 
            this.dateTimePicker_patients.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_patients.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_patients.Location = new System.Drawing.Point(202, 529);
            this.dateTimePicker_patients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_patients.Name = "dateTimePicker_patients";
            this.dateTimePicker_patients.Size = new System.Drawing.Size(354, 30);
            this.dateTimePicker_patients.TabIndex = 81;
            this.dateTimePicker_patients.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtn_male.Location = new System.Drawing.Point(202, 462);
            this.rbtn_male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(68, 24);
            this.rbtn_male.TabIndex = 82;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = false;
            this.rbtn_male.CheckedChanged += new System.EventHandler(this.rbtn_male_CheckedChanged);
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtn_female.Location = new System.Drawing.Point(316, 460);
            this.rbtn_female.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(87, 24);
            this.rbtn_female.TabIndex = 83;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = false;
            this.rbtn_female.CheckedChanged += new System.EventHandler(this.rbtn_female_CheckedChanged);
            // 
            // txt_blood_group
            // 
            this.txt_blood_group.FormattingEnabled = true;
            this.txt_blood_group.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "O-",
            "B-",
            "A-",
            "AB-"});
            this.txt_blood_group.Location = new System.Drawing.Point(202, 612);
            this.txt_blood_group.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_blood_group.Name = "txt_blood_group";
            this.txt_blood_group.Size = new System.Drawing.Size(354, 28);
            this.txt_blood_group.TabIndex = 84;
            this.txt_blood_group.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_major_d
            // 
            this.txt_major_d.AccessibleName = "";
            this.txt_major_d.Location = new System.Drawing.Point(202, 680);
            this.txt_major_d.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_major_d.Multiline = true;
            this.txt_major_d.Name = "txt_major_d";
            this.txt_major_d.Size = new System.Drawing.Size(354, 36);
            this.txt_major_d.TabIndex = 85;
            this.txt_major_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_p_show
            // 
            this.btn_p_show.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_p_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_p_show.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_p_show.Location = new System.Drawing.Point(68, 875);
            this.btn_p_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_p_show.Name = "btn_p_show";
            this.btn_p_show.Size = new System.Drawing.Size(126, 58);
            this.btn_p_show.TabIndex = 86;
            this.btn_p_show.Text = "Show";
            this.btn_p_show.UseVisualStyleBackColor = false;
            this.btn_p_show.Click += new System.EventHandler(this.btn_p_show_Click);
            // 
            // dataGridView_p
            // 
            this.dataGridView_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_p.Location = new System.Drawing.Point(587, 168);
            this.dataGridView_p.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_p.Name = "dataGridView_p";
            this.dataGridView_p.RowHeadersWidth = 62;
            this.dataGridView_p.Size = new System.Drawing.Size(774, 453);
            this.dataGridView_p.TabIndex = 87;
            // 
            // lbl_p_name
            // 
            this.lbl_p_name.AutoSize = true;
            this.lbl_p_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_p_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_name.Location = new System.Drawing.Point(26, 168);
            this.lbl_p_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_name.Name = "lbl_p_name";
            this.lbl_p_name.Size = new System.Drawing.Size(115, 33);
            this.lbl_p_name.TabIndex = 88;
            this.lbl_p_name.Text = "Name :";
            // 
            // lbl_p_id
            // 
            this.lbl_p_id.AutoSize = true;
            this.lbl_p_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_p_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_id.Location = new System.Drawing.Point(34, 229);
            this.lbl_p_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_id.Name = "lbl_p_id";
            this.lbl_p_id.Size = new System.Drawing.Size(73, 33);
            this.lbl_p_id.TabIndex = 89;
            this.lbl_p_id.Text = "ID  :";
            // 
            // lbl_p_phn
            // 
            this.lbl_p_phn.AutoSize = true;
            this.lbl_p_phn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_p_phn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_phn.Location = new System.Drawing.Point(30, 303);
            this.lbl_p_phn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_phn.Name = "lbl_p_phn";
            this.lbl_p_phn.Size = new System.Drawing.Size(121, 33);
            this.lbl_p_phn.TabIndex = 90;
            this.lbl_p_phn.Text = "Phone :";
            // 
            // lbl_p_add
            // 
            this.lbl_p_add.AutoSize = true;
            this.lbl_p_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_p_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_add.Location = new System.Drawing.Point(16, 380);
            this.lbl_p_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_add.Name = "lbl_p_add";
            this.lbl_p_add.Size = new System.Drawing.Size(147, 33);
            this.lbl_p_add.TabIndex = 91;
            this.lbl_p_add.Text = "Address :";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(16, 460);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(136, 33);
            this.lbl_gender.TabIndex = 92;
            this.lbl_gender.Text = "Gender :";
            // 
            // lbl_p_date
            // 
            this.lbl_p_date.AutoSize = true;
            this.lbl_p_date.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_p_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p_date.Location = new System.Drawing.Point(34, 529);
            this.lbl_p_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p_date.Name = "lbl_p_date";
            this.lbl_p_date.Size = new System.Drawing.Size(107, 33);
            this.lbl_p_date.TabIndex = 93;
            this.lbl_p_date.Text = "Date  :";
            // 
            // lbl_blood
            // 
            this.lbl_blood.AutoSize = true;
            this.lbl_blood.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_blood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blood.Location = new System.Drawing.Point(16, 609);
            this.lbl_blood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_blood.Name = "lbl_blood";
            this.lbl_blood.Size = new System.Drawing.Size(171, 29);
            this.lbl_blood.TabIndex = 94;
            this.lbl_blood.Text = "Blood group :";
            // 
            // lbl_diease
            // 
            this.lbl_diease.AutoSize = true;
            this.lbl_diease.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_diease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diease.Location = new System.Drawing.Point(3, 691);
            this.lbl_diease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_diease.Name = "lbl_diease";
            this.lbl_diease.Size = new System.Drawing.Size(195, 29);
            this.lbl_diease.TabIndex = 95;
            this.lbl_diease.Text = "Major Disease :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(953, 930);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // form_patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1461, 1003);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_diease);
            this.Controls.Add(this.lbl_blood);
            this.Controls.Add(this.lbl_p_date);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_p_add);
            this.Controls.Add(this.lbl_p_phn);
            this.Controls.Add(this.lbl_p_id);
            this.Controls.Add(this.lbl_p_name);
            this.Controls.Add(this.dataGridView_p);
            this.Controls.Add(this.btn_p_show);
            this.Controls.Add(this.txt_major_d);
            this.Controls.Add(this.txt_blood_group);
            this.Controls.Add(this.rbtn_female);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.dateTimePicker_patients);
            this.Controls.Add(this.txt_p_address);
            this.Controls.Add(this.lbl_patients);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_p_phn);
            this.Controls.Add(this.txt_p_id);
            this.Controls.Add(this.txt_patients_name);
            this.Controls.Add(this.lbl_hospital_management);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.form_patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_patients;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_p_phn;
        private System.Windows.Forms.TextBox txt_p_id;
        private System.Windows.Forms.TextBox txt_patients_name;
        private System.Windows.Forms.Label lbl_hospital_management;
        private System.Windows.Forms.TextBox txt_p_address;
        private System.Windows.Forms.DateTimePicker dateTimePicker_patients;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.ComboBox txt_blood_group;
        private System.Windows.Forms.TextBox txt_major_d;
        private System.Windows.Forms.Button btn_p_show;
        private System.Windows.Forms.DataGridView dataGridView_p;
        private System.Windows.Forms.Label lbl_p_name;
        private System.Windows.Forms.Label lbl_p_id;
        private System.Windows.Forms.Label lbl_p_phn;
        private System.Windows.Forms.Label lbl_p_add;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_p_date;
        private System.Windows.Forms.Label lbl_blood;
        private System.Windows.Forms.Label lbl_diease;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}