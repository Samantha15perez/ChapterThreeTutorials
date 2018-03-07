namespace Tutorial35
{
    partial class ChangeCounter
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
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.fiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.twentyfiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.fiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyfiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(68, 9);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(81, 13);
            this.InstructionsLabel.TabIndex = 1;
            this.InstructionsLabel.Text = "Click The Coins";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(238, 100);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            this.outputDescriptionLabel.TabIndex = 1;
            this.outputDescriptionLabel.Text = "Total";
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(227, 113);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(57, 37);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // tenCentsPictureBox
            // 
            this.tenCentsPictureBox.BackgroundImage = global::Tutorial35.Properties.Resources._10c;
            this.tenCentsPictureBox.Location = new System.Drawing.Point(113, 48);
            this.tenCentsPictureBox.Name = "tenCentsPictureBox";
            this.tenCentsPictureBox.Size = new System.Drawing.Size(95, 90);
            this.tenCentsPictureBox.TabIndex = 2;
            this.tenCentsPictureBox.TabStop = false;
            this.tenCentsPictureBox.Click += new System.EventHandler(this.tenCentsPictureBox_Click);
            // 
            // fiftyCentsPictureBox
            // 
            this.fiftyCentsPictureBox.BackgroundImage = global::Tutorial35.Properties.Resources._50c;
            this.fiftyCentsPictureBox.Location = new System.Drawing.Point(113, 144);
            this.fiftyCentsPictureBox.Name = "fiftyCentsPictureBox";
            this.fiftyCentsPictureBox.Size = new System.Drawing.Size(95, 90);
            this.fiftyCentsPictureBox.TabIndex = 2;
            this.fiftyCentsPictureBox.TabStop = false;
            this.fiftyCentsPictureBox.Click += new System.EventHandler(this.fiftyCentsPictureBox_Click);
            // 
            // twentyfiveCentsPictureBox
            // 
            this.twentyfiveCentsPictureBox.BackgroundImage = global::Tutorial35.Properties.Resources._25c;
            this.twentyfiveCentsPictureBox.Location = new System.Drawing.Point(12, 144);
            this.twentyfiveCentsPictureBox.Name = "twentyfiveCentsPictureBox";
            this.twentyfiveCentsPictureBox.Size = new System.Drawing.Size(95, 90);
            this.twentyfiveCentsPictureBox.TabIndex = 2;
            this.twentyfiveCentsPictureBox.TabStop = false;
            this.twentyfiveCentsPictureBox.Click += new System.EventHandler(this.twentyfiveCentsPictureBox_Click);
            // 
            // fiveCentsPictureBox
            // 
            this.fiveCentsPictureBox.BackgroundImage = global::Tutorial35.Properties.Resources._5c;
            this.fiveCentsPictureBox.Location = new System.Drawing.Point(12, 48);
            this.fiveCentsPictureBox.Name = "fiveCentsPictureBox";
            this.fiveCentsPictureBox.Size = new System.Drawing.Size(95, 90);
            this.fiveCentsPictureBox.TabIndex = 2;
            this.fiveCentsPictureBox.TabStop = false;
            this.fiveCentsPictureBox.Click += new System.EventHandler(this.fiveCentsPictureBox_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(146, 255);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(52, 255);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ChangeCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 290);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tenCentsPictureBox);
            this.Controls.Add(this.fiftyCentsPictureBox);
            this.Controls.Add(this.twentyfiveCentsPictureBox);
            this.Controls.Add(this.fiveCentsPictureBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Name = "ChangeCounter";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyfiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.PictureBox fiveCentsPictureBox;
        private System.Windows.Forms.PictureBox tenCentsPictureBox;
        private System.Windows.Forms.PictureBox twentyfiveCentsPictureBox;
        private System.Windows.Forms.PictureBox fiftyCentsPictureBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

