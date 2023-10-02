namespace CompleteBloodCount
{
    partial class PersonReg
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
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.btnNextBC = new System.Windows.Forms.Button();
            this.lblResetPR = new System.Windows.Forms.LinkLabel();
            this.gbReg = new System.Windows.Forms.GroupBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbPregnancy = new System.Windows.Forms.CheckBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.birthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.gbReg.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFName
            // 
            this.tbFName.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFName.ForeColor = System.Drawing.Color.Gray;
            this.tbFName.Location = new System.Drawing.Point(23, 33);
            this.tbFName.MaxLength = 20;
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(210, 29);
            this.tbFName.TabIndex = 1;
            this.tbFName.Text = "First name";
            // 
            // tbLName
            // 
            this.tbLName.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLName.ForeColor = System.Drawing.Color.Gray;
            this.tbLName.Location = new System.Drawing.Point(23, 81);
            this.tbLName.MaxLength = 20;
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(210, 29);
            this.tbLName.TabIndex = 2;
            this.tbLName.Text = "Last name";
            // 
            // btnNextBC
            // 
            this.btnNextBC.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextBC.Location = new System.Drawing.Point(218, 318);
            this.btnNextBC.Name = "btnNextBC";
            this.btnNextBC.Size = new System.Drawing.Size(110, 30);
            this.btnNextBC.TabIndex = 3;
            this.btnNextBC.Text = "Next";
            this.btnNextBC.UseVisualStyleBackColor = true;
            this.btnNextBC.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lblResetPR
            // 
            this.lblResetPR.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lblResetPR.AutoSize = true;
            this.lblResetPR.Font = new System.Drawing.Font("Calibri", 13F);
            this.lblResetPR.LinkColor = System.Drawing.Color.Black;
            this.lblResetPR.Location = new System.Drawing.Point(100, 323);
            this.lblResetPR.Name = "lblResetPR";
            this.lblResetPR.Size = new System.Drawing.Size(51, 22);
            this.lblResetPR.TabIndex = 10;
            this.lblResetPR.TabStop = true;
            this.lblResetPR.Text = "Reset";
            this.lblResetPR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetlinkLabelPR_LinkClicked);
            // 
            // gbReg
            // 
            this.gbReg.Controls.Add(this.tbFName);
            this.gbReg.Controls.Add(this.tbLName);
            this.gbReg.Font = new System.Drawing.Font("Calibri", 12F);
            this.gbReg.Location = new System.Drawing.Point(72, 21);
            this.gbReg.Name = "gbReg";
            this.gbReg.Padding = new System.Windows.Forms.Padding(20);
            this.gbReg.Size = new System.Drawing.Size(256, 133);
            this.gbReg.TabIndex = 11;
            this.gbReg.TabStop = false;
            this.gbReg.Text = "Register";
            // 
            // gbGender
            // 
            this.gbGender.BackColor = System.Drawing.Color.Transparent;
            this.gbGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGender.Location = new System.Drawing.Point(72, 160);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(256, 66);
            this.gbGender.TabIndex = 12;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(170, 26);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 23);
            this.rbFemale.TabIndex = 12;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(22, 26);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 23);
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbPregnancy
            // 
            this.cbPregnancy.AutoSize = true;
            this.cbPregnancy.BackColor = System.Drawing.Color.Transparent;
            this.cbPregnancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPregnancy.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbPregnancy.Location = new System.Drawing.Point(236, 232);
            this.cbPregnancy.Name = "cbPregnancy";
            this.cbPregnancy.Size = new System.Drawing.Size(92, 23);
            this.cbPregnancy.TabIndex = 9;
            this.cbPregnancy.Text = "pregnancy";
            this.cbPregnancy.UseVisualStyleBackColor = false;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblBirthDay.Location = new System.Drawing.Point(72, 246);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(99, 17);
            this.lblBirthDay.TabIndex = 11;
            this.lblBirthDay.Text = "Your Birth Date:";
            // 
            // birthDayPicker
            // 
            this.birthDayPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthDayPicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDayPicker.Location = new System.Drawing.Point(72, 266);
            this.birthDayPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.birthDayPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDayPicker.Name = "birthDayPicker";
            this.birthDayPicker.Size = new System.Drawing.Size(256, 27);
            this.birthDayPicker.TabIndex = 10;
            this.birthDayPicker.Tag = "";
            this.birthDayPicker.Value = new System.DateTime(2022, 2, 28, 0, 0, 0, 0);
            // 
            // PersonReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 391);
            this.Controls.Add(this.cbPregnancy);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lblBirthDay);
            this.Controls.Add(this.gbReg);
            this.Controls.Add(this.birthDayPicker);
            this.Controls.Add(this.lblResetPR);
            this.Controls.Add(this.btnNextBC);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PersonReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbReg.ResumeLayout(false);
            this.gbReg.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Button btnNextBC;
        private System.Windows.Forms.LinkLabel lblResetPR;
        private System.Windows.Forms.GroupBox gbReg;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.CheckBox cbPregnancy;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.DateTimePicker birthDayPicker;
    }
}

