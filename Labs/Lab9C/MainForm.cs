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
    public partial class MainForm : Form
    {
        LoginForm loginForm;
        public MainForm()
        {
            InitializeComponent();
            txtUniversity.Text = "Greenwich Vietnam";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get input from WinForm
            string name = txtName.Text;
            
            string birthday = dtpBirthday.Value.ToShortDateString();   //=> Ngày tháng năm
            //string birthday = dtpBirthday.Text;                        => Thứ + Ngày tháng năm
            double gpa = (double)nudGPA.Value;
            
            string university = txtUniversity.Text;
            
            string description = txtDescription.Text;

            string gender = "";
            if (rbMale.Checked == true)
                gender = "Male";
            else if (rbFemale.Checked == true)
                gender = "Female";

            string department = cbDepartment.SelectedItem.ToString();

            bool bestStudent = ckbBestStudent.Checked;
            
            //display output to MessageBox
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + name + "\n");
            sb.Append("Birthday: " + birthday + "\n");
            sb.Append("GPA: " + gpa + "\n");
            sb.Append("University: " + university + "\n");
            sb.Append("Gender: " + gender + "\n");
            sb.Append("Department: " + department + "\n");
            sb.Append("Description: " + description + "\n");
            if (bestStudent == true)
                sb.Append("Best student");
            MessageBox.Show(sb.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            dtpBirthday.Value = DateTime.Now;
            nudGPA.Value = 0;
            if (rbMale.Checked)
                 rbMale.Checked = false;
            else if (rbFemale.Checked)
                 rbFemale.Checked = false;
            cbDepartment.SelectedIndex = 0;
            ckbBestStudent.Checked = false;
            txtDescription.Text = "";
        }

        private void btnVietnamese_Click(object sender, EventArgs e)
        {
            lblName.Text = "Họ tên";
            lblBirthday.Text = "Ngày sinh";
            lblGender.Text = "Giới tính";
            lblGPA.Text = "Điểm";
            lblUniversity.Text = "Trường";
            lblDescription.Text = "Giới thiệu";
            rbMale.Text = "Nam";
            rbFemale.Text = "Nữ";
            lblBestStudent.Text = "SV xuất sắc";
            btnAdd.Text = "Thêm";
            btnClear.Text = "Xóa";
            lblAdd.Text = "Thêm SV mới";
            lblDepartment.Text = "Bộ môn";
            cbDepartment.Items.Clear();
            cbDepartment.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Thiết kế đồ họa",
            "Quản trị kinh doanh"});
            btnLogout.Text = "THOÁT";
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            lblName.Text = "Name";
            lblBirthday.Text = "Birthday";
            lblGender.Text = "Gender";
            lblGPA.Text = "GPA";
            lblUniversity.Text = "University";
            lblDescription.Text = "Description";
            rbMale.Text = "Male";
            rbFemale.Text = "Female";
            lblBestStudent.Text = "Best student";
            btnAdd.Text = "Add";
            lblAdd.Text = "Add new student";
            btnClear.Text = "Clear";
            lblDepartment.Text = "Department";
            cbDepartment.Items.Clear();
            cbDepartment.Items.AddRange(new object[] {
            "Computing",
            "Graphic Design",
            "Business"});
            btnLogout.Text = "LOGOUT";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnChangeBackground_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
        }
    }
}
