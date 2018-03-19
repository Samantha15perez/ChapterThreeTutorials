namespace ProgrammingProblems
{
    partial class DistanceTraveled
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
            this.lbl12DistanceText = new System.Windows.Forms.Label();
            this.lbl8DistanceText = new System.Windows.Forms.Label();
            this.lbl5DistanceText = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbl12Distance = new System.Windows.Forms.Label();
            this.lbl8Distance = new System.Windows.Forms.Label();
            this.lbl5Distance = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl12DistanceText
            // 
            this.lbl12DistanceText.AutoSize = true;
            this.lbl12DistanceText.Location = new System.Drawing.Point(319, 71);
            this.lbl12DistanceText.Name = "lbl12DistanceText";
            this.lbl12DistanceText.Size = new System.Drawing.Size(95, 13);
            this.lbl12DistanceText.TabIndex = 35;
            this.lbl12DistanceText.Text = "12 Hours Distance";
            this.lbl12DistanceText.Click += new System.EventHandler(this.lbl12DistanceText_Click);
            // 
            // lbl8DistanceText
            // 
            this.lbl8DistanceText.AutoSize = true;
            this.lbl8DistanceText.Location = new System.Drawing.Point(325, 39);
            this.lbl8DistanceText.Name = "lbl8DistanceText";
            this.lbl8DistanceText.Size = new System.Drawing.Size(89, 13);
            this.lbl8DistanceText.TabIndex = 34;
            this.lbl8DistanceText.Text = "8 Hours Distance";
            this.lbl8DistanceText.Click += new System.EventHandler(this.lbl8DistanceText_Click);
            // 
            // lbl5DistanceText
            // 
            this.lbl5DistanceText.AutoSize = true;
            this.lbl5DistanceText.Location = new System.Drawing.Point(325, 7);
            this.lbl5DistanceText.Name = "lbl5DistanceText";
            this.lbl5DistanceText.Size = new System.Drawing.Size(89, 13);
            this.lbl5DistanceText.TabIndex = 33;
            this.lbl5DistanceText.Text = "5 Hours Distance";
            this.lbl5DistanceText.Click += new System.EventHandler(this.lbl5DistanceText_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(12, 42);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(67, 13);
            this.lblInstruction.TabIndex = 32;
            this.lblInstruction.Text = "Speed (mph)";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 55);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(159, 107);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 55);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbl12Distance
            // 
            this.lbl12Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl12Distance.Location = new System.Drawing.Point(206, 71);
            this.lbl12Distance.Name = "lbl12Distance";
            this.lbl12Distance.Size = new System.Drawing.Size(103, 19);
            this.lbl12Distance.TabIndex = 28;
            this.lbl12Distance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl12Distance.Click += new System.EventHandler(this.lbl12Distance_Click);
            // 
            // lbl8Distance
            // 
            this.lbl8Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl8Distance.Location = new System.Drawing.Point(206, 36);
            this.lbl8Distance.Name = "lbl8Distance";
            this.lbl8Distance.Size = new System.Drawing.Size(103, 19);
            this.lbl8Distance.TabIndex = 27;
            this.lbl8Distance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl8Distance.Click += new System.EventHandler(this.lbl8Distance_Click);
            // 
            // lbl5Distance
            // 
            this.lbl5Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5Distance.Location = new System.Drawing.Point(206, 4);
            this.lbl5Distance.Name = "lbl5Distance";
            this.lbl5Distance.Size = new System.Drawing.Size(103, 19);
            this.lbl5Distance.TabIndex = 26;
            this.lbl5Distance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl5Distance.Click += new System.EventHandler(this.lbl5Distance_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(85, 36);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 25;
            this.txtSpeed.TextChanged += new System.EventHandler(this.txtSpeed_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 107);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(111, 55);
            this.btnCalc.TabIndex = 24;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // DistanceTraveled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 179);
            this.Controls.Add(this.lbl12DistanceText);
            this.Controls.Add(this.lbl8DistanceText);
            this.Controls.Add(this.lbl5DistanceText);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbl12Distance);
            this.Controls.Add(this.lbl8Distance);
            this.Controls.Add(this.lbl5Distance);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnCalc);
            this.Name = "DistanceTraveled";
            this.Text = "DistanceTraveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl12DistanceText;
        private System.Windows.Forms.Label lbl8DistanceText;
        private System.Windows.Forms.Label lbl5DistanceText;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbl12Distance;
        private System.Windows.Forms.Label lbl8Distance;
        private System.Windows.Forms.Label lbl5Distance;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button btnCalc;
    }
}