namespace GossipDesignPattern.StrategyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Calc
    {
        double total = 0.0d;

        private void btnOk_Click(object sender, EventArgs e)
        {
            double totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);

            total = total + totalPrices;

            lbxList.Items.Add("Price: " + txtPrice.Text + " Quantity: " + txtNum.Text + " Total: " + totalPrices.ToString());

            lblResult.Text = total.ToString();
            
        }
    }
}
