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

namespace Order
{

    public partial class Order : Form
    {
        decimal xs_max = 1150; //money unit: $
        decimal xs = 1050;
        decimal x = 950;
        decimal s10 = 900;
        decimal note_10 = 1100;
        decimal note_10p = 1250;
        decimal money, total, unit_price = 0;
        string order = "";
        ArrayList order_list = new ArrayList();
        public Order()
        {
            InitializeComponent();
        }

        private void lbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check for name of product then set the corresponding unit price
            if (lbProductList.SelectedItem.ToString() == "iPhone X")
                unit_price = x;
            else if (lbProductList.SelectedItem.ToString() == "iPhone XS")
                unit_price = xs;
            else if (lbProductList.SelectedItem.ToString() == "iPhone XS Max")
                unit_price = xs_max;
            else if (lbProductList.SelectedItem.ToString() == "Galaxy S10")
                unit_price = s10;
            else if (lbProductList.SelectedItem.ToString() == "Galaxy Note 10")
                unit_price = note_10;
            else if (lbProductList.SelectedItem.ToString() == "Galaxy Note 10+")
                unit_price = note_10p;
            //calculate the money by this formula
            //product_money = product_price * Product_quantity
            money = unit_price * nudAmount.Value;
            //display the money to textbox
            //money is number so must convert to string
            tbMoney.Text = money.ToString() + "$";      
        }

        private void NudAmount_ValueChanged(object sender, EventArgs e)
        {
            //check whether user choose a product or not
            if (lbProductList.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a product first");
            }
            else //user already choose a product
            {
                //check for name of product then set the corresponding unit price
                if (lbProductList.SelectedItem.ToString() == "iPhone X")
                    unit_price = x;
                else if (lbProductList.SelectedItem.ToString() == "iPhone XS")
                    unit_price = xs;
                else if (lbProductList.SelectedItem.ToString() == "iPhone XS Max")
                    unit_price = xs_max;
                else if (lbProductList.SelectedItem.ToString() == "Galaxy S10")
                    unit_price = s10;
                else if (lbProductList.SelectedItem.ToString() == "Galaxy Note 10")
                    unit_price = note_10;
                else if (lbProductList.SelectedItem.ToString() == "Galaxy Note 10+")
                    unit_price = note_10p;
                //calculate the money by this formula
                //product_money = product_price * Product_quantity
                money = unit_price * nudAmount.Value;
                //display the money to textbox
                //money is number so must convert to string
                tbMoney.Text = money.ToString() + "$";
            }    
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //create variable to get the name of chosen product
            string item = lbProductList.GetItemText(lbProductList.SelectedItem);
            //check if money different from zero before adding to order
            if (money != 0)
            {
                //display the information to the order detail
                order = item + ": " + unit_price + "$ * " + nudAmount.Value + " = " + money + "$" + "\n";
                //add current product money to the total money of current order
                total += money;
                //update the total money in textbox
                tbTotal.Text = total.ToString() + "$";
                //add current order to order detail
                lbOrderDetail.Items.Add(order);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            nudAmount.Value = 0;
            lbOrderDetail.Items.Clear();
            lbProductList.Items.Clear(); 
            tbMoney.Text = "";
            tbTotal.Text = "";
            dtpDateTime.Value = DateTime.Now;
        }

        private void BtnMakeOrder_Click(object sender, EventArgs e)
        {
            String order_detail = "";
            foreach (object item in lbOrderDetail.Items)
            {
                order_detail += item.ToString();
            }

            int count = lbOrderList.Items.Count + 1;
            lblTotalOrder.Text = count.ToString();
            string date = dtpDateTime.Text + "\n";
            lbOrderList.Items.Add(date);
            string date_time = "ORDER DATE: " + dtpDateTime.Value + "\n\n";
            string order_info = "ORDER DETAIL: " + "\n" + order_detail + "\n";
            string total_price = "TOTAL PRICE: " + total + "$";
            order_list.Add(date_time + order_info + total_price);
        }

        private void LbOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbOrderList.SelectedIndex;
            if (index != -1)
                 MessageBox.Show(order_list[index].ToString());
        }

        private void RbIphone_CheckedChanged(object sender, EventArgs e)
        {
            //Clear all items in list box first
            lbProductList.Items.Clear();
            //Add items to list box
            lbProductList.Items.Add("iPhone X");
            lbProductList.Items.Add("iPhone XS");
            lbProductList.Items.Add("iPhone XS Max");
            //Load image from file
            pbProduct.Image = Image.FromFile(@"..\Images\iphone.png");
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            int index = lbOrderList.SelectedIndex;
            int count = lbOrderList.Items.Count;
            if (count == 0)
            {
                MessageBox.Show("There is no order to delete");
            }
            else
            {
                if (index == -1)
                {
                    MessageBox.Show("You must select an order first");
                }
                else
                {
                    lbOrderList.Items.Remove(lbOrderList.SelectedItem);
                    lblTotalOrder.Text = lbOrderList.Items.Count.ToString();
                }
            }
        }

        private void BtnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (lbOrderDetail.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an order detail first");
            }
            else
            {
                lbOrderDetail.Items.RemoveAt(lbOrderDetail.SelectedIndex);
            }
        }

        private void RbSamsung_CheckedChanged(object sender, EventArgs e)
        {
            lbProductList.Items.Clear();
            lbProductList.Items.Add("Galaxy S10");
            lbProductList.Items.Add("Galaxy Note 10");
            lbProductList.Items.Add("Galaxy Note 10+");
            pbProduct.Image = Image.FromFile(@"..\Images\samsung.png");
        }

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
