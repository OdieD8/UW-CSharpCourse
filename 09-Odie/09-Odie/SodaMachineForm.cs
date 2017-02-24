//Exercise 09
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

namespace _09_Odie
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
                orangeButton.Enabled = !sodaRack.IsEmpty(Flavor.ORANGE);
                regularButton.Enabled = !sodaRack.IsEmpty(Flavor.REGULAR);
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

            serviceDisplay();

            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
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
                serviceDisplay();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceDisplay();
            coinBoxCounts();
            snacksList();
        }

        private void serviceDisplay()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.SubItems.Clear();
            }

            int index = 0;
            foreach (Flavor flavor in FlavorOps.AllFlavors)
            {
                listView1.Items[index].SubItems.Add(sodaRack[flavor].ToString());
                index++;
            }
        }

        private void refillButton_Click(object sender, EventArgs e)
        {
            sodaRack.FillTheCanRack();
            serviceDisplay();
        }

        private void coinBoxCounts()
        {
            listView2.Items.Clear();

            foreach (string coin in Enum.GetNames(typeof(Coin.Denomination)))
            {
                ListViewItem item = new ListViewItem(coin);
                int coinCount = box.coinCount(Coin.ConvertStringToEnumeral(coin));
                decimal coinValue = coinCount * Coin.ValueOfCoin(Coin.ConvertStringToEnumeral(coin));
                item.SubItems.Add(coinCount.ToString());
                item.SubItems.Add(string.Format("{0:c}", coinValue));
                listView2.Items.Add(item);
            }
            ListViewItem total = new ListViewItem("TOTAL");
            total.SubItems.Add("");
            total.SubItems.Add(string.Format("{0:c}", box.ValueOf));
            listView2.Items.Add(total);
        }

        private void emptyCoinBox_Click(object sender, EventArgs e)
        {
            box.Withdraw(box.ValueOf);
            coinBoxCounts();
        }

        private void newFormButton_Click(object sender, EventArgs e)
        {
            Notes form = new Notes();
            form.Show();
        }

        FoodLocker foodlocker = new FoodLocker();

        private void snacksList()
        {
            foodlocker.Stock();
            snackListBox.Items.Clear();
            foreach (Snack snack in foodlocker.Store)
            {
                snackListBox.Items.Add(snack.name);
            }
        }

        private void snackListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            snackTextBox.Text = foodlocker.Store[snackListBox.SelectedIndex].ToString();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            snacksList();
        }
    }
}
