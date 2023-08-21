using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Login : Form
    {
        Registration re = new Registration();
        public Login()
        {
            InitializeComponent();

            //press Enter to login
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get input from login form
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            //check empty input
            if (username != "" && password != "")
            {

                if (username == "admin" && password == "123456")
                {
                    //ẩn form login
                    this.Hide();
    
                    //mở form registration
                    Registration re = new Registration();
                    re.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            } 
            else
            {
                MessageBox.Show("You must input both username & password");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //thoát hoàn toàn ứng dụng khi tắt form
            Application.Exit();
        }
    }
}
