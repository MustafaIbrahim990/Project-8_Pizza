using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //----------------------------------------//

        void UpDatePizzaSize()
        {
            UpDateTotalPrice();

            if (rbSmall.Checked)
            {
                lblPizzaSize.Text = "Small.";
                return;
            }

            if (rbMedium.Checked)
            {
                lblPizzaSize.Text = "Medium.";
                return;
            }

            if (rbLarge.Checked)
            {
                lblPizzaSize.Text = "Large.";
                return;
            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpDatePizzaSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpDatePizzaSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpDatePizzaSize();
        }

        //----------------------------------------//

        void UpDateCrustType()
        {
            UpDateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust.";
                return;
            }
            else
            {
                lblCrustType.Text = "Thick Crust.";
                return;
            }
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpDateCrustType();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpDateCrustType();
        }

        //----------------------------------------//

        void UpDateToppings()
        {
            UpDateTotalPrice();

            string sToppings = "";

            if (chbExtraChees.Checked)
            {
                sToppings += "Extra Chees";
            }

            if (chbOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chbMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chbOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chbTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (chbGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lblToppings.Text = sToppings + ".";
        }

        private void chbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        private void chbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpDateToppings();
        }

        //----------------------------------------//

        void UpDateWhereToEat()
        {
            UpDateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In.";
                return;
            }
            else
            {
                lblWhereToEat.Text = "Take Out.";
                return;
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpDateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpDateWhereToEat();
        }

        //----------------------------------------//

        float CalculatePizzaSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
        }

        float CalculateCrustTypePrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }
        }

        float CalculateToppingsPrice()
        {
            float TotalToppingsPrice = 0;

            if (chbExtraChees.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chbExtraChees.Tag);
            }

            if (chbOnion.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chbOnion.Tag);
            }

            if (chbMushrooms.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chbMushrooms.Tag);
            }

            if (chbOlives.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chbOlives.Tag);
            }

            if (chbTomatoes.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chbTomatoes.Tag);
            }

            if (chbGreenPeppers.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chbGreenPeppers.Tag);
            }

            return TotalToppingsPrice;
        }

        float CalculateTotalPrice()
        {
            return CalculatePizzaSizePrice() + CalculateCrustTypePrice() + CalculateToppingsPrice();
        }

        void UpDateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        //----------------------------------------//

        void UpDateOrderSummary()
        {
            UpDatePizzaSize();
            UpDateCrustType();
            UpDateToppings();
            UpDateWhereToEat();
            UpDateTotalPrice();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpDateOrderSummary();
        }

        //----------------------------------------//

        void OrderPizza()
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbPizzaSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            OrderPizza();
        }

        //----------------------------------------//

        void ResetForm()
        {
            if (MessageBox.Show("Reset Form", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                //Reset GroupBox.
                gbPizzaSize.Enabled = true;
                gbCrustType.Enabled = true;
                gbToppings.Enabled = true;
                gbWhereToEat.Enabled = true;

                //Reset Pizza Size.
                rbMedium.Checked = true;

                //Reset Crust Type.
                rbThinCrust.Checked = true;

                //Reset CheckBox.
                chbExtraChees.Checked = false;
                chbOnion.Checked = false;
                chbMushrooms.Checked = false;
                chbOlives.Checked = false;
                chbTomatoes.Checked = false;
                chbGreenPeppers.Checked = false;

                //Reset Wherer To Eat.
                rbEatIn.Checked = true;

                //Reset Order Pizz Button.
                btnOrderPizza.Enabled = true;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //----------------------------------------//
    }
}