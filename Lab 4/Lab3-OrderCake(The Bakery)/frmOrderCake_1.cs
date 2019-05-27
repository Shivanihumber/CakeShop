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
    public partial class frmOrderCake : Form
    {
        public frmOrderCake()
        {
            InitializeComponent();
            lstChooseCake.Enabled = false;
        }

      private void btnReset_Click(object sender, EventArgs e)
        {
            radCustom.Checked = true;
            radChocolate.Checked = true;
            rad1Tier.Checked = true;
            radAnniversary.Checked = true;
            // lstChooseCake.SelectedItems.Clear(); or
            lstChooseCake.ClearSelected();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radCustom_CheckedChanged(object sender, EventArgs e)
        {
            //enable and disable controls based on selection
            //of custom or traditional radio button
            lstChooseCake.Enabled = false;
            grpCustomCake.Enabled = true;
        }

        private void radTraditional_CheckedChanged(object sender, EventArgs e)
        {
            //enable and disable controls based on selection
            //of custom or traditional radio button
            lstChooseCake.Enabled = true;
            grpCustomCake.Enabled = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult dlgMsg;
            dlgMsg = MessageBox.Show(frmPlaceOrder.cakeOrder.ToString(), "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //confirm order
            if (dlgMsg == DialogResult.Yes)
            {
                MessageBox.Show(frmPlaceOrder.cakeOrder.PrintConfirmation());
                frmPlaceOrder.cakeOrder.ClearCakeList();
            }
            else
            {
                MessageBox.Show("The order has not been placed");
            }
            btnReset.Focus();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (radCustom.Checked)
            {
                string flavour, occasion;
                flavour = occasion = "";
                int layers;

                //for flavor
                if (radBanana.Checked)
                    flavour = "Banana";
                else if (radChocolate.Checked)
                    flavour = "Chocolate";
                else if (radVanilla.Checked)
                    flavour = "Vanilla";
            //for cake layers   
            if (rad2Tiers.Checked)
                layers = 2;
            else if (rad3Tiers.Checked)
                layers = 3;
            else
                layers = 1;
            //for occasion type
            if (radGraduation.Checked)
                occasion = radGraduation.Text.TrimStart(new char[] { '&' });
            else if (radWedding.Checked)
                occasion = radWedding.Text.TrimStart(new char[] { '&' });
            else occasion = radAnniversary.Text.TrimStart(new char[] { '&' });
            frmPlaceOrder.cakeOrder.AddCake(flavour, occasion, layers);
            }
            else
            {
                frmPlaceOrder.cakeOrder.AddCake(lstChooseCake.SelectedItem.ToString());
            }
           
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frmPlaceOrder.cakeOrder.ToString());
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            frmPlaceOrder.cakeOrder.ClearCakeList();
        }  
    }
}
