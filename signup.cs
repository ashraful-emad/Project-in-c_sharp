using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class form_signup : Form
    {
        public form_signup()
        {
            InitializeComponent();
        }
        string gender;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-219589C;Initial Catalog=HMS;Integrated Security=True");
        private void link_lbl_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new form_login().Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into sign_up  (NAME,ID,PHONE_number,Date_of_birth,Address,Gender,Email,Password) values('" + txt_name.Text + "','" + txt_id.Text + "','" + txt_phn_num.Text + "','"+ DateTime.Now.ToString("dd-mm-yyyy") + "','" + txt_address.Text + "','" + gender + "','" +  txt_email.Text + "','" + txt_password.Text + "')", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Inserted successfully");
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_login().Show();
        }

        private void rbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbtn_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
