using System;
using System.Windows.Forms;
using CakeClasses;
using Oracle.ManagedDataAccess.Client;
using DatabaseClasses;
namespace Lab3_OrderCake_The_Bakery_
{
	public partial class frmPlaceOrder : Form
    {
        public static Order cakeOrder;
        frmOrderCake order;
		CustomerInformationTable table;
		public frmPlaceOrder()
        {
			table = new CustomerInformationTable();
			
			InitializeComponent();
            cakeOrder = new Order();
            order = new frmOrderCake();
		

		}

		

     private void btnPlaceOrder_Click(object sender, EventArgs e)
		{

			try
			{
				Customer customer = table.GetCustomer(Convert.ToString(txtLName.Text));
			txtFName.Text =customer.FirstName;
			txtStreet.Text=customer.Address.Street ;
				txtCity.Text = customer.Address.City;
				txtProvince.Text = customer.Address.Province;
				txtPCode.Text = customer.Address.PostalCode;
				if (customer.Mailings.Contains("Specials"))
					clbMailing.SetItemChecked(0, true);
				else clbMailing.SetItemChecked(0, false);
				if (customer.Mailings.Contains("Events"))
					clbMailing.SetItemChecked(1, true);
				else clbMailing.SetItemChecked(1, false);
				if (customer.Mailings.Contains("Bookings"))
					clbMailing.SetItemChecked(2, true);
				else clbMailing.SetItemChecked(2, false);
				cakeOrder.Customer = new Customer(txtFName.Text, txtLName.Text);
				   cakeOrder.Customer.Address = new Address(txtStreet.Text, txtCity.Text, txtProvince.Text, txtPCode.Text);
				for (var intCount = 0; intCount < clbMailing.Items.Count; intCount++)
				{
					if (clbMailing.GetItemChecked(intCount)){
						cakeOrder.Customer.Mailings.Add(clbMailing.Items[intCount].ToString());
					} }
				


				order.ShowDialog();

			}
			catch (OracleException objException)
			{
				MessageBox.Show("A problem occurred with the database: " + objException.Message + " Please contact the programmer");
				Close();
			}
			catch (Exception objException)
			{
				if (objException.Message == "Sorry, that record id doesn't exist on the database")
				{
					MessageBox.Show(objException.Message);
					btnExit.PerformClick();
				}
				else
				{
					MessageBox.Show(objException.Message, objException.GetType().ToString());
				}
			
			}
		}
				

		
				private void btnExit_Click_1(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPlaceOrder_Load_1(object sender, EventArgs e)
		{
			
			txtStreet.Enabled = false;
			txtCity.Enabled = false;
			txtProvince.Enabled = false;
			txtPCode.Enabled = false;
			txtPCode.Enabled = false;
			clbMailing.Enabled = false;
			txtFName.Enabled = false;
		}

		

		private void btnClear_Click_1(object sender, EventArgs e)
		{
			
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
					
			}
	}

		
	}
