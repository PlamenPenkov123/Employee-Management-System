namespace Course_Project.Action_Forms
{
    partial class SalaryForm
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
            this.btnChangeSalary = new System.Windows.Forms.Button();
            this.txtBoxSearchByEGN = new System.Windows.Forms.TextBox();
            this.btnSearchByEGN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxProfession = new System.Windows.Forms.ComboBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChangeSalary
            // 
            this.btnChangeSalary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeSalary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSalary.Location = new System.Drawing.Point(0, 237);
            this.btnChangeSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeSalary.Name = "btnChangeSalary";
            this.btnChangeSalary.Size = new System.Drawing.Size(379, 66);
            this.btnChangeSalary.TabIndex = 0;
            this.btnChangeSalary.Text = "Change";
            this.btnChangeSalary.UseVisualStyleBackColor = false;
            this.btnChangeSalary.Click += new System.EventHandler(this.btnChangeSalary_Click);
            // 
            // txtBoxSearchByEGN
            // 
            this.txtBoxSearchByEGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchByEGN.Location = new System.Drawing.Point(15, 13);
            this.txtBoxSearchByEGN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSearchByEGN.MaxLength = 10;
            this.txtBoxSearchByEGN.Name = "txtBoxSearchByEGN";
            this.txtBoxSearchByEGN.Size = new System.Drawing.Size(168, 26);
            this.txtBoxSearchByEGN.TabIndex = 1;
            this.txtBoxSearchByEGN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearchByEGN_KeyPress);
            // 
            // btnSearchByEGN
            // 
            this.btnSearchByEGN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchByEGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByEGN.Location = new System.Drawing.Point(204, 12);
            this.btnSearchByEGN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchByEGN.Name = "btnSearchByEGN";
            this.btnSearchByEGN.Size = new System.Drawing.Size(166, 27);
            this.btnSearchByEGN.TabIndex = 2;
            this.btnSearchByEGN.Text = "Search";
            this.btnSearchByEGN.UseVisualStyleBackColor = false;
            this.btnSearchByEGN.Click += new System.EventHandler(this.btnSearchByEGN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(18, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Profession:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Middle Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name:";
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(163, 206);
            this.txtBoxSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(206, 20);
            this.txtBoxSalary.TabIndex = 26;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Enabled = false;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "Kitchen",
            "Office",
            "Garage",
            "Sanitation"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(163, 178);
            this.comboBoxDepartment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(206, 21);
            this.comboBoxDepartment.TabIndex = 25;
            // 
            // comboBoxProfession
            // 
            this.comboBoxProfession.Enabled = false;
            this.comboBoxProfession.FormattingEnabled = true;
            this.comboBoxProfession.Items.AddRange(new object[] {
            "Chef",
            "Builder",
            "Programmer",
            "Driver",
            "Pilot",
            "Gardener",
            "Barber"});
            this.comboBoxProfession.Location = new System.Drawing.Point(163, 148);
            this.comboBoxProfession.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxProfession.Name = "comboBoxProfession";
            this.comboBoxProfession.Size = new System.Drawing.Size(206, 21);
            this.comboBoxProfession.TabIndex = 24;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Enabled = false;
            this.txtBoxLastName.Location = new System.Drawing.Point(163, 118);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(206, 20);
            this.txtBoxLastName.TabIndex = 23;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Enabled = false;
            this.txtBoxFirstName.Location = new System.Drawing.Point(163, 58);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(206, 20);
            this.txtBoxFirstName.TabIndex = 21;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Enabled = false;
            this.txtBoxMiddleName.Location = new System.Drawing.Point(163, 88);
            this.txtBoxMiddleName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(206, 20);
            this.txtBoxMiddleName.TabIndex = 22;
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(379, 303);
            this.Controls.Add(this.txtBoxSalary);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxProfession);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchByEGN);
            this.Controls.Add(this.txtBoxSearchByEGN);
            this.Controls.Add(this.btnChangeSalary);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryForm";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeSalary;
        private System.Windows.Forms.Button btnSearchByEGN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBoxSalary;
        public System.Windows.Forms.ComboBox comboBoxDepartment;
        public System.Windows.Forms.ComboBox comboBoxProfession;
        public System.Windows.Forms.TextBox txtBoxLastName;
        public System.Windows.Forms.TextBox txtBoxFirstName;
        public System.Windows.Forms.TextBox txtBoxMiddleName;
        public System.Windows.Forms.TextBox txtBoxSearchByEGN;
    }
}