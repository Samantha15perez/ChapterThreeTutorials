namespace ProgrammingProblems
{
    partial class TipTaxandTotal
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
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTaxText = new System.Windows.Forms.Label();
            this.lblTipText = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtMeal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(329, 104);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(31, 13);
            this.lblTotalText.TabIndex = 23;
            this.lblTotalText.Text = "Total";
            this.lblTotalText.Click += new System.EventHandler(this.lblTotalText_Click);
            // 
            // lblTaxText
            // 
            this.lblTaxText.AutoSize = true;
            this.lblTaxText.Location = new System.Drawing.Point(329, 73);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(25, 13);
            this.lblTaxText.TabIndex = 22;
            this.lblTaxText.Text = "Tax";
            this.lblTaxText.Click += new System.EventHandler(this.lblTaxText_Click);
            // 
            // lblTipText
            // 
            this.lblTipText.AutoSize = true;
            this.lblTipText.Location = new System.Drawing.Point(329, 35);
            this.lblTipText.Name = "lblTipText";
            this.lblTipText.Size = new System.Drawing.Size(22, 13);
            this.lblTipText.TabIndex = 21;
            this.lblTipText.Text = "Tip";
            this.lblTipText.Click += new System.EventHandler(this.lblTipText_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(24, 73);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(57, 13);
            this.lblInstruction.TabIndex = 20;
            this.lblInstruction.Text = "Meal Price";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 51);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 51);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(210, 101);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 19);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(210, 70);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(103, 19);
            this.lblTax.TabIndex = 15;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // lblTip
            // 
            this.lblTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTip.Location = new System.Drawing.Point(210, 37);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(103, 19);
            this.lblTip.TabIndex = 14;
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTip.Click += new System.EventHandler(this.lblTip_Click);
            // 
            // txtMeal
            // 
            this.txtMeal.Location = new System.Drawing.Point(91, 70);
            this.txtMeal.Name = "txtMeal";
            this.txtMeal.Size = new System.Drawing.Size(100, 20);
            this.txtMeal.TabIndex = 13;
            this.txtMeal.TextChanged += new System.EventHandler(this.txtMeal_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(43, 143);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(97, 51);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // TipTaxandTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 239);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblTaxText);
            this.Controls.Add(this.lblTipText);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtMeal);
            this.Controls.Add(this.btnCalc);
            this.Name = "TipTaxandTotal";
            this.Text = "TipTaxandTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTaxText;
        private System.Windows.Forms.Label lblTipText;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtMeal;
        private System.Windows.Forms.Button btnCalc;
    }
}