namespace ProgrammingProblems
{
    partial class CalorieCounter
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pbPear = new System.Windows.Forms.PictureBox();
            this.pbOrange = new System.Windows.Forms.PictureBox();
            this.pbBanana = new System.Windows.Forms.PictureBox();
            this.pbApple = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(303, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Calories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(303, 118);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(101, 23);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // pbPear
            // 
            this.pbPear.Image = global::ProgrammingProblems.Properties.Resources.Orange;
            this.pbPear.Location = new System.Drawing.Point(144, 174);
            this.pbPear.Name = "pbPear";
            this.pbPear.Size = new System.Drawing.Size(126, 156);
            this.pbPear.TabIndex = 12;
            this.pbPear.TabStop = false;
            this.pbPear.Click += new System.EventHandler(this.pbPear_Click);
            // 
            // pbOrange
            // 
            this.pbOrange.Image = global::ProgrammingProblems.Properties.Resources.Pear;
            this.pbOrange.Location = new System.Drawing.Point(12, 174);
            this.pbOrange.Name = "pbOrange";
            this.pbOrange.Size = new System.Drawing.Size(126, 156);
            this.pbOrange.TabIndex = 11;
            this.pbOrange.TabStop = false;
            this.pbOrange.Click += new System.EventHandler(this.pbOrange_Click);
            // 
            // pbBanana
            // 
            this.pbBanana.Image = global::ProgrammingProblems.Properties.Resources.Banana;
            this.pbBanana.Location = new System.Drawing.Point(144, 12);
            this.pbBanana.Name = "pbBanana";
            this.pbBanana.Size = new System.Drawing.Size(126, 156);
            this.pbBanana.TabIndex = 10;
            this.pbBanana.TabStop = false;
            this.pbBanana.Click += new System.EventHandler(this.pbBanana_Click);
            // 
            // pbApple
            // 
            this.pbApple.Image = global::ProgrammingProblems.Properties.Resources.apple;
            this.pbApple.Location = new System.Drawing.Point(12, 12);
            this.pbApple.Name = "pbApple";
            this.pbApple.Size = new System.Drawing.Size(126, 156);
            this.pbApple.TabIndex = 9;
            this.pbApple.TabStop = false;
            this.pbApple.Click += new System.EventHandler(this.pbApple_Click);
            // 
            // CalorieCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 356);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pbPear);
            this.Controls.Add(this.pbOrange);
            this.Controls.Add(this.pbBanana);
            this.Controls.Add(this.pbApple);
            this.Name = "CalorieCounter";
            this.Text = "CalorieCounter";
            ((System.ComponentModel.ISupportInitialize)(this.pbPear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox pbPear;
        private System.Windows.Forms.PictureBox pbOrange;
        private System.Windows.Forms.PictureBox pbBanana;
        private System.Windows.Forms.PictureBox pbApple;
    }
}