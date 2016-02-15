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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] { "Normal", "20% off", "30% off", "Half Price" });
            cbxType.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double totalPrices = 0d;

            switch(cbxType.SelectedIndex)
            {
                case 0:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
                    break;
                case 1:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.8;
                    break;
                case 2:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.8;
                    break;



            }

             totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);

            total = total + totalPrices;

            lbxList.Items.Add("Price: " + txtPrice.Text + " Quantity: " + txtNum.Text + " Total: " + totalPrices.ToString());

            lblResult.Text = total.ToString();
            
        }
    }
}
