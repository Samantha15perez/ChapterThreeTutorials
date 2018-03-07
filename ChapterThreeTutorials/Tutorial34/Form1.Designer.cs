namespace Tutorial34
{
    partial class TestAverage
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
            this.TL1 = new System.Windows.Forms.Label();
            this.TL2 = new System.Windows.Forms.Label();
            this.TL3 = new System.Windows.Forms.Label();
            this.TL4 = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TL1
            // 
            this.TL1.AutoSize = true;
            this.TL1.Location = new System.Drawing.Point(74, 29);
            this.TL1.Name = "TL1";
            this.TL1.Size = new System.Drawing.Size(37, 13);
            this.TL1.TabIndex = 0;
            this.TL1.Text = "Test 1";
            this.TL1.Click += new System.EventHandler(this.TL1_Click);
            // 
            // TL2
            // 
            this.TL2.AutoSize = true;
            this.TL2.Location = new System.Drawing.Point(77, 56);
            this.TL2.Name = "TL2";
            this.TL2.Size = new System.Drawing.Size(34, 13);
            this.TL2.TabIndex = 0;
            this.TL2.Text = "Test2";
            // 
            // TL3
            // 
            this.TL3.AutoSize = true;
            this.TL3.Location = new System.Drawing.Point(76, 79);
            this.TL3.Name = "TL3";
            this.TL3.Size = new System.Drawing.Size(34, 13);
            this.TL3.TabIndex = 0;
            this.TL3.Text = "Test3";
            // 
            // TL4
            // 
            this.TL4.AutoSize = true;
            this.TL4.Location = new System.Drawing.Point(38, 137);
            this.TL4.Name = "TL4";
            this.TL4.Size = new System.Drawing.Size(105, 13);
            this.TL4.TabIndex = 0;
            this.TL4.Text = "Average Test Score:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(149, 123);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(99, 27);
            this.outputDescriptionLabel.TabIndex = 0;
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(117, 26);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 1;
            this.test1TextBox.TextChanged += new System.EventHandler(this.test1TextBox_TextChanged);
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(117, 53);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 1;
            this.test2TextBox.TextChanged += new System.EventHandler(this.test2TextBox_TextChanged);
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(117, 79);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.test3TextBox.TabIndex = 1;
            this.test3TextBox.TextChanged += new System.EventHandler(this.test3TextBox_TextChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(32, 170);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 37);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate Average";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(113, 170);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(194, 170);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // TestAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 219);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.TL4);
            this.Controls.Add(this.TL3);
            this.Controls.Add(this.TL2);
            this.Controls.Add(this.TL1);
            this.Name = "TestAverage";
            this.Text = "Test Average Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TL1;
        private System.Windows.Forms.Label TL2;
        private System.Windows.Forms.Label TL3;
        private System.Windows.Forms.Label TL4;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

