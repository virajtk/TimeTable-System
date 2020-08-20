namespace Time_Table_Management_System.Lecturers
{
    partial class ManageLecturers
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
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridLecturers = new System.Windows.Forms.DataGridView();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCenter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLecturerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLecturers)).BeginInit();
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
            this.button1.TabIndex = 16;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Info;
            this.title.Location = new System.Drawing.Point(116, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(261, 34);
            this.title.TabIndex = 15;
            this.title.Text = "Manage Lecturers";
            // 
            // dataGridLecturers
            // 
            this.dataGridLecturers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLecturers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLecturers.Location = new System.Drawing.Point(56, 92);
            this.dataGridLecturers.Name = "dataGridLecturers";
            this.dataGridLecturers.RowHeadersWidth = 51;
            this.dataGridLecturers.RowTemplate.Height = 24;
            this.dataGridLecturers.Size = new System.Drawing.Size(618, 131);
            this.dataGridLecturers.TabIndex = 17;
            // 
            // textBoxRank
            // 
            this.textBoxRank.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRank.Location = new System.Drawing.Point(573, 382);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.ReadOnly = true;
            this.textBoxRank.Size = new System.Drawing.Size(222, 27);
            this.textBoxRank.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(447, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Rank";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.comboBoxLevel.Location = new System.Drawing.Point(573, 339);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(222, 28);
            this.comboBoxLevel.TabIndex = 43;
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.comboBoxBuilding.Location = new System.Drawing.Point(573, 295);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(222, 28);
            this.comboBoxBuilding.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(447, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Building";
            // 
            // comboBoxCenter
            // 
            this.comboBoxCenter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.comboBoxCenter.Location = new System.Drawing.Point(573, 251);
            this.comboBoxCenter.Name = "comboBoxCenter";
            this.comboBoxCenter.Size = new System.Drawing.Size(222, 28);
            this.comboBoxCenter.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(447, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Center";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartment.Location = new System.Drawing.Point(191, 380);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(222, 27);
            this.textBoxDepartment.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(52, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Department";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.comboBoxFaculty.Location = new System.Drawing.Point(191, 337);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(222, 28);
            this.comboBoxFaculty.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(52, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Faculty";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(191, 294);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(222, 27);
            this.textBoxEmployeeID.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(52, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Employee ID";
            // 
            // textBoxLecturerName
            // 
            this.textBoxLecturerName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxLecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLecturerName.Location = new System.Drawing.Point(191, 250);
            this.textBoxLecturerName.Name = "textBoxLecturerName";
            this.textBoxLecturerName.Size = new System.Drawing.Size(222, 27);
            this.textBoxLecturerName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(52, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Lecturer Name";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(447, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Level";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(703, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(703, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(703, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Time_Table_Management_System.Properties.Resources.generate;
            this.button2.Location = new System.Drawing.Point(801, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 35);
            this.button2.TabIndex = 50;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ManageLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxLevel);
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
            this.Controls.Add(this.dataGridLecturers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title);
            this.Name = "ManageLecturers";
            this.Text = "ManageLecturers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridLecturers;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLecturerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button2;
    }
}