namespace ProgrammingProblems
{
    partial class PaintJobEstimator
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
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLaborCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPaintCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLaborHours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBasePaint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGallonNumber = new System.Windows.Forms.Label();
            this.txtWallSpace = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Total Cost for Job";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCost.Location = new System.Drawing.Point(163, 201);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(130, 20);
            this.lblTotalCost.TabIndex = 54;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalCost.Click += new System.EventHandler(this.lblTotalCost_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Cost for Labor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblLaborCost
            // 
            this.lblLaborCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaborCost.Location = new System.Drawing.Point(163, 154);
            this.lblLaborCost.Name = "lblLaborCost";
            this.lblLaborCost.Size = new System.Drawing.Size(130, 20);
            this.lblLaborCost.TabIndex = 52;
            this.lblLaborCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLaborCost.Click += new System.EventHandler(this.lblLaborCost_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Cost for Paint";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPaintCost
            // 
            this.lblPaintCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaintCost.Location = new System.Drawing.Point(163, 111);
            this.lblPaintCost.Name = "lblPaintCost";
            this.lblPaintCost.Size = new System.Drawing.Size(130, 20);
            this.lblPaintCost.TabIndex = 50;
            this.lblPaintCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPaintCost.Click += new System.EventHandler(this.lblPaintCost_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Hours of Labor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblLaborHours
            // 
            this.lblLaborHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaborHours.Location = new System.Drawing.Point(163, 67);
            this.lblLaborHours.Name = "lblLaborHours";
            this.lblLaborHours.Size = new System.Drawing.Size(130, 20);
            this.lblLaborHours.TabIndex = 48;
            this.lblLaborHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLaborHours.Click += new System.EventHandler(this.lblLaborHours_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Paint Price (per gallon)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBasePaint
            // 
            this.txtBasePaint.Location = new System.Drawing.Point(12, 183);
            this.txtBasePaint.Name = "txtBasePaint";
            this.txtBasePaint.Size = new System.Drawing.Size(130, 20);
            this.txtBasePaint.TabIndex = 46;
            this.txtBasePaint.TextChanged += new System.EventHandler(this.txtBasePaint_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "# of Paint Gallons Needed";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Wall Space (in sq. ft.)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGallonNumber
            // 
            this.lblGallonNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGallonNumber.Location = new System.Drawing.Point(163, 24);
            this.lblGallonNumber.Name = "lblGallonNumber";
            this.lblGallonNumber.Size = new System.Drawing.Size(130, 20);
            this.lblGallonNumber.TabIndex = 43;
            this.lblGallonNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGallonNumber.Click += new System.EventHandler(this.lblGallonNumber_Click);
            // 
            // txtWallSpace
            // 
            this.txtWallSpace.Location = new System.Drawing.Point(12, 31);
            this.txtWallSpace.Name = "txtWallSpace";
            this.txtWallSpace.Size = new System.Drawing.Size(130, 20);
            this.txtWallSpace.TabIndex = 42;
            this.txtWallSpace.TextChanged += new System.EventHandler(this.txtWallSpace_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(202, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 46);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(107, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 46);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 238);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(89, 46);
            this.btnCalc.TabIndex = 38;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // PaintJobEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 305);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLaborCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPaintCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLaborHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBasePaint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGallonNumber);
            this.Controls.Add(this.txtWallSpace);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Name = "PaintJobEstimator";
            this.Text = "PaintJobEstimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLaborCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPaintCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLaborHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBasePaint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGallonNumber;
        private System.Windows.Forms.TextBox txtWallSpace;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
    }
}