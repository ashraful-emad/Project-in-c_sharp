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
    public partial class form_patients : Form
    {
        public form_patients()
        {
            InitializeComponent();
        }
        string gender;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-V52DA43P;Initial Catalog=HMS;Integrated Security=True");
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_after_login().Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into patients  (NAME,ID,PHONE,Address,Gender,Date,Blood_group,Disease) values('" + txt_patients_name.Text + "','" + txt_p_id.Text + "','" + txt_p_phn.Text + "','" + txt_p_address.Text + "','" + gender + "','" +DateTime.Now.ToString("yyyy-MM-dd")  + "','" + txt_blood_group.Text + "','" + txt_major_d.Text + "')", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Inserted successfully");
            }
        }

        private void form_patients_Load(object sender, EventArgs e)
        {

        }

        private void btn_p_show_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from patients", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView_p.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from patients where ID='" + txt_p_id.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update patients set Name ='" + txt_patients_name.Text + "', PHONE  ='" + txt_p_phn.Text + "', Address ='" + txt_p_address.Text + "', Gender ='" + gender + "', Date ='" + DateTime.Now.ToString("dd-mm-yyyy") + "', Blood_group ='" + txt_blood_group.Text + "', Disease ='" + txt_major_d.Text + "' where ID='" + txt_p_id.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("updated successfully");
            }
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
