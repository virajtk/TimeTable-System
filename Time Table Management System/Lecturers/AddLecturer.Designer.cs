namespace Time_Table_Management_System.Lecturers
{
    partial class AddLecturer
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.textBoxLecturerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCenter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGenerateRank = new System.Windows.Forms.Button();
            this.errorAddLecturer = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorAddLecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Info;
            this.title.Location = new System.Drawing.Point(116, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(192, 34);
            this.title.TabIndex = 13;
            this.title.Text = "Add Lecturer";
            // 
            // textBoxLecturerName
            // 
            this.textBoxLecturerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLecturerName.Location = new System.Drawing.Point(187, 105);
            this.textBoxLecturerName.Name = "textBoxLecturerName";
            this.textBoxLecturerName.Size = new System.Drawing.Size(222, 27);
            this.textBoxLecturerName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(48, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lecturer Name";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(187, 167);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(222, 27);
            this.textBoxEmployeeID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(48, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Employee ID";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.comboBoxFaculty.Location = new System.Drawing.Point(187, 232);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(222, 28);
            this.comboBoxFaculty.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(48, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Faculty";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartment.Location = new System.Drawing.Point(187, 294);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(222, 27);
            this.textBoxDepartment.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(48, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Department";
            // 
            // comboBoxCenter
            // 
            this.comboBoxCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCenter.FormattingEnabled = true;
            this.comboBoxCenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.comboBoxCenter.Location = new System.Drawing.Point(597, 104);
            this.comboBoxCenter.Name = "comboBoxCenter";
            this.comboBoxCenter.Size = new System.Drawing.Size(222, 28);
            this.comboBoxCenter.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(451, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Center";
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Items.AddRange(new object[] {
            "New building",
            "A-block",
            "B-block",
            "C-block",
            "D-block",
            "E-block"});
            this.comboBoxBuilding.Location = new System.Drawing.Point(597, 166);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(222, 28);
            this.comboBoxBuilding.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(451, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Building";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxLevel.Location = new System.Drawing.Point(597, 232);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(222, 28);
            this.comboBoxLevel.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(451, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Level";
            // 
            // textBoxRank
            // 
            this.textBoxRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRank.Location = new System.Drawing.Point(597, 294);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.ReadOnly = true;
            this.textBoxRank.Size = new System.Drawing.Size(222, 27);
            this.textBoxRank.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(451, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Rank";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(559, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(701, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerateRank
            // 
            this.btnGenerateRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateRank.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRank.Location = new System.Drawing.Point(332, 357);
            this.btnGenerateRank.Name = "btnGenerateRank";
            this.btnGenerateRank.Size = new System.Drawing.Size(205, 40);
            this.btnGenerateRank.TabIndex = 33;
            this.btnGenerateRank.Text = "Generate Rank";
            this.btnGenerateRank.UseVisualStyleBackColor = true;
            this.btnGenerateRank.Click += new System.EventHandler(this.btnGenerateRank_Click);
            // 
            // errorAddLecturer
            // 
            this.errorAddLecturer.ContainerControl = this;
            // 
            // AddLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.btnGenerateRank);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxBuilding);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCenter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLecturerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AddLecturer";
            this.Text = "AddLecturer";
            ((System.ComponentModel.ISupportInitialize)(this.errorAddLecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBoxLecturerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerateRank;
        private System.Windows.Forms.ErrorProvider errorAddLecturer;
    }
}