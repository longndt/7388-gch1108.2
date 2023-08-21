using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Registration : Form
    {
        //khởi tạo biến global
        //note: nên sử dụng biến global nếu biến này được sử dụng ở nhiều method
        object subject;

        ArrayList registration_detail = new ArrayList();

        //có thể khởi tạo string[] hoặc ArrayList hoặc List<string> để lưu danh sách subject
        string[] subject_list = { "Programming", "Networking", "Security", "Web Design", "Artificial Intelligence" }; 
        //List<string> subject_list1 = new List<string>();
        //ArrayList subject_list2 = new ArrayList();

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //ẩn form registration
            this.Hide();
            //tạo 1 instance của form login
            Login login = new Login();
            //show form login
            login.Show();
        }

        //chuyển các subject đã chọn từ Available sang Selected
        private void BtnRight_Click(object sender, EventArgs e)
        {
            /*kiểm tra người dùng đã chọn subject hay chưa trước khi Add
            Cách 1: check lỗi bằng if ... else */
            if (lbAvailable.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a subject first !");
            }
            else
            {
                //Bước 1: thêm subject để chuyển từ danh sách Available sang Selected
                subject = lbAvailable.SelectedItem;
                lbSelected.Items.Add(subject);
                //Bước 2: xóa subject khỏi danh sách Available
                //Cách 1: xóa theo object (item)
                lbAvailable.Items.Remove(subject);
                //Cách 2: xóa theo index  
                 /*       int index = lbAvailable.SelectedIndex;
                          lbAvailable.Items.RemoveAt(index);
                 */
            }
        }

        //chuyển các subject đã chọn từ Selected sang Available
        private void BtnLeft_Click(object sender, EventArgs e)
        {
            //cách 2: check lỗi bằng try ... catch (recommended)
            //note: test thử chương trình, nếu có lỗi gì thì catch đúng lỗi đấy
            try
            {
                subject = lbSelected.SelectedItem;
                lbAvailable.Items.Add(subject);
                lbSelected.Items.Remove(subject);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("You must select subject first !");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //check xem đã điền đủ thông tin hay chưa trước khi Add
            if (tbName.Text == "" || tbID.Text == "" || 
                cbSemester.SelectedIndex < 0 || dtpBirthday.Value.ToString() == "" || lbSelected.Items.Count == 1)
            {
                MessageBox.Show("You must input all information first !");
            }
            else
            {
                //tạo các biến string để lưu từng thông tin riêng biệt
                string name = "Name: " + tbName.Text + "\n";
                string id = "ID: " + tbID.Text + "\n";
                string birthday = "Birthday: " + dtpBirthday.Value.ToString("dd/mm/yyyy") + "\n";
                string semester = "Semester: " + cbSemester.Text + "\n";
                //lưu thông tin của Selected subject
                string subject = "Subjects: ";
                //cách 1: dùng vòng lặp foreach
                int last_index = lbSelected.Items.Count - 1;
                foreach (object sub in lbSelected.Items)
                {
                    //nếu object hiện tại là last index thì không có dấu phẩy
                    if (sub == lbSelected.Items[last_index])
                        subject = subject + sub.ToString();
                    else //ngược lại bố sung thêm dấu phẩy
                        subject = subject + sub.ToString() + ", ";
                }
                //cách 2: dùng vòng lặp for
                //int total = lbSelected.Items.Count;
                //int last_index = total - 1;
                //int i;
                //for (i=0;i<total;i++)
                //{
                //    //nếu đây là object cuối cùng thì không thêm dấu phẩy
                //    if (i == last_index)
                //        subject = subject + lbSelected.Items[i];
                //    //ngược lại thì bổ sung dấu phẩy (để phân chia)
                //    else
                //        subject = subject + lbSelected.Items[i] + ", ";
                //}

                //lưu thông tin vào ListBox
                lbList.Items.Add(tbName.Text + " - " + tbID.Text);
                //lưu thông tin vào ArrayList
                registration_detail.Add(name + id + birthday + semester + subject);           
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbID.Text = "";
            //cbSemester.SelectedIndex = -1;
            cbSemester.Text = "";
            dtpBirthday.Value = DateTime.Parse("01/01/2000");
            rtbInformation.Text = "";
            //reset lại danh sách Available Subject     
            //cách 1: xóa hết và add lại từ đầu
            lbAvailable.Items.Clear();
            lbSelected.Items.Clear();
            //cách A: add từ string[] đã khai báo ở trên
            for (int i = 0; i < 5; i++)
            {
                lbAvailable.Items.Add(subject_list[i]);
            }
            //cách B: add range tất cả các item 
            //lbAvailable.Items.AddRange(new object[] {
            //"Programming","Networking","Security","Web Design","Artifical Intelligence"});

            //cách 2: đẩy tất cả các selected subject (nếu có) về bên kia
            //xóa list của Selected và thêm vào list của Available

            /*         try
                     {
                         foreach (object subject in lbSelected.Items)
                         {
                             lbAvailable.Items.Add(subject);
                             lbSelected.Items.Remove(subject);
                         }
                     } catch (InvalidOperationException) { }
            */
        }

        private void LbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //lấy ra index của list box
                int index = lbList.SelectedIndex;
                //hiển thị thông tin trên rich text box
                rtbInformation.Text = registration_detail[index].ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
            } 
        }

   

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                    // tìm index trong list box cần xóa
                    int index = lbList.SelectedIndex;
                    // xóa item trong list box Registration List dựa theo index
                    lbList.Items.RemoveAt(index);
                    // xóa item trong array list Registration Detail
                    registration_detail.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void lbAvailable_DoubleClick(object sender, EventArgs e)
        {
            //double click vào môn học để xem thông tin của môn học đấy
            string subject1 = lbAvailable.SelectedItem.ToString();
            switch (subject1)
            {
                case "Programming":
                    MessageBox.Show("Programming is the process of creating " +
                        "a set of instructions that tell a computer how to " +
                        "perform a task. Programming can be done using a " +
                        "variety of computer programming languages, such as " +
                        "JavaScript, Python, and C++.");
                    break;
                case "Networking":
                    MessageBox.Show("Networking is the exchange of information and ideas among people with a common profession or special interest, usually in an informal social setting");
                    break;
                //những môn học khác làm tương tự
                default:
                    break;
            }
        }
    }
}
