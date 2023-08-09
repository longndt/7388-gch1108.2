using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hiển thị popup dialog
            MessageBox.Show("Welcome to Greenwich Vietnam !");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //thay đổi màu text sau khi đã click vào link
            linkLabel1.LinkVisited = true;

            //mở web browser với đường link set sẵn
            System.Diagnostics.Process.Start("https://greenwich.edu.vn/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Show();
            linkLabel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Hide();
            linkLabel1.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Show();
            linkLabel1.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Hide();
            linkLabel1.Hide();
        }
    }
}
