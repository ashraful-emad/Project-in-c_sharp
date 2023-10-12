
namespace Hospital_management_system
{
    partial class form_hms
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_hospital_management = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnk_lbl_click = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(157, 424);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(307, 20);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to the system..click here to enter\r\n";
            // 
            // lbl_hospital_management
            // 
            this.lbl_hospital_management.AutoSize = true;
            this.lbl_hospital_management.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_hospital_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hospital_management.Location = new System.Drawing.Point(154, 23);
            this.lbl_hospital_management.Name = "lbl_hospital_management";
            this.lbl_hospital_management.Size = new System.Drawing.Size(541, 42);
            this.lbl_hospital_management.TabIndex = 56;
            this.lbl_hospital_management.Text = "Hospital Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(122, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(590, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "“Trust yourself. You know more than you think you do.”";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "â€•Benjamin Spock";
            // 
            // lnk_lbl_click
            // 
            this.lnk_lbl_click.ActiveLinkColor = System.Drawing.Color.White;
            this.lnk_lbl_click.AutoSize = true;
            this.lnk_lbl_click.BackColor = System.Drawing.Color.Transparent;
            this.lnk_lbl_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_lbl_click.Location = new System.Drawing.Point(504, 424);
            this.lnk_lbl_click.Name = "lnk_lbl_click";
            this.lnk_lbl_click.Size = new System.Drawing.Size(46, 20);
            this.lnk_lbl_click.TabIndex = 60;
            this.lnk_lbl_click.TabStop = true;
            this.lnk_lbl_click.Text = "Click ";
            this.lnk_lbl_click.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_lbl_click_LinkClicked);
            // 
            // form_hms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 648);
            this.Controls.Add(this.lnk_lbl_click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_hospital_management);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "form_hms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_hospital_management;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnk_lbl_click;
    }
}