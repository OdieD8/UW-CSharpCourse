namespace _06_Odie
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
            ((System.ComponentModel.ISupportInitialize)(this.lemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).BeginInit();
            this.SuspendLayout();
            // 
            // insertMoney
            // 
            this.insertMoney.AutoSize = true;
            this.insertMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertMoney.Location = new System.Drawing.Point(504, 84);
            this.insertMoney.Name = "insertMoney";
            this.insertMoney.Size = new System.Drawing.Size(0, 13);
            this.insertMoney.TabIndex = 0;
            // 
            // exactChange
            // 
            this.exactChange.AutoSize = true;
            this.exactChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exactChange.ForeColor = System.Drawing.Color.Red;
            this.exactChange.Location = new System.Drawing.Point(495, 97);
            this.exactChange.Name = "exactChange";
            this.exactChange.Size = new System.Drawing.Size(141, 13);
            this.exactChange.TabIndex = 1;
            this.exactChange.Text = "Exact Change Required";
            // 
            // amountInserted
            // 
            this.amountInserted.AutoSize = true;
            this.amountInserted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInserted.Location = new System.Drawing.Point(504, 26);
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
            this.moneyInserted.Location = new System.Drawing.Point(498, 43);
            this.moneyInserted.Name = "moneyInserted";
            this.moneyInserted.Size = new System.Drawing.Size(138, 29);
            this.moneyInserted.TabIndex = 3;
            this.moneyInserted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lemon
            // 
            this.lemon.BackgroundImage = global::_06_Odie.Properties.Resources.Lemon;
            this.lemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lemon.Location = new System.Drawing.Point(295, 12);
            this.lemon.Name = "lemon";
            this.lemon.Size = new System.Drawing.Size(145, 251);
            this.lemon.TabIndex = 7;
            this.lemon.TabStop = false;
            // 
            // regular
            // 
            this.regular.BackgroundImage = global::_06_Odie.Properties.Resources.Regular;
            this.regular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regular.Location = new System.Drawing.Point(154, 12);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(145, 251);
            this.regular.TabIndex = 6;
            this.regular.TabStop = false;
            // 
            // orange
            // 
            this.orange.BackgroundImage = global::_06_Odie.Properties.Resources.Orange;
            this.orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orange.Location = new System.Drawing.Point(12, 12);
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
            this.returnMoneyButton.Location = new System.Drawing.Point(498, 269);
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
            this.orangeButton.Location = new System.Drawing.Point(18, 269);
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
            this.regularButton.Location = new System.Drawing.Point(161, 269);
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
            this.lemonButton.Location = new System.Drawing.Point(303, 269);
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
            this.nickelButton.Location = new System.Drawing.Point(498, 113);
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
            this.dimeButton.Location = new System.Drawing.Point(498, 152);
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
            this.quarterButton.Location = new System.Drawing.Point(498, 191);
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
            this.halfdollarButton.Location = new System.Drawing.Point(498, 230);
            this.halfdollarButton.Name = "halfdollarButton";
            this.halfdollarButton.Size = new System.Drawing.Size(133, 33);
            this.halfdollarButton.TabIndex = 15;
            this.halfdollarButton.Text = "HALFDOLLAR";
            this.halfdollarButton.UseVisualStyleBackColor = false;
            this.halfdollarButton.Click += new System.EventHandler(this.halfdollarButton_Click);
            // 
            // vendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(648, 343);
            this.Controls.Add(this.halfdollarButton);
            this.Controls.Add(this.quarterButton);
            this.Controls.Add(this.dimeButton);
            this.Controls.Add(this.nickelButton);
            this.Controls.Add(this.lemonButton);
            this.Controls.Add(this.regularButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.returnMoneyButton);
            this.Controls.Add(this.lemon);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.moneyInserted);
            this.Controls.Add(this.amountInserted);
            this.Controls.Add(this.exactChange);
            this.Controls.Add(this.insertMoney);
            this.Name = "vendingMachine";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.vendingMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

