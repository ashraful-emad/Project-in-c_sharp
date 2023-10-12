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
    public partial class form_admin : Form
    {
        public form_admin()
        {
            InitializeComponent();
        }
        string gender;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-V52DA43P;Initial Catalog=HMS;Integrated Security=True");
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_after_login().Show();
        }

        private void btn_ad_show_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from sign_up", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView_admin.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void  btn_a_modify_Click (object sender, EventArgs e)
        {



            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update sign_up set Name ='" + txt_ad_name.Text + "', PHONE_number  ='" + txt__ad_phn_num.Text + "', Date_of_birth ='" + DateTime.Now.ToString("dd-mm-yyyy") + "', Address ='" + txt_ad_address.Text + "', Gender ='" + gender + "', Email  ='" + txt_ad_email.Text + "', Password ='" + txt_ad_password.Text + "' where ID='" + txt_ad_id.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("updated successfully");
            }
        }

        private void rbtn__ad_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbtn_ad_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btn_ad_dlt_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from sign_up where ID='" + txt_ad_id.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
        }
    }
}
