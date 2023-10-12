using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class form_after_login : Form
    {
        public form_after_login()
        {
            InitializeComponent();
        }

        private void link_lbl_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new form_login().Show();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_doctor().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_patients().Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_admin().Show();
        }
    }
}
