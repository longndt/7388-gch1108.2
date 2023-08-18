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
            lblStaffID.Text = "";
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
            bool check = true;
            //step 1: lấy toàn bộ thông tin từ form
            //name
            String name = "";
            if (tbName.Text != "")
            {
                name = tbName.Text;
            }
            else
            {
                MessageBox.Show("You must enter name");
                check = false;
            }

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
            //validate (check) xem người dùng đã chọn title hay chưa
            String title = "";
            if (cbTitle.SelectedIndex < 0)
            {
                MessageBox.Show("You must select title");
                check = false;
            } else
            {
                title = cbTitle.SelectedItem.ToString();
            }
               
            //gender
            string gender = "";
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";

            //address
            string address = rtbAddress.Text;

            //validate toàn bộ xong thì cho phép Add
            if (check)
            {
                //step 2: tạo object Staff
                Staff staff = new Staff(name, birthday, age, seniority, marriage, title, gender, address, id);

                //step 3A: add staff vừa tạo vào List<Staff>
                staffs.Add(staff);

                //step 3B: add staff name vừa tạo vào List Box
                lbStaffList.Items.Add(name + " - " + id);

                //tăng id cho staff
                number++;
                generate_id();

                //hiển thị popup dialog khi add thành công
                MessageBox.Show("Add new staff succeed !");
            }
         
        }

        private void lbStaffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mục đích: show thông tin của staff đang chọn ở list box để hiển thị ở group box 
            
            //step 1: lấy ra index đang chọn trong list box
            int index = lbStaffList.SelectedIndex;

                //step 2: lấy object có index tương ứng với list box ở List<Staff> staffs
                Staff staff = staffs[index];

                //step 3: đẩy thông tin tương ứng sang group box
                lblStaffID.Text = staff.StaffId;
                lblName.Text = staff.Name;
                lblBirthday.Text = staff.Birthday.ToShortDateString();
                lblSeniority.Text = staff.Seniority.ToString();
                lblAge.Text = staff.Age.ToString();
                lblMarriage.Text = staff.Marriage;
                lblTitle.Text = staff.Title;
                lblGender.Text = staff.Gender;
                lblAddress.Text = staff.Address;
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //sử dụng try ... catch để bắt lỗi
            //kết hợp với MessageBox.Show() để báo lỗi
            //note: chạy thử nếu báo lỗi gì thì catch lỗi đấy
            try
            {
                //tính tổng member trong list box
                int total = lbStaffList.Items.Count;
                if (total > 0)
                {
                    //lấy ra index của staff trong list box
                    int staff_index = lbStaffList.SelectedIndex;
                    //xóa staff dựa theo index
                    //xóa trong tên hiển thị trong listbox
                    lbStaffList.Items.RemoveAt(staff_index);
                    //xóa thông tin chi tiết của nhân viên
                    staffs.RemoveAt(staff_index);
                }
                else
                {
                    MessageBox.Show("There was no staff to delete !");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
             //1) xóa thông tin ở phần input (bên trên)
            //xóa input của textbox Name
            tbName.Text = "";
            //xóa input của datetimepicker Birthday
            //set giá trị về ngày mặc định
            //để set về ngày hôm nay, sử dụng DateTime.Now()
            dtpBirthday.Value = DateTime.Parse("01/01/2000");
            //xóa input của numericupdown Seniority
            //set 1 giá trị random nằm trong khoảng min và max
            nudSeniority.Value = 1;
            //xóa input của checkbox Marriage
            chbMarriage.Checked = false;
            //xóa input của combobox Title
            //index < 0 (VD: -1) vì giá trị đầu tiên trong array là 0
            cbTitle.SelectedIndex = -1; 
            //xóa input của radiobutton Gender
            //kiểm tra button nào đang được chọn thì chuyển về false
            if (rbMale.Checked == true)
                rbMale.Checked = false;
            else if (rbFemale.Checked == true)
                rbFemale.Checked = false;
            //xóa input của richtextbox Address
            rtbAddress.Text = "";

            /*2) xóa thông tin ở phần output (góc phải bên dưới)
            Lưu ý: không xóa ListBox (dùng để lưu thông tin của từng staff) */
            clear_output();
        }
    }
}
