using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Manager : Form
    {
        //Tạo list để chứa nhiều staff
        List<Staff> staffs = new List<Staff>();

        //tạo biến global cho staff id
        string id;

        //tạo biến global cho id đầu tiên
        int number = 1000;

        public Manager()
        {
            InitializeComponent();
            clear_output();
            generate_id();
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Tắt hoàn toàn ứng dụng khi đóng form
            Application.Exit();
        }

        private void generate_id()
        {
            string text = "FPT";
            id = text + number;
            tbStaffId.Text = id;
        }

        //Tạo hàm để xóa toàn bộ nội dung ở phần output (Staff Information)
        private void clear_output()
        {
            lblName.Text = "";
            lblBirthday.Text = "";
            lblAge.Text = "";
            lblSeniority.Text = "";
            lblMarriage.Text = "";
            lblTitle.Text = "";
            lblGender.Text = "";
            lblAddress.Text = "";
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            //step 1: lấy toàn bộ thông tin từ form
            //name
            String name = tbName.Text;

            //birthday
            DateTime birthday = dtpBirthday.Value.Date;

            //age (năm hiện tại - năm sinh)
            int currentYear = DateTime.Now.Year;  //2023
            int birthYear = dtpBirthday.Value.Year;
            int age = currentYear - birthYear;

            //seniority (thâm niên)
            int seniority = (int)nudSeniority.Value;

            //marriage (tình trạng hôn nhân)
            string marriage;
            if (chbMarriage.Checked)
                marriage = "Married";
            else
                marriage = "Not married";

            //title (chức vụ)
            String title = cbTitle.SelectedItem.ToString();

            //gender
            string gender = "";
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";

            //address
            string address = rtbAddress.Text;

            //step 2: tạo object Staff
            Staff staff = new Staff(name, birthday, age, seniority, marriage, title, gender, address, id);

            //step 3A: add staff vừa tạo vào List<Staff>
            staffs.Add(staff);

            //step 3B: add staff name vừa tạo vào List Box
            lbStaffList.Items.Add(name + " - " + id);

            //tăng id cho staff
            number++;
            generate_id();

        }
    }
}
