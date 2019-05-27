using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CakeClasses;

namespace Lab3_OrderCake_The_Bakery_
{
    public partial class frmPlaceOrder : Form
    {
        public static Order cakeOrder;
        frmOrderCake order;
        public frmPlaceOrder()
        {
            InitializeComponent();
            cakeOrder = new Order();
            order = new frmOrderCake();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //make sure customer information is entered, if not, error message and return
            if (txtFName.Text == "" || txtLName.Text == "" || txtStreet.Text == string.Empty)
            {
                MessageBox.Show("Please enter information", "Data Missing");
                txtFName.Focus();
                return;
            }

            //cakeOrder.Customer.FirstName = txtFName.Text;
            //cakeOrder.Customer.LastName = txtLName.Text;
            cakeOrder.Customer = new Customer(txtFName.Text, txtLName.Text);
            cakeOrder.Customer.Address = new Address(txtStreet.Text, txtCity.Text, txtProvince.Text, txtPCode.Text);
            //put selected mailings into customer
            //clear anything that's there already first
            cakeOrder.Customer.Mailings.Clear();
            for (var intCount = 0; intCount < clbMailing.Items.Count; intCount++)
            {
                if (clbMailing.GetItemChecked(intCount))
                {
                    cakeOrder.Customer.Mailings.Add(clbMailing.Items[intCount].ToString());
                }
            }
            order.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to start a new customer and order?", "New?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch (dialogResult)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    cakeOrder = new Order();
                    txtStreet.Text = string.Empty;
                    txtFName.Text = string.Empty;
                    txtLName.Text = string.Empty;
                    txtCity.Text = string.Empty;
                    txtPCode.Text = string.Empty;
                    txtProvince.Text = string.Empty;
                    int intList = 0;
                    clbMailing.ClearSelected();
                    for (var intCount = 1; intCount <= clbMailing.Items.Count; intCount++)
                    {
                        clbMailing.SetItemChecked(intList, false);
                        intList += 1;
                    }
                    break;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
