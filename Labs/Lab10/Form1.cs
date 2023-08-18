using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //set empty value for all labels
            lblName.Text = "";
            lblAge.Text = "";
            lblAddress.Text = "";
         

            //set hide when form starts
            lblContact.Hide();
            lblEmergency.Hide();    
            lblSex.Hide();
            lblErrorSex.Hide();

            //lock input for combo box
            cbbSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //show popup dialog
            /*
            String name = txtName.Text;
            int age = (int)nudAge.Value;
            MessageBox.Show("Hello " + name + ". You are " + age + " year old now !");
            */

            //step 1: get value from text box (input)
            String name = txtName.Text;
            //step 2: display value to defined label (output)
            lblName.Text = name;

            int age = (int)nudAge.Value;    
            lblAge.Text = age.ToString();

            lblAddress.Text = txtAddress.Text;

            lblContact.Show();
            lblContact.Text = txtContact.Text;  

            lblEmergency.Show();
            lblEmergency.Text = txtEmergency.Text;

            if (checkSex())
            {
                lblSex.Show();
                lblErrorSex.Hide();
                lblSex.Text = cbbSex.SelectedItem.ToString();
            } else
            {
                //MessageBox.Show("You must select sex first !");
                lblErrorSex.Show();
            }    
        }

        private Boolean checkSex()
        {
            //if (cbbSex.SelectedIndex == 0)
            //    return false;
            //else
            //    return true;

            return (cbbSex.SelectedIndex != 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear input (left-side)
            txtName.Text = "";
            nudAge.Value = 0;
            txtEmergency.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            //cbbSex.SelectedItem = "Select";
            cbbSex.SelectedIndex = 0; //Select


            //clear output (right-side)
            lblAge.Text = "";
            lblName.Text = "";
            lblEmergency.Text = "";
            lblContact.Text = "";
            lblSex.Text = "";
            lblAddress.Text = "";
        }
    }
}
