namespace CompleteBloodCount
{
    partial class BloodCheck
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
            this.txtBoxWBC = new System.Windows.Forms.TextBox();
            this.txtBoxRBC = new System.Windows.Forms.TextBox();
            this.txtBoxHb = new System.Windows.Forms.TextBox();
            this.txtBoxHct = new System.Windows.Forms.TextBox();
            this.lblResetBC = new System.Windows.Forms.LinkLabel();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblWBC = new System.Windows.Forms.Label();
            this.lblRBC = new System.Windows.Forms.Label();
            this.lblHC = new System.Windows.Forms.Label();
            this.lblHematocrit = new System.Windows.Forms.Label();
            this.lblPlatelets = new System.Windows.Forms.Label();
            this.txtBoxPC = new System.Windows.Forms.TextBox();
            this.cbTests = new System.Windows.Forms.ComboBox();
            this.gbSelectBT = new System.Windows.Forms.GroupBox();
            this.gbValuesLeft = new System.Windows.Forms.GroupBox();
            this.gbValuesRight = new System.Windows.Forms.GroupBox();
            this.gbSelectBT.SuspendLayout();
            this.gbValuesLeft.SuspendLayout();
            this.gbValuesRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxWBC
            // 
            this.txtBoxWBC.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxWBC.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxWBC.Location = new System.Drawing.Point(8, 43);
            this.txtBoxWBC.MaxLength = 10;
            this.txtBoxWBC.Name = "txtBoxWBC";
            this.txtBoxWBC.Size = new System.Drawing.Size(126, 28);
            this.txtBoxWBC.TabIndex = 0;
            this.txtBoxWBC.Text = "Enter the value";
            // 
            // txtBoxRBC
            // 
            this.txtBoxRBC.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxRBC.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxRBC.Location = new System.Drawing.Point(8, 101);
            this.txtBoxRBC.MaxLength = 10;
            this.txtBoxRBC.Name = "txtBoxRBC";
            this.txtBoxRBC.Size = new System.Drawing.Size(126, 28);
            this.txtBoxRBC.TabIndex = 1;
            this.txtBoxRBC.Text = "Enter the value";
            // 
            // txtBoxHb
            // 
            this.txtBoxHb.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxHb.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxHb.Location = new System.Drawing.Point(8, 160);
            this.txtBoxHb.MaxLength = 10;
            this.txtBoxHb.Name = "txtBoxHb";
            this.txtBoxHb.Size = new System.Drawing.Size(126, 28);
            this.txtBoxHb.TabIndex = 2;
            this.txtBoxHb.Text = "Enter the value";
            // 
            // txtBoxHct
            // 
            this.txtBoxHct.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxHct.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxHct.Location = new System.Drawing.Point(8, 43);
            this.txtBoxHct.MaxLength = 10;
            this.txtBoxHct.Name = "txtBoxHct";
            this.txtBoxHct.Size = new System.Drawing.Size(126, 28);
            this.txtBoxHct.TabIndex = 3;
            this.txtBoxHct.Text = "Enter the value";
            // 
            // lblResetBC
            // 
            this.lblResetBC.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lblResetBC.AutoSize = true;
            this.lblResetBC.Font = new System.Drawing.Font("Calibri", 13F);
            this.lblResetBC.LinkColor = System.Drawing.Color.Black;
            this.lblResetBC.Location = new System.Drawing.Point(99, 352);
            this.lblResetBC.Name = "lblResetBC";
            this.lblResetBC.Size = new System.Drawing.Size(51, 22);
            this.lblResetBC.TabIndex = 11;
            this.lblResetBC.TabStop = true;
            this.lblResetBC.Text = "Reset";
            this.lblResetBC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblResetBC_LinkClicked);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResult.Location = new System.Drawing.Point(216, 347);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(110, 30);
            this.btnResult.TabIndex = 10;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblWBC
            // 
            this.lblWBC.AutoSize = true;
            this.lblWBC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWBC.Location = new System.Drawing.Point(8, 25);
            this.lblWBC.Name = "lblWBC";
            this.lblWBC.Size = new System.Drawing.Size(105, 15);
            this.lblWBC.TabIndex = 12;
            this.lblWBC.Text = "White Blood Cells";
            // 
            // lblRBC
            // 
            this.lblRBC.AutoSize = true;
            this.lblRBC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRBC.Location = new System.Drawing.Point(8, 83);
            this.lblRBC.Name = "lblRBC";
            this.lblRBC.Size = new System.Drawing.Size(92, 15);
            this.lblRBC.TabIndex = 13;
            this.lblRBC.Text = "Red Blood Cells";
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHC.Location = new System.Drawing.Point(8, 142);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(118, 15);
            this.lblHC.TabIndex = 14;
            this.lblHC.Text = "Hemoglobin Content";
            // 
            // lblHematocrit
            // 
            this.lblHematocrit.AutoSize = true;
            this.lblHematocrit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHematocrit.Location = new System.Drawing.Point(8, 25);
            this.lblHematocrit.Name = "lblHematocrit";
            this.lblHematocrit.Size = new System.Drawing.Size(68, 15);
            this.lblHematocrit.TabIndex = 15;
            this.lblHematocrit.Text = "Hematocrit";
            // 
            // lblPlatelets
            // 
            this.lblPlatelets.AutoSize = true;
            this.lblPlatelets.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlatelets.Location = new System.Drawing.Point(8, 83);
            this.lblPlatelets.Name = "lblPlatelets";
            this.lblPlatelets.Size = new System.Drawing.Size(55, 15);
            this.lblPlatelets.TabIndex = 20;
            this.lblPlatelets.Text = "Platelets";
            // 
            // txtBoxPC
            // 
            this.txtBoxPC.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPC.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxPC.Location = new System.Drawing.Point(8, 101);
            this.txtBoxPC.MaxLength = 10;
            this.txtBoxPC.Name = "txtBoxPC";
            this.txtBoxPC.Size = new System.Drawing.Size(126, 28);
            this.txtBoxPC.TabIndex = 16;
            this.txtBoxPC.Text = "Enter the value";
            // 
            // cbTests
            // 
            this.cbTests.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTests.FormattingEnabled = true;
            this.cbTests.Items.AddRange(new object[] {
            "CBC test"});
            this.cbTests.Location = new System.Drawing.Point(41, 29);
            this.cbTests.Name = "cbTests";
            this.cbTests.Size = new System.Drawing.Size(219, 27);
            this.cbTests.TabIndex = 21;
            this.cbTests.Text = "Please select test";
            this.cbTests.SelectedValueChanged += new System.EventHandler(this.cbTests_SelectedValueChanged);
            // 
            // gbSelectBT
            // 
            this.gbSelectBT.Controls.Add(this.cbTests);
            this.gbSelectBT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSelectBT.Location = new System.Drawing.Point(50, 23);
            this.gbSelectBT.Name = "gbSelectBT";
            this.gbSelectBT.Padding = new System.Windows.Forms.Padding(20);
            this.gbSelectBT.Size = new System.Drawing.Size(300, 79);
            this.gbSelectBT.TabIndex = 22;
            this.gbSelectBT.TabStop = false;
            this.gbSelectBT.Text = "Blood Test";
            // 
            // gbValuesLeft
            // 
            this.gbValuesLeft.Controls.Add(this.lblWBC);
            this.gbValuesLeft.Controls.Add(this.txtBoxWBC);
            this.gbValuesLeft.Controls.Add(this.txtBoxRBC);
            this.gbValuesLeft.Controls.Add(this.txtBoxHb);
            this.gbValuesLeft.Controls.Add(this.lblHC);
            this.gbValuesLeft.Controls.Add(this.lblRBC);
            this.gbValuesLeft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbValuesLeft.Location = new System.Drawing.Point(50, 108);
            this.gbValuesLeft.Name = "gbValuesLeft";
            this.gbValuesLeft.Padding = new System.Windows.Forms.Padding(5);
            this.gbValuesLeft.Size = new System.Drawing.Size(142, 211);
            this.gbValuesLeft.TabIndex = 23;
            this.gbValuesLeft.TabStop = false;
            this.gbValuesLeft.Text = "Values";
            // 
            // gbValuesRight
            // 
            this.gbValuesRight.Controls.Add(this.lblHematocrit);
            this.gbValuesRight.Controls.Add(this.txtBoxHct);
            this.gbValuesRight.Controls.Add(this.lblPlatelets);
            this.gbValuesRight.Controls.Add(this.txtBoxPC);
            this.gbValuesRight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbValuesRight.Location = new System.Drawing.Point(208, 108);
            this.gbValuesRight.Name = "gbValuesRight";
            this.gbValuesRight.Padding = new System.Windows.Forms.Padding(5);
            this.gbValuesRight.Size = new System.Drawing.Size(142, 211);
            this.gbValuesRight.TabIndex = 24;
            this.gbValuesRight.TabStop = false;
            this.gbValuesRight.Text = "Values";
            // 
            // BloodCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 414);
            this.Controls.Add(this.gbValuesRight);
            this.Controls.Add(this.gbValuesLeft);
            this.Controls.Add(this.gbSelectBT);
            this.Controls.Add(this.lblResetBC);
            this.Controls.Add(this.btnResult);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BloodCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter the value";
            this.gbSelectBT.ResumeLayout(false);
            this.gbValuesLeft.ResumeLayout(false);
            this.gbValuesLeft.PerformLayout();
            this.gbValuesRight.ResumeLayout(false);
            this.gbValuesRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxWBC;
        private System.Windows.Forms.TextBox txtBoxRBC;
        private System.Windows.Forms.TextBox txtBoxHb;
        private System.Windows.Forms.TextBox txtBoxHct;
        private System.Windows.Forms.TextBox txtBoxPC;
        private System.Windows.Forms.LinkLabel lblResetBC;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblWBC;
        private System.Windows.Forms.Label lblRBC;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.Label lblHematocrit;
        private System.Windows.Forms.Label lblPlatelets;
        private System.Windows.Forms.ComboBox cbTests;
        private System.Windows.Forms.GroupBox gbSelectBT;
        private System.Windows.Forms.GroupBox gbValuesLeft;
        private System.Windows.Forms.GroupBox gbValuesRight;
    }
}