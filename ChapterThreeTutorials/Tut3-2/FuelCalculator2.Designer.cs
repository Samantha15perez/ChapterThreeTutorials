namespace Tut3_2
{
    partial class FuelCalculator2
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
            this.mpgLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Location = new System.Drawing.Point(180, 109);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(100, 23);
            this.mpgLabel.TabIndex = 11;
            this.mpgLabel.Click += new System.EventHandler(this.mpgLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(180, 149);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 42);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(54, 149);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 42);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(180, 48);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonsTextBox.TabIndex = 7;
            this.gallonsTextBox.TextChanged += new System.EventHandler(this.gallonsTextBox_TextChanged);
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(180, 16);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesTextBox.TabIndex = 8;
            this.milesTextBox.TextChanged += new System.EventHandler(this.milesTextBox_TextChanged);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(72, 110);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Your car\'s MPG:";
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Location = new System.Drawing.Point(12, 48);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(144, 13);
            this.gallonsPromptLabel.TabIndex = 5;
            this.gallonsPromptLabel.Text = "Enter the gallons of gas used";
            this.gallonsPromptLabel.Click += new System.EventHandler(this.gallonsPromptLabel_Click);
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Location = new System.Drawing.Point(12, 19);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(158, 13);
            this.milesPromptLabel.TabIndex = 6;
            this.milesPromptLabel.Text = "Enter the number of miles driven";
            this.milesPromptLabel.Click += new System.EventHandler(this.milesPromptLabel_Click);
            // 
            // FuelCalculator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 208);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Name = "FuelCalculator2";
            this.Text = "FuelCalculator2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.Label milesPromptLabel;
    }
}