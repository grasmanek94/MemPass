namespace MemPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lowercaseSelect = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.Label();
            this.nameEdit = new System.Windows.Forms.TextBox();
            this.sequenceEdit = new System.Windows.Forms.NumericUpDown();
            this.loginText = new System.Windows.Forms.Label();
            this.loginEdit = new System.Windows.Forms.TextBox();
            this.sequenceText = new System.Windows.Forms.Label();
            this.lengthText = new System.Windows.Forms.Label();
            this.lengthEdit = new System.Windows.Forms.NumericUpDown();
            this.masterPasswordText = new System.Windows.Forms.Label();
            this.masterPasswordEdit = new System.Windows.Forms.TextBox();
            this.masterPasswordRepeatText = new System.Windows.Forms.Label();
            this.masterPasswordRepeatEdit = new System.Windows.Forms.TextBox();
            this.optionsText = new System.Windows.Forms.Label();
            this.uppercaseSelect = new System.Windows.Forms.CheckBox();
            this.numberSelect = new System.Windows.Forms.CheckBox();
            this.specialSelect = new System.Windows.Forms.CheckBox();
            this.spaceSelect = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lowercaseSelect
            // 
            this.lowercaseSelect.AutoSize = true;
            this.lowercaseSelect.Checked = true;
            this.lowercaseSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercaseSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.lowercaseSelect.Location = new System.Drawing.Point(15, 259);
            this.lowercaseSelect.Name = "lowercaseSelect";
            this.lowercaseSelect.Size = new System.Drawing.Size(40, 17);
            this.lowercaseSelect.TabIndex = 7;
            this.lowercaseSelect.Text = "a-z";
            this.lowercaseSelect.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(12, 9);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(85, 13);
            this.nameText.TabIndex = 999;
            this.nameText.Text = "Name / Website";
            // 
            // nameEdit
            // 
            this.nameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEdit.Location = new System.Drawing.Point(12, 25);
            this.nameEdit.Name = "nameEdit";
            this.nameEdit.Size = new System.Drawing.Size(270, 20);
            this.nameEdit.TabIndex = 1;
            // 
            // sequenceEdit
            // 
            this.sequenceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sequenceEdit.Location = new System.Drawing.Point(12, 103);
            this.sequenceEdit.Name = "sequenceEdit";
            this.sequenceEdit.Size = new System.Drawing.Size(270, 20);
            this.sequenceEdit.TabIndex = 3;
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Location = new System.Drawing.Point(12, 48);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(33, 13);
            this.loginText.TabIndex = 1000;
            this.loginText.Text = "Login";
            // 
            // loginEdit
            // 
            this.loginEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginEdit.Location = new System.Drawing.Point(12, 64);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Size = new System.Drawing.Size(270, 20);
            this.loginEdit.TabIndex = 2;
            // 
            // sequenceText
            // 
            this.sequenceText.AutoSize = true;
            this.sequenceText.Location = new System.Drawing.Point(12, 87);
            this.sequenceText.Name = "sequenceText";
            this.sequenceText.Size = new System.Drawing.Size(267, 13);
            this.sequenceText.TabIndex = 1001;
            this.sequenceText.Text = "Sequence Number (eg when resetting password do +1)";
            // 
            // lengthText
            // 
            this.lengthText.AutoSize = true;
            this.lengthText.Location = new System.Drawing.Point(12, 126);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(136, 13);
            this.lengthText.TabIndex = 1002;
            this.lengthText.Text = "Maximum Password Length";
            // 
            // lengthEdit
            // 
            this.lengthEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthEdit.Location = new System.Drawing.Point(12, 142);
            this.lengthEdit.Name = "lengthEdit";
            this.lengthEdit.Size = new System.Drawing.Size(270, 20);
            this.lengthEdit.TabIndex = 4;
            this.lengthEdit.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // masterPasswordText
            // 
            this.masterPasswordText.AutoSize = true;
            this.masterPasswordText.Location = new System.Drawing.Point(12, 165);
            this.masterPasswordText.Name = "masterPasswordText";
            this.masterPasswordText.Size = new System.Drawing.Size(113, 13);
            this.masterPasswordText.TabIndex = 1003;
            this.masterPasswordText.Text = "Your Master Password";
            // 
            // masterPasswordEdit
            // 
            this.masterPasswordEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterPasswordEdit.Location = new System.Drawing.Point(12, 181);
            this.masterPasswordEdit.Name = "masterPasswordEdit";
            this.masterPasswordEdit.PasswordChar = '•';
            this.masterPasswordEdit.Size = new System.Drawing.Size(270, 20);
            this.masterPasswordEdit.TabIndex = 5;
            // 
            // masterPasswordRepeatText
            // 
            this.masterPasswordRepeatText.AutoSize = true;
            this.masterPasswordRepeatText.Location = new System.Drawing.Point(12, 204);
            this.masterPasswordRepeatText.Name = "masterPasswordRepeatText";
            this.masterPasswordRepeatText.Size = new System.Drawing.Size(152, 13);
            this.masterPasswordRepeatText.TabIndex = 1004;
            this.masterPasswordRepeatText.Text = "Your Master Password (repeat)";
            // 
            // masterPasswordRepeatEdit
            // 
            this.masterPasswordRepeatEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterPasswordRepeatEdit.Location = new System.Drawing.Point(12, 220);
            this.masterPasswordRepeatEdit.Name = "masterPasswordRepeatEdit";
            this.masterPasswordRepeatEdit.PasswordChar = '•';
            this.masterPasswordRepeatEdit.Size = new System.Drawing.Size(270, 20);
            this.masterPasswordRepeatEdit.TabIndex = 6;
            // 
            // optionsText
            // 
            this.optionsText.AutoSize = true;
            this.optionsText.Location = new System.Drawing.Point(12, 243);
            this.optionsText.Name = "optionsText";
            this.optionsText.Size = new System.Drawing.Size(92, 13);
            this.optionsText.TabIndex = 1005;
            this.optionsText.Text = "Additional Options";
            // 
            // uppercaseSelect
            // 
            this.uppercaseSelect.AutoSize = true;
            this.uppercaseSelect.Checked = true;
            this.uppercaseSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercaseSelect.Location = new System.Drawing.Point(82, 259);
            this.uppercaseSelect.Name = "uppercaseSelect";
            this.uppercaseSelect.Size = new System.Drawing.Size(43, 17);
            this.uppercaseSelect.TabIndex = 8;
            this.uppercaseSelect.Text = "A-Z";
            this.uppercaseSelect.UseVisualStyleBackColor = true;
            // 
            // numberSelect
            // 
            this.numberSelect.AutoSize = true;
            this.numberSelect.Checked = true;
            this.numberSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numberSelect.Location = new System.Drawing.Point(143, 259);
            this.numberSelect.Name = "numberSelect";
            this.numberSelect.Size = new System.Drawing.Size(41, 17);
            this.numberSelect.TabIndex = 9;
            this.numberSelect.Text = "0-9";
            this.numberSelect.UseVisualStyleBackColor = true;
            // 
            // specialSelect
            // 
            this.specialSelect.AutoSize = true;
            this.specialSelect.Checked = true;
            this.specialSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.specialSelect.Location = new System.Drawing.Point(15, 282);
            this.specialSelect.Name = "specialSelect";
            this.specialSelect.Size = new System.Drawing.Size(61, 17);
            this.specialSelect.TabIndex = 10;
            this.specialSelect.Text = "Special";
            this.specialSelect.UseVisualStyleBackColor = true;
            // 
            // spaceSelect
            // 
            this.spaceSelect.AutoSize = true;
            this.spaceSelect.Location = new System.Drawing.Point(82, 282);
            this.spaceSelect.Name = "spaceSelect";
            this.spaceSelect.Size = new System.Drawing.Size(57, 17);
            this.spaceSelect.TabIndex = 11;
            this.spaceSelect.Text = "Space";
            this.spaceSelect.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 2000;
            this.button2.Text = "EXIT APP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 341);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.spaceSelect);
            this.Controls.Add(this.specialSelect);
            this.Controls.Add(this.numberSelect);
            this.Controls.Add(this.uppercaseSelect);
            this.Controls.Add(this.optionsText);
            this.Controls.Add(this.masterPasswordRepeatEdit);
            this.Controls.Add(this.masterPasswordRepeatText);
            this.Controls.Add(this.masterPasswordEdit);
            this.Controls.Add(this.masterPasswordText);
            this.Controls.Add(this.lengthEdit);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.sequenceText);
            this.Controls.Add(this.loginEdit);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.sequenceEdit);
            this.Controls.Add(this.nameEdit);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lowercaseSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 380);
            this.MinimumSize = new System.Drawing.Size(310, 380);
            this.Name = "Form1";
            this.Text = "MemPass";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sequenceEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lowercaseSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.TextBox nameEdit;
        private System.Windows.Forms.NumericUpDown sequenceEdit;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox loginEdit;
        private System.Windows.Forms.Label sequenceText;
        private System.Windows.Forms.Label lengthText;
        private System.Windows.Forms.NumericUpDown lengthEdit;
        private System.Windows.Forms.Label masterPasswordText;
        private System.Windows.Forms.TextBox masterPasswordEdit;
        private System.Windows.Forms.Label masterPasswordRepeatText;
        private System.Windows.Forms.TextBox masterPasswordRepeatEdit;
        private System.Windows.Forms.Label optionsText;
        private System.Windows.Forms.CheckBox uppercaseSelect;
        private System.Windows.Forms.CheckBox numberSelect;
        private System.Windows.Forms.CheckBox specialSelect;
        private System.Windows.Forms.CheckBox spaceSelect;
        private System.Windows.Forms.Button button2;
    }
}

