//Exercise 06
//Odie de Moura

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using _06._0_Console_As_Library;

namespace _06_Odie
{
    public partial class vendingMachine : Form
    {
        public vendingMachine()
        {
            InitializeComponent();
        }

        PurchasePrice sodaPrice = new PurchasePrice(0.35m);
        CanRack sodaRack = new CanRack();
        CoinBox box = new CoinBox(new List<Coin> {
            new Coin(Coin.Denomination.NICKEL),
            new Coin(Coin.Denomination.NICKEL),
            new Coin(Coin.Denomination.DIME),
            new Coin(Coin.Denomination.DIME),
            new Coin(Coin.Denomination.QUARTER),
        });

        CoinBox tempBox = new CoinBox();

        private void updateInsertedTotal()
        {
            moneyInserted.Text = string.Format("{0:c}", tempBox.ValueOf);
            returnMoneyButton.Enabled = tempBox.ValueOf > 0M;
        }

        private void addCoin(Coin coin)
        {
            tempBox.Deposit(coin);
            updateInsertedTotal();
            sodaButtonsReset();
        }

        private void sodaButtonsReset()
        {
            if (tempBox.ValueOf >= sodaPrice.PriceDecimal)
            {
                orangeButton.Enabled = !sodaRack.IsEmpty(Flavor.REGULAR);
                regularButton.Enabled = !sodaRack.IsEmpty(Flavor.ORANGE);
                lemonButton.Enabled = !sodaRack.IsEmpty(Flavor.LEMON);
            }
            else
            {
                orangeButton.Enabled = false;
                regularButton.Enabled = false;
                lemonButton.Enabled = false;
            }
        }

        private void vendingMachine_Load(object sender, EventArgs e)
        {
            insertMoney.Text = String.Format($"Please Insert ${sodaPrice.PriceDecimal}");
            if (!box.CanMakeChange) exactChange.Visible = true;
        }

        private void nickelButton_Click(object sender, EventArgs e)
        {
            Coin nickel = new Coin(Coin.Denomination.NICKEL);
            addCoin(nickel);
        }

        private void dimeButton_Click(object sender, EventArgs e)
        {
            Coin dime = new Coin(Coin.Denomination.DIME);
            addCoin(dime);
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            Coin quarter = new Coin(Coin.Denomination.QUARTER);
            addCoin(quarter);
        }

        private void halfdollarButton_Click(object sender, EventArgs e)
        {
            Coin halfdollar = new Coin(Coin.Denomination.HALFDOLLAR);
            addCoin(halfdollar);
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            vendFlavor(Flavor.ORANGE);
        }

        private void regularButton_Click(object sender, EventArgs e)
        {
            vendFlavor(Flavor.REGULAR);
        }

        private void lemonButton_Click(object sender, EventArgs e)
        {
            vendFlavor(Flavor.LEMON);
        }

        private void vendFlavor(Flavor flavor)
        {
            decimal userEnteredAmount = tempBox.ValueOf;
            if (tempBox.ValueOf >= sodaPrice.PriceDecimal && !sodaRack.IsEmpty(flavor))
            {
                tempBox.Transfer(box);
                updateInsertedTotal();
                sodaRack.RemoveACanOf(flavor);
                MessageBox.Show($"Thanks. Here is your {flavor.ToString()} soda");
                sodaButtonsReset();
                decimal change = userEnteredAmount - sodaPrice.PriceDecimal;
                if  (change > 0m && box.CanMakeChange)
                {
                    box.Withdraw(change);
                    MessageBox.Show($"Here is your change of {change.ToString("C", CultureInfo.CurrentCulture)}");
                }
                exactChange.Visible = !box.CanMakeChange;
            }
        }

        private void returnMoneyButton_Click(object sender, EventArgs e)
        {
            decimal amountInserted = tempBox.ValueOf;
            if (amountInserted > 0m)
            {
                tempBox.Withdraw(tempBox.ValueOf);
                updateInsertedTotal();
                MessageBox.Show($"Here is your {amountInserted.ToString("C", CultureInfo.CurrentCulture)}");
            }
            sodaButtonsReset();
        }
    }
}
