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
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-V52DA43P;Initial Catalog=HMS;Integrated Security=True");
        private void link_lbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new form_signup().Show();
        }

        private void link_lbl_fogotten_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new form_f_password().Show();
        }

        private void btn_sus_Click(object sender, EventArgs e)
        {



            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from sign_up WHERE Id='" + txt_userid.Text.Trim() + "' AND Password ='" + txt_password.Text.Trim() + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            if (dataTable.Rows.Count==1)
            {

                this.Hide();
                new form_after_login().Show();

            }

            else
            {
                MessageBox.Show("Invalid Username or Password ");

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chk_Show_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Show.Checked)
{
                txt_password.UseSystemPasswordChar = true;
            }
else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }
    }
}
