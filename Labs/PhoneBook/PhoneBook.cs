using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class PhoneBook : Form
    {
        string name, mobile, address, image = "";
        string source;
        string destination = Directory.GetCurrentDirectory();
        const int TOTAL_CONTACT = 100; //constant
        Contact[] ct = new Contact[TOTAL_CONTACT];
        int i = 0;
        int index = 0;
        public PhoneBook()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            mobile = tbMobile.Text;
            address = tbAddress.Text;
            if (name != "" && mobile != "")
            {
                lbContact.Items.Add(name);
                ct[i] = new Contact(name, mobile,address,image);
                i++;
                tbName.Text = "";
                tbMobile.Text = "";
                tbAddress.Text = "";
            }
            else
            {
                MessageBox.Show("You must input all information");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbMobile.Enabled = true;
            tbName.Enabled = true;
            tbAddress.Enabled = true;
            pbAvatar.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                index = lbContact.SelectedIndex;
                ct[index].Name = tbName.Text;
                ct[index].Mobile = tbMobile.Text;
                ct[index].Address = tbAddress.Text;
                ct[index].Image = image;
                lbContact.Items[index] = tbName.Text;
            }
            catch (IndexOutOfRangeException) { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Enabled = true;
            tbMobile.Enabled = true;
            tbAddress.Enabled = true;
            pbAvatar.Enabled = true;
            tbName.Text = "";
            tbMobile.Text = "";
            tbAddress.Text = "";
            pbAvatar.Image = null;
            image = "";
        }

        private void lbContact_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tbName.Enabled = false;
                tbMobile.Enabled = false;
                tbAddress.Enabled = false;
                pbAvatar.Enabled = false;
                index = lbContact.SelectedIndex;
                tbName.Text = ct[index].Name;
                tbMobile.Text = ct[index].Mobile;
                tbAddress.Text = ct[index].Address;
                pbAvatar.Image = Image.FromFile(Path.Combine(destination, ct[index].Image));
            }
            catch (Exception) { }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbContact.SelectedIndex;
                lbContact.Items.RemoveAt(index);
                btnClear_Click(sender, e);
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void PhoneBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PhoneBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if there is at least 1 contact from listbox => ask to save, otherwise ignore
            if (lbContact.Items.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Do you want to save data?", "Save file", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (StreamWriter writer = new StreamWriter("phonebook.txt"))
                    {
                        for (int j = 0; j < i; j++)
                        {
                            writer.WriteLine("CONTACT " + (j + 1));
                            writer.WriteLine("Name: " + ct[j].Name);
                            writer.WriteLine("Mobile: " + ct[j].Mobile);
                            writer.WriteLine("Address: " + ct[j].Address);
                            writer.WriteLine("Image: " + ct[j].Image);
                            writer.WriteLine("-----------------");
                        }
                    }
                    //MessageBox.Show("Save data successfully !");
                }
                else if (result == DialogResult.No)
                {
                    //MessageBox.Show("Goodbye !");
                }
            }   
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                //open a file dialog to select file
                OpenFileDialog ofd = new OpenFileDialog();
                //filter the image file
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    pbAvatar.Image = new Bitmap(ofd.FileName);
                    // get image's orignal source  
                    source = Path.GetDirectoryName(ofd.FileName);
                    // get image's name
                    image = Path.GetFileName(ofd.FileName);
                    // copy image to new destination
                    //note: set "true" for "overwrite"
                    File.Copy(Path.Combine(source, image), Path.Combine(destination, image));
                }
            }
            catch (Exception) { }
        }
    }
}
