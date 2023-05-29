using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midnightCafe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Customer_Name = txtCustomerName.Text;
            string Contact_Number = txtContactNum.Text;

            lbCustomersOrder.Items.Add("Customer");
            lbCustomersOrder.Items.Add("\t" + "Name : " + Customer_Name);
            lbCustomersOrder.Items.Add("\t" + "Contact Number : " + Contact_Number);
            lbCustomersOrder.Items.Add("\t" + "Mode of Payment : " + cmbModofPayment.SelectedItem);
            lbCustomersOrder.Items.Add("\n" + " ALL ORDERS ");

            if (cbOkinawa.Checked)
            {
                lbCustomersOrder.Items.Add("Okinawa : " + " " + "120");
            }
            if (cbWintermelon.Checked)
            {
                lbCustomersOrder.Items.Add("Wintermelon : " + " " + "110");
            }
            if (cbDarkChocoMilktea.Checked)
            {
                lbCustomersOrder.Items.Add("Dark Choco : " + " " + "115");
            }
            if (cbBobohClassic.Checked)
            {
                lbCustomersOrder.Items.Add("Boboh Classic : " + " " + "110");
            }
            if (cbTaro.Checked)
            {
                lbCustomersOrder.Items.Add("Taro : " + " " + "120");
            }
            if (cbMatcha.Checked)
            {
                lbCustomersOrder.Items.Add("Matcha : " + " " + "120");
            }
            if (cbCaffeLatte.Checked)
            {
                lbCustomersOrder.Items.Add("Caffe Latte : " + " " + "140");
            }
            if (cbCappucinoLatte.Checked)
            {
                lbCustomersOrder.Items.Add("Cappucino Latte : " + " " + "125");
            }
            if (cbSpanishLatte.Checked)
            {
                lbCustomersOrder.Items.Add("Spanish Latte : " + " " + "120");
            }
            if (cbDarkMochaLatte.Checked)
            {
                lbCustomersOrder.Items.Add("Dark Mocha Latte : " + " " + "110");
            }
            if (cbVanillaBeanLatte.Checked)
            {
                lbCustomersOrder.Items.Add("Vanilla Bean Latte : " + " " + "110");
            }
            if (cbCaramelMacchiatoLatte.Checked)
            {
                lbCustomersOrder.Items.Add("Caramel Macchiato Latte : " + " " + "95");
            }
            else if (rbPearl.Checked)
            {
                lbCustomersOrder.Items.Add("Add-ons : Pearl");
            }
            else if (rbCreampuff.Checked)
            {
                lbCustomersOrder.Items.Add("Add-ons : Creampuff");
            }
            else if (rbCocoJelly.Checked)
            {
                lbCustomersOrder.Items.Add("Add-ons : CocoJelly");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtContactNum.Clear();
            txtCustomerName.Clear();
            cmbModofPayment.Text = null;
            lbCustomersOrder.Items.Clear();
            rbCocoJelly.Checked = false;
            rbCreampuff.Checked = false;
            cbBobohClassic.Checked = false;
            cbCaffeLatte.Checked = false;
            cbCappucinoLatte.Checked = false;
            cbCaramelMacchiatoLatte.Checked = false;
            cbDarkChocoMilktea.Checked = false;
            cbDarkMochaLatte.Checked = false;
            cbMatcha.Checked = false;
            cbOkinawa.Checked = false;
            cbSpanishLatte.Checked = false;
            cbTaro.Checked = false;
            cbVanillaBeanLatte.Checked = false;
            cbWintermelon.Checked = false;
        }
    }
}
