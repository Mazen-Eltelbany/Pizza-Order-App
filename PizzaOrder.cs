using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class pizzaorder : Form
    {
        public pizzaorder()
        {
            InitializeComponent();
        }
        
        float GetSelectedSizePrice()
        {
            if (rdsmall.Checked)
            {
                return Convert.ToSingle(rdsmall.Tag);
            }
            else if (rdmedium.Checked)
            {
                return Convert.ToSingle(rdmedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rdlarge.Tag);
            }
        }
        float CalculateToppingsPrice()
        {
            float toppingtotalprice = 0;
            if (chcheese.Checked)
            {
                toppingtotalprice += Convert.ToSingle(chcheese.Tag);
            }
            if (cholives.Checked)
            {
                toppingtotalprice += Convert.ToSingle(cholives.Tag);
            }
            if (chonion.Checked)
            {
                toppingtotalprice += Convert.ToSingle(chonion.Tag);
            }
            if (chtomato.Checked)
            {
                toppingtotalprice += Convert.ToSingle(chtomato.Tag);
            }
            if(chmushroom.Checked)
            {
                toppingtotalprice += Convert.ToSingle(chmushroom.Tag);
            }
            if (chpepper.Checked)
            {
                toppingtotalprice += Convert.ToSingle(chpepper.Tag);
            }
            return toppingtotalprice;
        }
        float GetSelectedCrustPrice()
        {
            if (rdthin.Checked)
            {
                return Convert.ToSingle(rdthin.Tag);
            }
            else
            {
                return Convert.ToSingle(rdthick.Tag);
            }
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice()
                + GetSelectedCrustPrice();
        }
        void updatetotalprice()
        {
            totalpricelabel.Text="$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            updatetotalprice();
            if (rdsmall.Checked)
            {
                sizelabel.Text = "Small";
            }
            if (rdmedium.Checked)
            {
                sizelabel.Text = "Medium";
            }
            if (rdlarge.Checked)
            {
                sizelabel.Text = "Large";
            }
        }
        void UpdateCrust()
        {
            updatetotalprice();
            if (rdthin.Checked)
            {
                crustlabel.Text = "Thin Crust";
                return;
            }
            if(rdthick.Checked)
            {
                crustlabel.Text="Thick Crust";
                return;
            }
        }
        void UpdateToppings()
        {
            updatetotalprice();
            string stoppings = "";
            if (chcheese.Checked)
            {
                stoppings += "Extra Cheese";
            }
            if (chonion.Checked)
            {
                stoppings += ", Onion";
            }
            if (cholives.Checked)
            {
                stoppings += ", Olives";
            }
            if (chtomato.Checked)
            {
                stoppings += ", Tomato";
            }
            if (chpepper.Checked)
            {
                stoppings += ", Pepper";
            }
            if (chmushroom.Checked)
            {
                stoppings += ", Mushroom";
            }
            if (stoppings.StartsWith(","))
            {
                stoppings=stoppings.Substring(1,stoppings.Length-1).Trim();
            }
            if (stoppings == "")
            {
                stoppings = "No Toppings";
            }

            toppinglb.Text = stoppings;
        }
        void UpdateWhereToEat()
        {
            updatetotalprice();
            if (rdeatin.Checked)
            {
                wtelabel.Text = "Eat In.";
                return;
            }
            if (rdtakeout.Checked)
            {
                wtelabel.Text = "Take Out.";
                return;
            }
        }
        void updateordersummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            updatetotalprice();
        }
        void ResetForm()
        {
            gbsize.Enabled = true;
            gbcrust.Enabled = true;
            gbtopping.Enabled = true;
            gbwheretoeat.Enabled = true;

            rdmedium.Checked = true;
            chcheese.Checked = false;
            chmushroom.Checked = false;
            chtomato.Checked = false;
            chpepper.Checked = false;
            chonion.Checked = false;
            cholives.Checked = false;
            rdthin.Checked = true;
            rdeatin.Checked = true;
            btnOrder.Enabled = true;
        }
        private void rdsmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdmedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdlarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chcheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chmushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chtomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chonion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cholives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chpepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rdthin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdthick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdeatin_CheckedChanged(object sender, EventArgs e)
        {
            wtelabel.Text = rdeatin.Text;
        }

        private void rdtakeout_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void PizzaMenu_Load(object sender, EventArgs e)
        {
            updateordersummary();
            gbcrust.BackColor = Color.FromArgb(150, 0, 0, 0);
            gbcrust.ForeColor = Color.Gold;
            gbtopping.BackColor = Color.FromArgb(150, 0, 0, 0);
            gbtopping.ForeColor = Color.Gold;
            gbwheretoeat.BackColor = Color.FromArgb(150, 0, 0, 0);
            gbwheretoeat.ForeColor = Color.Gold;
            orderbox.BackColor = Color.FromArgb(150, 0, 0, 0);
            orderbox.ForeColor = Color.Gold;
            gbsize.BackColor = Color.FromArgb(150, 0, 0, 0);
            gbsize.ForeColor = Color.Gold;
            maintitle.BackColor = Color.Transparent;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrder.Enabled = false;
                gbsize.Enabled = false;
                gbcrust.Enabled = false;
                gbtopping.Enabled = false;
                gbwheretoeat.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update your order", "Update",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toppinglb_Click(object sender, EventArgs e)
        {

        }

        private void orderbox_Enter(object sender, EventArgs e)
        {
        }

        private void maintitle_Click(object sender, EventArgs e)
        {

        }
    }
}
