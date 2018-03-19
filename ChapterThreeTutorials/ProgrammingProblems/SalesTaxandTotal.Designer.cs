namespace ProgrammingProblems
{
    partial class SalesTaxandTotal
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTaxText = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblStateText = new System.Windows.Forms.Label();
            this.lblCountyText = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(116, 189);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(87, 38);
            this.btnCalc.TabIndex = 26;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(106, 6);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(100, 20);
            this.txtPurchase.TabIndex = 27;
            this.txtPurchase.TextChanged += new System.EventHandler(this.txtPurchase_TextChanged);
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Location = new System.Drawing.Point(226, 6);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(103, 19);
            this.lblState.TabIndex = 28;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // lblCounty
            // 
            this.lblCounty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCounty.Location = new System.Drawing.Point(226, 51);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(103, 19);
            this.lblCounty.TabIndex = 29;
            this.lblCounty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCounty.Click += new System.EventHandler(this.lblCounty_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(226, 142);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 19);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(214, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 37);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(314, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 38);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTaxText
            // 
            this.lblTaxText.AutoSize = true;
            this.lblTaxText.Location = new System.Drawing.Point(345, 101);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(52, 13);
            this.lblTaxText.TabIndex = 39;
            this.lblTaxText.Text = "Total Tax";
            this.lblTaxText.Click += new System.EventHandler(this.lblTaxText_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(12, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(91, 13);
            this.lblInstruction.TabIndex = 34;
            this.lblInstruction.Text = "Purchase Amount";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // lblStateText
            // 
            this.lblStateText.AutoSize = true;
            this.lblStateText.Location = new System.Drawing.Point(345, 8);
            this.lblStateText.Name = "lblStateText";
            this.lblStateText.Size = new System.Drawing.Size(53, 13);
            this.lblStateText.TabIndex = 35;
            this.lblStateText.Text = "State Tax";
            this.lblStateText.Click += new System.EventHandler(this.lblStateText_Click);
            // 
            // lblCountyText
            // 
            this.lblCountyText.AutoSize = true;
            this.lblCountyText.Location = new System.Drawing.Point(345, 54);
            this.lblCountyText.Name = "lblCountyText";
            this.lblCountyText.Size = new System.Drawing.Size(61, 13);
            this.lblCountyText.TabIndex = 36;
            this.lblCountyText.Text = "County Tax";
            this.lblCountyText.Click += new System.EventHandler(this.lblCountyText_Click);
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(345, 145);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(55, 13);
            this.lblTotalText.TabIndex = 37;
            this.lblTotalText.Text = "Sale Total";
            this.lblTotalText.Click += new System.EventHandler(this.lblTotalText_Click);
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(226, 98);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(103, 19);
            this.lblTax.TabIndex = 38;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // SalesTaxandTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 234);
            this.Controls.Add(this.lblTaxText);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblCountyText);
            this.Controls.Add(this.lblStateText);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.btnCalc);
            this.Name = "SalesTaxandTotal";
            this.Text = "SalesTaxandTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTaxText;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblStateText;
        private System.Windows.Forms.Label lblCountyText;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTax;
    }
}