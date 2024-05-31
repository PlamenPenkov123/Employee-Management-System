namespace Course_Project.Action_Forms
{
    partial class HireForm
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
            this.btnHire = new System.Windows.Forms.Button();
            this.lblEGN = new System.Windows.Forms.Label();
            this.txtBoxEGN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxProfession = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnHire
            // 
            this.btnHire.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHire.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHire.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHire.Location = new System.Drawing.Point(0, 255);
            this.btnHire.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(349, 54);
            this.btnHire.TabIndex = 0;
            this.btnHire.Text = "HIRE";
            this.btnHire.UseVisualStyleBackColor = false;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // lblEGN
            // 
            this.lblEGN.AutoSize = true;
            this.lblEGN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEGN.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEGN.Location = new System.Drawing.Point(16, 14);
            this.lblEGN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblEGN.Name = "lblEGN";
            this.lblEGN.Size = new System.Drawing.Size(50, 20);
            this.lblEGN.TabIndex = 1;
            this.lblEGN.Text = "EGN:";
            // 
            // txtBoxEGN
            // 
            this.txtBoxEGN.Location = new System.Drawing.Point(161, 15);
            this.txtBoxEGN.MaxLength = 10;
            this.txtBoxEGN.Name = "txtBoxEGN";
            this.txtBoxEGN.Size = new System.Drawing.Size(177, 21);
            this.txtBoxEGN.TabIndex = 1;
            this.txtBoxEGN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEGN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profession:";
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(161, 75);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(177, 21);
            this.txtBoxMiddleName.TabIndex = 3;
            this.txtBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFirstName_KeyPress);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(161, 45);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(177, 21);
            this.txtBoxFirstName.TabIndex = 2;
            this.txtBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFirstName_KeyPress);
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(161, 105);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(177, 21);
            this.txtBoxLastName.TabIndex = 4;
            this.txtBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFirstName_KeyPress);
            // 
            // comboBoxProfession
            // 
            this.comboBoxProfession.FormattingEnabled = true;
            this.comboBoxProfession.Items.AddRange(new object[] {
            "Chef",
            "Builder",
            "Programmer",
            "Driver",
            "Pilot",
            "Gardener",
            "Barber"});
            this.comboBoxProfession.Location = new System.Drawing.Point(161, 135);
            this.comboBoxProfession.Name = "comboBoxProfession";
            this.comboBoxProfession.Size = new System.Drawing.Size(177, 23);
            this.comboBoxProfession.TabIndex = 5;
            this.comboBoxProfession.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxProfession_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(16, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Department:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "Kitchen",
            "Office",
            "Garage",
            "Sanitation"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(161, 165);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(177, 23);
            this.comboBoxDepartment.TabIndex = 6;
            this.comboBoxDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxProfession_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(16, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salary:";
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(161, 193);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(177, 21);
            this.txtBoxSalary.TabIndex = 13;
            this.txtBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSalary_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(88, 224);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 21);
            this.dateTimePicker.TabIndex = 15;
            // 
            // HireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(349, 309);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProfession);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEGN);
            this.Controls.Add(this.lblEGN);
            this.Controls.Add(this.btnHire);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "HireForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HireForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Label lblEGN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtBoxEGN;
        public System.Windows.Forms.TextBox txtBoxMiddleName;
        public System.Windows.Forms.TextBox txtBoxFirstName;
        public System.Windows.Forms.TextBox txtBoxLastName;
        public System.Windows.Forms.ComboBox comboBoxProfession;
        public System.Windows.Forms.ComboBox comboBoxDepartment;
        public System.Windows.Forms.TextBox txtBoxSalary;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}