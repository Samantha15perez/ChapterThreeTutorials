namespace ProgrammingProblems
{
    partial class NameFormatter
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
            this.lblLast = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNameDisplay = new System.Windows.Forms.Label();
            this.btnLF = new System.Windows.Forms.Button();
            this.btnLFM = new System.Windows.Forms.Button();
            this.btnLFMP = new System.Windows.Forms.Button();
            this.btnFL = new System.Windows.Forms.Button();
            this.btnFML = new System.Windows.Forms.Button();
            this.btnPFML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(415, 34);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(58, 13);
            this.lblLast.TabIndex = 34;
            this.lblLast.Text = "Last Name";
            this.lblLast.Click += new System.EventHandler(this.lblLast_Click);
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(288, 34);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(69, 13);
            this.lblMiddle.TabIndex = 33;
            this.lblMiddle.Text = "Middle Name";
            this.lblMiddle.Click += new System.EventHandler(this.lblMiddle_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(171, 34);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(57, 13);
            this.lblFirst.TabIndex = 32;
            this.lblFirst.Text = "First Name";
            this.lblFirst.Click += new System.EventHandler(this.lblFirst_Click);
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(70, 34);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(27, 13);
            this.lblPrefix.TabIndex = 31;
            this.lblPrefix.Text = "Title";
            this.lblPrefix.Click += new System.EventHandler(this.lblPrefix_Click);
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(400, 51);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(89, 20);
            this.txtLast.TabIndex = 30;
            this.txtLast.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            // 
            // txtMiddle
            // 
            this.txtMiddle.Location = new System.Drawing.Point(270, 51);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(117, 20);
            this.txtMiddle.TabIndex = 29;
            this.txtMiddle.TextChanged += new System.EventHandler(this.txtMiddle_TextChanged);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(141, 51);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(117, 20);
            this.txtFirst.TabIndex = 28;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(41, 51);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(89, 20);
            this.txtPrefix.TabIndex = 27;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(264, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 46);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 46);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNameDisplay
            // 
            this.lblNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameDisplay.Location = new System.Drawing.Point(41, 97);
            this.lblNameDisplay.Name = "lblNameDisplay";
            this.lblNameDisplay.Size = new System.Drawing.Size(448, 27);
            this.lblNameDisplay.TabIndex = 24;
            this.lblNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameDisplay.Click += new System.EventHandler(this.lblNameDisplay_Click);
            // 
            // btnLF
            // 
            this.btnLF.Location = new System.Drawing.Point(326, 211);
            this.btnLF.Name = "btnLF";
            this.btnLF.Size = new System.Drawing.Size(111, 46);
            this.btnLF.TabIndex = 23;
            this.btnLF.Text = "Last, First";
            this.btnLF.UseVisualStyleBackColor = true;
            this.btnLF.Click += new System.EventHandler(this.btnLF_Click);
            // 
            // btnLFM
            // 
            this.btnLFM.Location = new System.Drawing.Point(209, 211);
            this.btnLFM.Name = "btnLFM";
            this.btnLFM.Size = new System.Drawing.Size(111, 46);
            this.btnLFM.TabIndex = 22;
            this.btnLFM.Text = "Last, First Middle";
            this.btnLFM.UseVisualStyleBackColor = true;
            this.btnLFM.Click += new System.EventHandler(this.btnLFM_Click);
            // 
            // btnLFMP
            // 
            this.btnLFMP.Location = new System.Drawing.Point(92, 211);
            this.btnLFMP.Name = "btnLFMP";
            this.btnLFMP.Size = new System.Drawing.Size(111, 46);
            this.btnLFMP.TabIndex = 21;
            this.btnLFMP.Text = "Last, First Middle, Prefix.";
            this.btnLFMP.UseVisualStyleBackColor = true;
            this.btnLFMP.Click += new System.EventHandler(this.btnLFMP_Click);
            // 
            // btnFL
            // 
            this.btnFL.Location = new System.Drawing.Point(326, 159);
            this.btnFL.Name = "btnFL";
            this.btnFL.Size = new System.Drawing.Size(111, 46);
            this.btnFL.TabIndex = 20;
            this.btnFL.Text = "First Last";
            this.btnFL.UseVisualStyleBackColor = true;
            this.btnFL.Click += new System.EventHandler(this.btnFL_Click);
            // 
            // btnFML
            // 
            this.btnFML.Location = new System.Drawing.Point(209, 159);
            this.btnFML.Name = "btnFML";
            this.btnFML.Size = new System.Drawing.Size(111, 46);
            this.btnFML.TabIndex = 19;
            this.btnFML.Text = "First Middle Last";
            this.btnFML.UseVisualStyleBackColor = true;
            this.btnFML.Click += new System.EventHandler(this.btnFML_Click);
            // 
            // btnPFML
            // 
            this.btnPFML.Location = new System.Drawing.Point(92, 159);
            this.btnPFML.Name = "btnPFML";
            this.btnPFML.Size = new System.Drawing.Size(111, 46);
            this.btnPFML.TabIndex = 18;
            this.btnPFML.Text = "Prefix. First Middle Last";
            this.btnPFML.UseVisualStyleBackColor = true;
            this.btnPFML.Click += new System.EventHandler(this.btnPFML_Click);
            // 
            // NameFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 347);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblMiddle);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNameDisplay);
            this.Controls.Add(this.btnLF);
            this.Controls.Add(this.btnLFM);
            this.Controls.Add(this.btnLFMP);
            this.Controls.Add(this.btnFL);
            this.Controls.Add(this.btnFML);
            this.Controls.Add(this.btnPFML);
            this.Name = "NameFormatter";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNameDisplay;
        private System.Windows.Forms.Button btnLF;
        private System.Windows.Forms.Button btnLFM;
        private System.Windows.Forms.Button btnLFMP;
        private System.Windows.Forms.Button btnFL;
        private System.Windows.Forms.Button btnFML;
        private System.Windows.Forms.Button btnPFML;
    }
}

