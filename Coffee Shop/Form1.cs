using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void order_Click(object sender, EventArgs e)
        {
            String customerName = customerNameTextBox.Text;
            String customerPhone = customerPhoneNoTextBox.Text;
            String address = addressRichTextBox.Text;

            String coffeeName = coffeeNameComboBox.Text;
            double quantity = Convert.ToDouble(quantityTextBox.Text);

            double price = 0;

            if(coffeeNameComboBox.SelectedIndex  == 0)
            {
                price = 90;
            }
            if(coffeeNameComboBox.SelectedIndex  == 1)
            {
                price = 120;
            }
            if(coffeeNameComboBox.SelectedIndex  == 2)
            {
                price = 150;
            }
            if(coffeeNameComboBox.SelectedIndex  == 3)
            {
                price = 220;
            }
            if(coffeeNameComboBox.SelectedIndex  == 4)
            {
                price = 380;
            }

            double totlaPrice = quantity * price;

            String result = "User Information"
                +"\n---------------------------------------\n"
                + "Customer Name : "+customerName
                +"\nCustomer Phone No : "+customerPhone
                +"\nAddress : "+address
                + "\n---------------------------------------\n"
                + "Coffee Name : "+coffeeName
                +"\nCoffee Price : "+price
                +"\nQuantity : "+quantity
                + "\n---------------------------------------\n"
                + "Total Payable Price : "+totlaPrice;


            MessageBox.Show(result);


            customerNameTextBox.Text = "";
            customerPhoneNoTextBox.Text = "";
            addressRichTextBox.Text = "";
            coffeeNameComboBox.Text = "";
            quantityTextBox.Text = "";
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
