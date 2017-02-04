namespace _06._1_Vend
{
    partial class VendingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendingForm));
            this.regularSodaPicBox = new System.Windows.Forms.PictureBox();
            this.orangeSodaPicBox = new System.Windows.Forms.PictureBox();
            this.lemonSodaPicBox = new System.Windows.Forms.PictureBox();
            this.regularEjectButton = new System.Windows.Forms.Button();
            this.orangeEjectButton = new System.Windows.Forms.Button();
            this.lemonEjectButton = new System.Windows.Forms.Button();
            this.halfDollarButton = new System.Windows.Forms.Button();
            this.quarterButton = new System.Windows.Forms.Button();
            this.dimeButton = new System.Windows.Forms.Button();
            this.nickelButton = new System.Windows.Forms.Button();
            this.pleaseInsertLabel = new System.Windows.Forms.Label();
            this.totalInsertedLabel = new System.Windows.Forms.Label();
            this.totalInsertedDisplayLabel = new System.Windows.Forms.Label();
            this.ExactChangeLabel = new System.Windows.Forms.Label();
            this.CoinReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.regularSodaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSodaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonSodaPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // regularSodaPicBox
            // 
            this.regularSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("regularSodaPicBox.Image")));
            this.regularSodaPicBox.Location = new System.Drawing.Point(23, 66);
            this.regularSodaPicBox.Name = "regularSodaPicBox";
            this.regularSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.regularSodaPicBox.TabIndex = 0;
            this.regularSodaPicBox.TabStop = false;
            // 
            // orangeSodaPicBox
            // 
            this.orangeSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("orangeSodaPicBox.Image")));
            this.orangeSodaPicBox.Location = new System.Drawing.Point(227, 66);
            this.orangeSodaPicBox.Name = "orangeSodaPicBox";
            this.orangeSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.orangeSodaPicBox.TabIndex = 1;
            this.orangeSodaPicBox.TabStop = false;
            // 
            // lemonSodaPicBox
            // 
            this.lemonSodaPicBox.Image = ((System.Drawing.Image)(resources.GetObject("lemonSodaPicBox.Image")));
            this.lemonSodaPicBox.Location = new System.Drawing.Point(431, 66);
            this.lemonSodaPicBox.Name = "lemonSodaPicBox";
            this.lemonSodaPicBox.Size = new System.Drawing.Size(198, 218);
            this.lemonSodaPicBox.TabIndex = 2;
            this.lemonSodaPicBox.TabStop = false;
            // 
            // regularEjectButton
            // 
            this.regularEjectButton.Enabled = false;
            this.regularEjectButton.Location = new System.Drawing.Point(83, 299);
            this.regularEjectButton.Name = "regularEjectButton";
            this.regularEjectButton.Size = new System.Drawing.Size(75, 23);
            this.regularEjectButton.TabIndex = 3;
            this.regularEjectButton.Text = "Eject";
            this.regularEjectButton.UseVisualStyleBackColor = true;
            this.regularEjectButton.Click += new System.EventHandler(this.regularEjectButton_Click);
            // 
            // orangeEjectButton
            // 
            this.orangeEjectButton.Enabled = false;
            this.orangeEjectButton.Location = new System.Drawing.Point(296, 299);
            this.orangeEjectButton.Name = "orangeEjectButton";
            this.orangeEjectButton.Size = new System.Drawing.Size(75, 23);
            this.orangeEjectButton.TabIndex = 4;
            this.orangeEjectButton.Text = "Eject";
            this.orangeEjectButton.UseVisualStyleBackColor = true;
            this.orangeEjectButton.Click += new System.EventHandler(this.orangeEjectButton_Click);
            // 
            // lemonEjectButton
            // 
            this.lemonEjectButton.Enabled = false;
            this.lemonEjectButton.Location = new System.Drawing.Point(488, 299);
            this.lemonEjectButton.Name = "lemonEjectButton";
            this.lemonEjectButton.Size = new System.Drawing.Size(75, 23);
            this.lemonEjectButton.TabIndex = 5;
            this.lemonEjectButton.Text = "Eject";
            this.lemonEjectButton.UseVisualStyleBackColor = true;
            this.lemonEjectButton.Click += new System.EventHandler(this.lemonEjectButton_Click);
            // 
            // halfDollarButton
            // 
            this.halfDollarButton.Location = new System.Drawing.Point(23, 347);
            this.halfDollarButton.Name = "halfDollarButton";
            this.halfDollarButton.Size = new System.Drawing.Size(75, 23);
            this.halfDollarButton.TabIndex = 6;
            this.halfDollarButton.Text = "Half Dollar";
            this.halfDollarButton.UseVisualStyleBackColor = true;
            this.halfDollarButton.Click += new System.EventHandler(this.halfDollarButton_Click);
            // 
            // quarterButton
            // 
            this.quarterButton.Location = new System.Drawing.Point(104, 347);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(75, 23);
            this.quarterButton.TabIndex = 7;
            this.quarterButton.Text = "Quarter";
            this.quarterButton.UseVisualStyleBackColor = true;
            this.quarterButton.Click += new System.EventHandler(this.quarterButton_Click);
            // 
            // dimeButton
            // 
            this.dimeButton.Location = new System.Drawing.Point(185, 347);
            this.dimeButton.Name = "dimeButton";
            this.dimeButton.Size = new System.Drawing.Size(75, 23);
            this.dimeButton.TabIndex = 8;
            this.dimeButton.Text = "Dime";
            this.dimeButton.UseVisualStyleBackColor = true;
            this.dimeButton.Click += new System.EventHandler(this.dimeButton_Click);
            // 
            // nickelButton
            // 
            this.nickelButton.Location = new System.Drawing.Point(266, 347);
            this.nickelButton.Name = "nickelButton";
            this.nickelButton.Size = new System.Drawing.Size(75, 23);
            this.nickelButton.TabIndex = 9;
            this.nickelButton.Text = "Nickel";
            this.nickelButton.UseVisualStyleBackColor = true;
            this.nickelButton.Click += new System.EventHandler(this.nickelButton_Click);
            // 
            // pleaseInsertLabel
            // 
            this.pleaseInsertLabel.AutoSize = true;
            this.pleaseInsertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseInsertLabel.Location = new System.Drawing.Point(67, 21);
            this.pleaseInsertLabel.Name = "pleaseInsertLabel";
            this.pleaseInsertLabel.Size = new System.Drawing.Size(477, 33);
            this.pleaseInsertLabel.TabIndex = 10;
            this.pleaseInsertLabel.Text = "Please Insert 35 cents for a Soda";
            // 
            // totalInsertedLabel
            // 
            this.totalInsertedLabel.AutoSize = true;
            this.totalInsertedLabel.Location = new System.Drawing.Point(415, 357);
            this.totalInsertedLabel.Name = "totalInsertedLabel";
            this.totalInsertedLabel.Size = new System.Drawing.Size(72, 13);
            this.totalInsertedLabel.TabIndex = 11;
            this.totalInsertedLabel.Text = "Total Inserted";
            // 
            // totalInsertedDisplayLabel
            // 
            this.totalInsertedDisplayLabel.AutoSize = true;
            this.totalInsertedDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalInsertedDisplayLabel.Location = new System.Drawing.Point(493, 357);
            this.totalInsertedDisplayLabel.Name = "totalInsertedDisplayLabel";
            this.totalInsertedDisplayLabel.Size = new System.Drawing.Size(15, 15);
            this.totalInsertedDisplayLabel.TabIndex = 12;
            this.totalInsertedDisplayLabel.Text = "0";
            // 
            // ExactChangeLabel
            // 
            this.ExactChangeLabel.AutoSize = true;
            this.ExactChangeLabel.ForeColor = System.Drawing.Color.Red;
            this.ExactChangeLabel.Location = new System.Drawing.Point(162, 383);
            this.ExactChangeLabel.Name = "ExactChangeLabel";
            this.ExactChangeLabel.Size = new System.Drawing.Size(120, 13);
            this.ExactChangeLabel.TabIndex = 13;
            this.ExactChangeLabel.Text = "Exact Change Required";
            this.ExactChangeLabel.Visible = false;
            // 
            // CoinReturnButton
            // 
            this.CoinReturnButton.Enabled = false;
            this.CoinReturnButton.Location = new System.Drawing.Point(433, 383);
            this.CoinReturnButton.Name = "CoinReturnButton";
            this.CoinReturnButton.Size = new System.Drawing.Size(75, 23);
            this.CoinReturnButton.TabIndex = 14;
            this.CoinReturnButton.Text = "Coin Return";
            this.CoinReturnButton.UseVisualStyleBackColor = true;
            this.CoinReturnButton.Click += new System.EventHandler(this.CoinReturnButton_Click);
            // 
            // VendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 442);
            this.Controls.Add(this.CoinReturnButton);
            this.Controls.Add(this.ExactChangeLabel);
            this.Controls.Add(this.totalInsertedDisplayLabel);
            this.Controls.Add(this.totalInsertedLabel);
            this.Controls.Add(this.pleaseInsertLabel);
            this.Controls.Add(this.nickelButton);
            this.Controls.Add(this.dimeButton);
            this.Controls.Add(this.quarterButton);
            this.Controls.Add(this.halfDollarButton);
            this.Controls.Add(this.lemonEjectButton);
            this.Controls.Add(this.orangeEjectButton);
            this.Controls.Add(this.regularEjectButton);
            this.Controls.Add(this.lemonSodaPicBox);
            this.Controls.Add(this.orangeSodaPicBox);
            this.Controls.Add(this.regularSodaPicBox);
            this.Name = "VendingForm";
            this.Text = ".NET C# Vending Machine";
            this.Load += new System.EventHandler(this.VendingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regularSodaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSodaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemonSodaPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox regularSodaPicBox;
        private System.Windows.Forms.PictureBox orangeSodaPicBox;
        private System.Windows.Forms.PictureBox lemonSodaPicBox;
        private System.Windows.Forms.Button regularEjectButton;
        private System.Windows.Forms.Button orangeEjectButton;
        private System.Windows.Forms.Button lemonEjectButton;
        private System.Windows.Forms.Button halfDollarButton;
        private System.Windows.Forms.Button quarterButton;
        private System.Windows.Forms.Button dimeButton;
        private System.Windows.Forms.Button nickelButton;
        private System.Windows.Forms.Label pleaseInsertLabel;
        private System.Windows.Forms.Label totalInsertedLabel;
        private System.Windows.Forms.Label totalInsertedDisplayLabel;
        private System.Windows.Forms.Label ExactChangeLabel;
        private System.Windows.Forms.Button CoinReturnButton;
    }
}

