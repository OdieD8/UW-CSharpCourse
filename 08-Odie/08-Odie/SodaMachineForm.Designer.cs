//Exercise 08
//Odie de Moura

namespace _08_Odie
{
    partial class vendingMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Orange", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Regular", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Lemon", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendingMachine));
            this.insertMoney = new System.Windows.Forms.Label();
            this.exactChange = new System.Windows.Forms.Label();
            this.amountInserted = new System.Windows.Forms.Label();
            this.moneyInserted = new System.Windows.Forms.TextBox();
            this.lemon = new System.Windows.Forms.PictureBox();
            this.regular = new System.Windows.Forms.PictureBox();
            this.orange = new System.Windows.Forms.PictureBox();
            this.returnMoneyButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.regularButton = new System.Windows.Forms.Button();
            this.lemonButton = new System.Windows.Forms.Button();
            this.nickelButton = new System.Windows.Forms.Button();
            this.dimeButton = new System.Windows.Forms.Button();
            this.quarterButton = new System.Windows.Forms.Button();
            this.halfdollarButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.coinBoxQtys = new System.Windows.Forms.GroupBox();
            this.emptyCoinBox = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.coinName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coinAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coinTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CanRackQtyBox = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.refillButton = new System.Windows.Forms.Button();
            this.newFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.coinBoxQtys.SuspendLayout();
            this.CanRackQtyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertMoney
            // 
            this.insertMoney.AutoSize = true;
            this.insertMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertMoney.Location = new System.Drawing.Point(498, 78);
            this.insertMoney.Name = "insertMoney";
            this.insertMoney.Size = new System.Drawing.Size(0, 13);
            this.insertMoney.TabIndex = 0;
            // 
            // exactChange
            // 
            this.exactChange.AutoSize = true;
            this.exactChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exactChange.ForeColor = System.Drawing.Color.Red;
            this.exactChange.Location = new System.Drawing.Point(489, 91);
            this.exactChange.Name = "exactChange";
            this.exactChange.Size = new System.Drawing.Size(141, 13);
            this.exactChange.TabIndex = 1;
            this.exactChange.Text = "Exact Change Required";
            // 
            // amountInserted
            // 
            this.amountInserted.AutoSize = true;
            this.amountInserted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInserted.Location = new System.Drawing.Point(498, 20);
            this.amountInserted.Name = "amountInserted";
            this.amountInserted.Size = new System.Drawing.Size(127, 13);
            this.amountInserted.TabIndex = 2;
            this.amountInserted.Text = "AMOUNT INSERTED";
            // 
            // moneyInserted
            // 
            this.moneyInserted.BackColor = System.Drawing.SystemColors.MenuText;
            this.moneyInserted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyInserted.ForeColor = System.Drawing.Color.Red;
            this.moneyInserted.Location = new System.Drawing.Point(492, 37);
            this.moneyInserted.Name = "moneyInserted";
            this.moneyInserted.Size = new System.Drawing.Size(138, 29);
            this.moneyInserted.TabIndex = 3;
            this.moneyInserted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lemon
            // 
            this.lemon.BackgroundImage = global::_08_Odie.Properties.Resources.Lemon;
            this.lemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lemon.Location = new System.Drawing.Point(289, 6);
            this.lemon.Name = "lemon";
            this.lemon.Size = new System.Drawing.Size(145, 251);
            this.lemon.TabIndex = 7;
            this.lemon.TabStop = false;
            // 
            // regular
            // 
            this.regular.BackgroundImage = global::_08_Odie.Properties.Resources.Regular;
            this.regular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regular.Location = new System.Drawing.Point(148, 6);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(145, 251);
            this.regular.TabIndex = 6;
            this.regular.TabStop = false;
            // 
            // orange
            // 
            this.orange.BackgroundImage = global::_08_Odie.Properties.Resources.Orange;
            this.orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orange.Location = new System.Drawing.Point(6, 6);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(145, 251);
            this.orange.TabIndex = 4;
            this.orange.TabStop = false;
            // 
            // returnMoneyButton
            // 
            this.returnMoneyButton.BackColor = System.Drawing.Color.SteelBlue;
            this.returnMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMoneyButton.ForeColor = System.Drawing.Color.White;
            this.returnMoneyButton.Location = new System.Drawing.Point(492, 263);
            this.returnMoneyButton.Name = "returnMoneyButton";
            this.returnMoneyButton.Size = new System.Drawing.Size(133, 45);
            this.returnMoneyButton.TabIndex = 8;
            this.returnMoneyButton.Text = "Return Money";
            this.returnMoneyButton.UseVisualStyleBackColor = false;
            this.returnMoneyButton.Click += new System.EventHandler(this.returnMoneyButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.orangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orangeButton.ForeColor = System.Drawing.Color.White;
            this.orangeButton.Location = new System.Drawing.Point(12, 263);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(130, 45);
            this.orangeButton.TabIndex = 9;
            this.orangeButton.Text = "ORANGE";
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // regularButton
            // 
            this.regularButton.BackColor = System.Drawing.Color.SteelBlue;
            this.regularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularButton.ForeColor = System.Drawing.Color.White;
            this.regularButton.Location = new System.Drawing.Point(155, 263);
            this.regularButton.Name = "regularButton";
            this.regularButton.Size = new System.Drawing.Size(129, 45);
            this.regularButton.TabIndex = 10;
            this.regularButton.Text = "REGULAR";
            this.regularButton.UseVisualStyleBackColor = false;
            this.regularButton.Click += new System.EventHandler(this.regularButton_Click);
            // 
            // lemonButton
            // 
            this.lemonButton.BackColor = System.Drawing.Color.SteelBlue;
            this.lemonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonButton.ForeColor = System.Drawing.Color.White;
            this.lemonButton.Location = new System.Drawing.Point(297, 263);
            this.lemonButton.Name = "lemonButton";
            this.lemonButton.Size = new System.Drawing.Size(130, 45);
            this.lemonButton.TabIndex = 11;
            this.lemonButton.Text = "LEMON";
            this.lemonButton.UseVisualStyleBackColor = false;
            this.lemonButton.Click += new System.EventHandler(this.lemonButton_Click);
            // 
            // nickelButton
            // 
            this.nickelButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.nickelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickelButton.ForeColor = System.Drawing.Color.Black;
            this.nickelButton.Location = new System.Drawing.Point(492, 107);
            this.nickelButton.Name = "nickelButton";
            this.nickelButton.Size = new System.Drawing.Size(133, 33);
            this.nickelButton.TabIndex = 12;
            this.nickelButton.Text = "NICKEL";
            this.nickelButton.UseVisualStyleBackColor = false;
            this.nickelButton.Click += new System.EventHandler(this.nickelButton_Click);
            // 
            // dimeButton
            // 
            this.dimeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimeButton.Location = new System.Drawing.Point(492, 146);
            this.dimeButton.Name = "dimeButton";
            this.dimeButton.Size = new System.Drawing.Size(133, 33);
            this.dimeButton.TabIndex = 13;
            this.dimeButton.Text = "DIME";
            this.dimeButton.UseVisualStyleBackColor = false;
            this.dimeButton.Click += new System.EventHandler(this.dimeButton_Click);
            // 
            // quarterButton
            // 
            this.quarterButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.quarterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterButton.Location = new System.Drawing.Point(492, 185);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(133, 33);
            this.quarterButton.TabIndex = 14;
            this.quarterButton.Text = "QUARTER";
            this.quarterButton.UseVisualStyleBackColor = false;
            this.quarterButton.Click += new System.EventHandler(this.quarterButton_Click);
            // 
            // halfdollarButton
            // 
            this.halfdollarButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.halfdollarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfdollarButton.Location = new System.Drawing.Point(492, 224);
            this.halfdollarButton.Name = "halfdollarButton";
            this.halfdollarButton.Size = new System.Drawing.Size(133, 33);
            this.halfdollarButton.TabIndex = 15;
            this.halfdollarButton.Text = "HALFDOLLAR";
            this.halfdollarButton.UseVisualStyleBackColor = false;
            this.halfdollarButton.Click += new System.EventHandler(this.halfdollarButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 356);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lemon);
            this.tabPage1.Controls.Add(this.halfdollarButton);
            this.tabPage1.Controls.Add(this.insertMoney);
            this.tabPage1.Controls.Add(this.quarterButton);
            this.tabPage1.Controls.Add(this.exactChange);
            this.tabPage1.Controls.Add(this.dimeButton);
            this.tabPage1.Controls.Add(this.amountInserted);
            this.tabPage1.Controls.Add(this.nickelButton);
            this.tabPage1.Controls.Add(this.moneyInserted);
            this.tabPage1.Controls.Add(this.lemonButton);
            this.tabPage1.Controls.Add(this.orange);
            this.tabPage1.Controls.Add(this.regularButton);
            this.tabPage1.Controls.Add(this.regular);
            this.tabPage1.Controls.Add(this.orangeButton);
            this.tabPage1.Controls.Add(this.returnMoneyButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vend";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newFormButton);
            this.tabPage2.Controls.Add(this.coinBoxQtys);
            this.tabPage2.Controls.Add(this.CanRackQtyBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // coinBoxQtys
            // 
            this.coinBoxQtys.Controls.Add(this.emptyCoinBox);
            this.coinBoxQtys.Controls.Add(this.listView2);
            this.coinBoxQtys.Location = new System.Drawing.Point(215, 3);
            this.coinBoxQtys.Name = "coinBoxQtys";
            this.coinBoxQtys.Size = new System.Drawing.Size(232, 238);
            this.coinBoxQtys.TabIndex = 7;
            this.coinBoxQtys.TabStop = false;
            this.coinBoxQtys.Text = "Coin Box Quantities";
            // 
            // emptyCoinBox
            // 
            this.emptyCoinBox.Location = new System.Drawing.Point(59, 187);
            this.emptyCoinBox.Name = "emptyCoinBox";
            this.emptyCoinBox.Size = new System.Drawing.Size(118, 45);
            this.emptyCoinBox.TabIndex = 6;
            this.emptyCoinBox.Text = "Empty Coin Box";
            this.emptyCoinBox.UseVisualStyleBackColor = true;
            this.emptyCoinBox.Click += new System.EventHandler(this.emptyCoinBox_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coinName,
            this.coinAmount,
            this.coinTotal});
            this.listView2.Location = new System.Drawing.Point(6, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(220, 152);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // coinName
            // 
            this.coinName.Text = "Coin";
            this.coinName.Width = 82;
            // 
            // coinAmount
            // 
            this.coinAmount.Text = "Qty";
            this.coinAmount.Width = 47;
            // 
            // coinTotal
            // 
            this.coinTotal.Text = "Total";
            // 
            // CanRackQtyBox
            // 
            this.CanRackQtyBox.Controls.Add(this.listView1);
            this.CanRackQtyBox.Controls.Add(this.refillButton);
            this.CanRackQtyBox.Location = new System.Drawing.Point(3, 3);
            this.CanRackQtyBox.Name = "CanRackQtyBox";
            this.CanRackQtyBox.Size = new System.Drawing.Size(180, 174);
            this.CanRackQtyBox.TabIndex = 5;
            this.CanRackQtyBox.TabStop = false;
            this.CanRackQtyBox.Text = "Can Rack Quantities";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(166, 100);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Flavor";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Orange.jpg");
            this.imageList1.Images.SetKeyName(1, "Regular.jpg");
            this.imageList1.Images.SetKeyName(2, "Lemon.jpg");
            // 
            // refillButton
            // 
            this.refillButton.Location = new System.Drawing.Point(37, 125);
            this.refillButton.Name = "refillButton";
            this.refillButton.Size = new System.Drawing.Size(101, 43);
            this.refillButton.TabIndex = 1;
            this.refillButton.Text = "Refill Can Rack";
            this.refillButton.UseVisualStyleBackColor = true;
            this.refillButton.Click += new System.EventHandler(this.refillButton_Click);
            // 
            // newFormButton
            // 
            this.newFormButton.Location = new System.Drawing.Point(485, 75);
            this.newFormButton.Name = "newFormButton";
            this.newFormButton.Size = new System.Drawing.Size(116, 62);
            this.newFormButton.TabIndex = 8;
            this.newFormButton.Text = "Add Service Notes";
            this.newFormButton.UseVisualStyleBackColor = true;
            this.newFormButton.Click += new System.EventHandler(this.newFormButton_Click);
            // 
            // vendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(881, 522);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "vendingMachine";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.vendingMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.coinBoxQtys.ResumeLayout(false);
            this.CanRackQtyBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label insertMoney;
        private System.Windows.Forms.Label exactChange;
        private System.Windows.Forms.Label amountInserted;
        private System.Windows.Forms.TextBox moneyInserted;
        private System.Windows.Forms.PictureBox orange;
        private System.Windows.Forms.PictureBox regular;
        private System.Windows.Forms.PictureBox lemon;
        private System.Windows.Forms.Button returnMoneyButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button regularButton;
        private System.Windows.Forms.Button lemonButton;
        private System.Windows.Forms.Button nickelButton;
        private System.Windows.Forms.Button dimeButton;
        private System.Windows.Forms.Button quarterButton;
        private System.Windows.Forms.Button halfdollarButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button refillButton;
        private System.Windows.Forms.GroupBox CanRackQtyBox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader coinName;
        private System.Windows.Forms.ColumnHeader coinAmount;
        private System.Windows.Forms.ColumnHeader coinTotal;
        private System.Windows.Forms.Button emptyCoinBox;
        private System.Windows.Forms.GroupBox coinBoxQtys;
        private System.Windows.Forms.Button newFormButton;
    }
}

