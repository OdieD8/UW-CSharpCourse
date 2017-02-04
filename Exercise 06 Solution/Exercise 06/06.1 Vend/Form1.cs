using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using _06._0_Console_As_Library;

namespace _06._1_Vend
{
    public partial class VendingForm : Form
    {
        public VendingForm()
        {
            InitializeComponent();
        }

        private CoinBox mainCoinBox = new CoinBox(new List<Coin> { 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME), 
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER), 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

        private CoinBox tempCoinBox = new CoinBox();
        private PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        private CanRack theRack = new CanRack();

        private void updateInsertedTotal()
        {
            totalInsertedDisplayLabel.Text =
                string.Format("{0:c}", tempCoinBox.ValueOf);
             CoinReturnButton.Enabled = tempCoinBox.ValueOf > 0M;  
        }

        private void putCoinInTempBox(Coin ACoin)
        {
            tempCoinBox.Deposit(ACoin);
            updateInsertedTotal();
            ejectButtonsReset();
        }

        private void ejectButtonsReset()
        {
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal)
            {
                regularEjectButton.Enabled = !theRack.IsEmpty(Flavor.REGULAR);
                orangeEjectButton.Enabled = !theRack.IsEmpty(Flavor.ORANGE);
                lemonEjectButton.Enabled = !theRack.IsEmpty(Flavor.LEMON);
            }
            else
            {
                regularEjectButton.Enabled = false;
                orangeEjectButton.Enabled = false;
                lemonEjectButton.Enabled = false;
            }
        }
 

        private void halfDollarButton_Click(object sender, EventArgs e)
        {
            Coin halfDollar = new Coin(Coin.Denomination.HALFDOLLAR);
            putCoinInTempBox(halfDollar);
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            Coin quarter = new Coin(Coin.Denomination.QUARTER);
            putCoinInTempBox(quarter);
        }

        private void dimeButton_Click(object sender, EventArgs e)
        {
            Coin dime = new Coin(Coin.Denomination.DIME);
            putCoinInTempBox(dime);
        }

        private void nickelButton_Click(object sender, EventArgs e)
        {
            Coin nickel = new Coin(Coin.Denomination.NICKEL);
            putCoinInTempBox(nickel);
        }

        private void regularEjectButton_Click(object sender, EventArgs e)
        {
            ejectCan(Flavor.REGULAR);
        }

        private void orangeEjectButton_Click(object sender, EventArgs e)
        {
            ejectCan(Flavor.ORANGE);
        }

        private void lemonEjectButton_Click(object sender, EventArgs e)
        {
            ejectCan(Flavor.LEMON);
        }

        private void ejectCan(Flavor flavorToBeEjected)
        {
            decimal amountInserted = tempCoinBox.ValueOf;
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal && !theRack.IsEmpty(flavorToBeEjected))
            {
                tempCoinBox.Transfer(mainCoinBox);
                updateInsertedTotal();
                theRack.RemoveACanOf(flavorToBeEjected);
                MessageBox.Show(string.Format("Thanks. Here is your {0} soda.",
                    flavorToBeEjected.ToString()));
                ejectButtonsReset();
                decimal changeDue = amountInserted - sodaPrice.PriceDecimal;
                if (changeDue > 0M && mainCoinBox.CanMakeChange)
                {
                    mainCoinBox.Withdraw(changeDue);
                    MessageBox.Show(string.Format("Here is your {0:c} in change", changeDue));
                }
                ExactChangeLabel.Visible = !mainCoinBox.CanMakeChange;
            }
        }

        private void VendingForm_Load(object sender, EventArgs e)
        {
            pleaseInsertLabel.Text = 
                string.Format("Please Insert {0} cents for a soda",
                sodaPrice.Price); 
            if (!mainCoinBox.CanMakeChange) ExactChangeLabel.Visible = true;
        }

        private void CoinReturnButton_Click(object sender, EventArgs e)
        {
            decimal amountInserted = tempCoinBox.ValueOf;

            if (amountInserted > 0M)
            {
                tempCoinBox.Withdraw(tempCoinBox.ValueOf);
                updateInsertedTotal();
                MessageBox.Show(string.Format(
                    "Here is your {0:c} back", amountInserted));
            }
            
            ejectButtonsReset();

        }

    }
}
