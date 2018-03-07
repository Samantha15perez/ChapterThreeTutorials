namespace ChapterThreeTutorials
{
    partial class Form1
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
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayofMonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.dayOfWeekTextbox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfWeekPromptLabel
            // 
            this.dayOfWeekPromptLabel.AutoSize = true;
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(48, 17);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(129, 13);
            this.dayOfWeekPromptLabel.TabIndex = 0;
            this.dayOfWeekPromptLabel.Text = "Enter the day of the week";
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(36, 43);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(141, 13);
            this.monthPromptLabel.TabIndex = 1;
            this.monthPromptLabel.Text = "Enter the name of the month";
            // 
            // dayofMonthPromptLabel
            // 
            this.dayofMonthPromptLabel.AutoSize = true;
            this.dayofMonthPromptLabel.Location = new System.Drawing.Point(5, 69);
            this.dayofMonthPromptLabel.Name = "dayofMonthPromptLabel";
            this.dayofMonthPromptLabel.Size = new System.Drawing.Size(172, 13);
            this.dayofMonthPromptLabel.TabIndex = 2;
            this.dayofMonthPromptLabel.Text = "Enter the numeric day of the month";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(101, 92);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(73, 13);
            this.yearPromptLabel.TabIndex = 3;
            this.yearPromptLabel.Text = "Enter the year";
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(51, 131);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(196, 23);
            this.dateOutputLabel.TabIndex = 4;
            // 
            // dayOfWeekTextbox
            // 
            this.dayOfWeekTextbox.Location = new System.Drawing.Point(183, 14);
            this.dayOfWeekTextbox.Name = "dayOfWeekTextbox";
            this.dayOfWeekTextbox.Size = new System.Drawing.Size(100, 20);
            this.dayOfWeekTextbox.TabIndex = 5;
            this.dayOfWeekTextbox.TextChanged += new System.EventHandler(this.dayOfWeekTextbox_TextChanged);
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(183, 66);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfMonthTextBox.TabIndex = 6;
            this.dayOfMonthTextBox.TextChanged += new System.EventHandler(this.dayOfMonthTextBox_TextChanged);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(183, 40);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 7;
            this.monthTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(183, 92);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 8;
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(39, 201);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(75, 23);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(120, 199);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(205, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.dayOfWeekTextbox);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayofMonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayofMonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.TextBox dayOfWeekTextbox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

