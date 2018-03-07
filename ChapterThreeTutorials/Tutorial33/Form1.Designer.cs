namespace Tutorial33
{
    partial class SalePriceCalc
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
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.originalPricePromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceLabel.Location = new System.Drawing.Point(180, 105);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(100, 23);
            this.salePriceLabel.TabIndex = 35;
            this.salePriceLabel.Click += new System.EventHandler(this.salePriceLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(180, 145);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 42);
            this.exitButton.TabIndex = 33;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(54, 145);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 42);
            this.calculateButton.TabIndex = 34;
            this.calculateButton.Text = "Calculate sale price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Location = new System.Drawing.Point(180, 44);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountPercentageTextBox.TabIndex = 31;
            this.discountPercentageTextBox.TextChanged += new System.EventHandler(this.discountPercentageTextBox_TextChanged);
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Location = new System.Drawing.Point(180, 12);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.originalPriceTextBox.TabIndex = 32;
            this.originalPriceTextBox.TextChanged += new System.EventHandler(this.originalPriceTextBox_TextChanged);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(72, 106);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(58, 13);
            this.outputDescriptionLabel.TabIndex = 28;
            this.outputDescriptionLabel.Text = "Sale Price:";
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.AutoSize = true;
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(12, 44);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(150, 13);
            this.discPercentagePromptLabel.TabIndex = 29;
            this.discPercentagePromptLabel.Text = "Enter the discount percentage";
            // 
            // originalPricePromptLabel
            // 
            this.originalPricePromptLabel.AutoSize = true;
            this.originalPricePromptLabel.Location = new System.Drawing.Point(12, 15);
            this.originalPricePromptLabel.Name = "originalPricePromptLabel";
            this.originalPricePromptLabel.Size = new System.Drawing.Size(139, 13);
            this.originalPricePromptLabel.TabIndex = 30;
            this.originalPricePromptLabel.Text = "Enter the items original price";
            // 
            // SalePriceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 199);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.originalPriceTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.originalPricePromptLabel);
            this.Name = "SalePriceCalc";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private System.Windows.Forms.TextBox originalPriceTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label discPercentagePromptLabel;
        private System.Windows.Forms.Label originalPricePromptLabel;
    }
}

