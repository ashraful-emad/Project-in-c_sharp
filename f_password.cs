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
    public partial class form_f_password : Form
    {
        public form_f_password()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-V52DA43P;Initial Catalog=HMS;Integrated Security=True");
    
        

        private void btn_p_search_Click(object sender, EventArgs e)
        {
            
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update sign_up set Password ='" + txt_reset_password.Text +  "' where ID='" + txt_enter_id.Text + "'", sqlConnection);
                int check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (check > 0)
                {
                    MessageBox.Show("updated successfully");
                }
                else
                {
                    MessageBox.Show("id not matched");
                }
            }
            

            this.Hide();
            new form_login().Show();
        }

        private void txt_enter_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_f_password_Load(object sender, EventArgs e)
        {

        }

        private void txt_human_check_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_human_check.Checked == true)
            {
                btn_p_search.Visible=true;
            }
            else
            {
                btn_p_search.Visible = false;
            }
        }
    }
}
