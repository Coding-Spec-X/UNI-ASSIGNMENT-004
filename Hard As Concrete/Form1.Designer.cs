namespace Hard_As_Concrete
{
    partial class concreteCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBagsRequired = new System.Windows.Forms.TextBox();
            this.bagsRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(335, 386);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(172, 43);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(537, 386);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 43);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCost.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxCost.ForeColor = System.Drawing.Color.Black;
            this.textBoxCost.Location = new System.Drawing.Point(320, 319);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(200, 27);
            this.textBoxCost.TabIndex = 3;
            this.textBoxCost.Text = "$";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(130, 386);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(172, 43);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // textBoxLength
            // 
            this.textBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLength.Location = new System.Drawing.Point(497, 121);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(200, 27);
            this.textBoxLength.TabIndex = 5;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxWidth.Location = new System.Drawing.Point(154, 121);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(200, 27);
            this.textBoxWidth.TabIndex = 6;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Blue;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel.Location = new System.Drawing.Point(231, 319);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(79, 20);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Total Cost";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Blue;
            this.lengthLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lengthLabel.ForeColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Location = new System.Drawing.Point(403, 128);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(88, 20);
            this.lengthLabel.TabIndex = 8;
            this.lengthLabel.Text = "Length (m)";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.BackColor = System.Drawing.Color.Blue;
            this.widthLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.widthLabel.ForeColor = System.Drawing.Color.Transparent;
            this.widthLabel.Location = new System.Drawing.Point(66, 128);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(82, 20);
            this.widthLabel.TabIndex = 9;
            this.widthLabel.Text = "Width (m)";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Blue;
            this.textBox4.Font = new System.Drawing.Font("Vladimir Script", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.Transparent;
            this.textBox4.Location = new System.Drawing.Point(1, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(797, 76);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Hard as Concrete";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxVolume.ForeColor = System.Drawing.Color.Black;
            this.textBoxVolume.Location = new System.Drawing.Point(320, 171);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(200, 27);
            this.textBoxVolume.TabIndex = 11;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxAmount.ForeColor = System.Drawing.Color.Black;
            this.textBoxAmount.Location = new System.Drawing.Point(320, 218);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(200, 27);
            this.textBoxAmount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(130, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Concrete Required (Kgs)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(248, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Volume";
            // 
            // textBoxBagsRequired
            // 
            this.textBoxBagsRequired.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxBagsRequired.ForeColor = System.Drawing.Color.Black;
            this.textBoxBagsRequired.Location = new System.Drawing.Point(321, 267);
            this.textBoxBagsRequired.Name = "textBoxBagsRequired";
            this.textBoxBagsRequired.Size = new System.Drawing.Size(200, 27);
            this.textBoxBagsRequired.TabIndex = 15;
            // 
            // bagsRequired
            // 
            this.bagsRequired.AutoSize = true;
            this.bagsRequired.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bagsRequired.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bagsRequired.Location = new System.Drawing.Point(205, 274);
            this.bagsRequired.Name = "bagsRequired";
            this.bagsRequired.Size = new System.Drawing.Size(110, 20);
            this.bagsRequired.TabIndex = 16;
            this.bagsRequired.Text = "Bags Required";
            // 
            // concreteCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bagsRequired);
            this.Controls.Add(this.textBoxBagsRequired);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Name = "concreteCalculator";
            this.Text = "Concrete Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button clearButton;
        private Button exitButton;
        private TextBox textBoxCost;
        private Button calculateButton;
        private TextBox textBoxLength;

       

        private TextBox textBoxWidth;
        private Label priceLabel;
        private Label lengthLabel;
        private Label widthLabel;
        private TextBox textBox4;
        private TextBox textBoxVolume;
        private TextBox textBoxAmount;
        private Label label1;
        private Label label2;
        private TextBox textBoxBagsRequired;
        private Label bagsRequired;
    }
}