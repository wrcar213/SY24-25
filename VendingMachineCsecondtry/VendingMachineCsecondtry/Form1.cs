using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineCsecondtry
{
    public partial class Form1 : Form
    {
        private decimal totalAmount = 0;
        private string selectedProductName;
        private decimal selectedProductPrice;
        private CoinSlot coinSlot;
        public Form1()
        {
            InitializeComponent();
            coinSlot = new CoinSlot();

        }
        private void showProduct(string productName, decimal price)
        {
            selectedProductName = productName;
            selectedProductPrice = price;
            lblProductName.Text = productName;
            lblProductPrice.Text = price.ToString("C");
        }

        //Display Product Name And Price
        private void btnProduct1_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 1", 2.25m);
        }

        private void btnProduct2_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 2", 1.50m);
        }

        private void btnProduct3_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 3", 0.75m);
        }

        private void btnProduct4_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 4", 2.25m);
        }

        private void btnProduct5_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 5", 0.25m);
        }

        private void btnProduct6_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 6", 3.50m);
        }

        private void btnProduct7_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 7", 1.25m);
        }

        private void btnProduct8_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 8", 1.75m);
        }

        private void btnProduct9_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 9", 1.00m);
        }

        private void btnProduct10_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 10", 3.00m);
        }

        private void btnProduct11_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 11", 2.75m);
        }

        private void btnProduct12_Click(object sender, EventArgs e)
        {
            showProduct("Vending Machine 12", 3.75m);
        }

        //Money Coin Code
        private void btnNickles_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("nickel");
            UpdateTotalLabel();
        }

        private void btnDimes_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("dime");
            UpdateTotalLabel();
        }

        private void btnQuarters_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("quarter");
            UpdateTotalLabel();
        }

        private void btnDollars_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("dollar");
            UpdateTotalLabel();
        }

        //Update Money Label
        private void UpdateTotalLabel()
        {
            lblTotalAmount.Text = coinSlot.Total().ToString("C");
        }

        //PUrchase the Item and Display you Purchased It
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProductName))
            {
                lblPurchaseMessage.Text = "Please select a product.";
                return;
            }

            if ((decimal)coinSlot.Total() >= selectedProductPrice)
            {
                coinSlot.CoinReturn(); // Clear the coin slot after purchase
                lblTotalAmount.Text = coinSlot.Total().ToString("C");
                lblPurchaseMessage.Text = $"You purchased {selectedProductName}!";

                // Hide the purchased product

                // Optionally reset the product selection
                selectedProductName = null;
                selectedProductPrice = 0;
                lblProductName.Text = "";
                lblProductPrice.Text = "";
            }
            else
            {
                lblPurchaseMessage.Text = "Not enough money deposited.";
            }
        }
    }
}