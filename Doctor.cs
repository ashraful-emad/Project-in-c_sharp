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
    public partial class form_doctor : Form
    {
        public form_doctor()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-V52DA43P;Initial Catalog=HMS;Integrated Security=True");

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_after_login().Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Doctor  (NAME,ID,PHONE_NUMBER,YEAR_OF_EXPERIENCE) values('" + txt_doc_name.Text + "','" + txt_doc_id.Text + "','" + txt_doc_phn.Text + "','" + txt_doc_yoex.Text + "')", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Inserted successfully");
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Doctor set Name ='" + txt_doc_name.Text + "', PHONE_NUMBER  ='" + txt_doc_phn.Text + "', YEAR_OF_EXPERIENCE ='" + txt_doc_yoex.Text +  "' where ID='" + txt_doc_id.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("updated successfully");
            }
        }

        private void btn_doc_show_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Doctor", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView_doc.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Doctor where ID='" + txt_doc_id.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
        }
    }
}
