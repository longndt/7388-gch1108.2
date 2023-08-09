using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9C
{
    public partial class LoginForm : Form
    {
        MainForm mainform;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "123456") 
            {
                MessageBox.Show("Login succeed !");
                this.Hide();
                mainform = new MainForm();
                mainform.Show();  //mở form Main
               
            }
            else
            {
                MessageBox.Show("dsadas", "Error");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
    }
}
