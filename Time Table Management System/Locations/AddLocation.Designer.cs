namespace Time_Table_Management_System.Locations
{
    partial class AddLocation
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuildName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBuildingName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonLectureHall = new System.Windows.Forms.RadioButton();
            this.radioButtonLaboratory = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBuildSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 20);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Info;
            this.title.Location = new System.Drawing.Point(87, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(150, 26);
            this.title.TabIndex = 14;
            this.title.Text = "Add Locations";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(37, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Building Name";
            // 
            // textBoxBuildName
            // 
            this.textBoxBuildName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBuildName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuildName.Location = new System.Drawing.Point(154, 86);
            this.textBoxBuildName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuildName.Name = "textBoxBuildName";
            this.textBoxBuildName.Size = new System.Drawing.Size(187, 23);
            this.textBoxBuildName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(37, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Rooms Building wise:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(37, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Building Name";
            // 
            // comboBoxBuildingName
            // 
            this.comboBoxBuildingName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxBuildingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuildingName.FormattingEnabled = true;
            this.comboBoxBuildingName.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.comboBoxBuildingName.Location = new System.Drawing.Point(154, 170);
            this.comboBoxBuildingName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuildingName.Name = "comboBoxBuildingName";
            this.comboBoxBuildingName.Size = new System.Drawing.Size(187, 25);
            this.comboBoxBuildingName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(37, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Room Name";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomName.Location = new System.Drawing.Point(154, 229);
            this.textBoxRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(187, 23);
            this.textBoxRoomName.TabIndex = 21;
            this.textBoxRoomName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(37, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Room Type";
            // 
            // radioButtonLectureHall
            // 
            this.radioButtonLectureHall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonLectureHall.AutoSize = true;
            this.radioButtonLectureHall.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButtonLectureHall.Location = new System.Drawing.Point(154, 276);
            this.radioButtonLectureHall.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLectureHall.Name = "radioButtonLectureHall";
            this.radioButtonLectureHall.Size = new System.Drawing.Size(82, 17);
            this.radioButtonLectureHall.TabIndex = 23;
            this.radioButtonLectureHall.TabStop = true;
            this.radioButtonLectureHall.Text = "Lecture Hall";
            this.radioButtonLectureHall.UseVisualStyleBackColor = true;
            // 
            // radioButtonLaboratory
            // 
            this.radioButtonLaboratory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonLaboratory.AutoSize = true;
            this.radioButtonLaboratory.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButtonLaboratory.Location = new System.Drawing.Point(255, 276);
            this.radioButtonLaboratory.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLaboratory.Name = "radioButtonLaboratory";
            this.radioButtonLaboratory.Size = new System.Drawing.Size(75, 17);
            this.radioButtonLaboratory.TabIndex = 24;
            this.radioButtonLaboratory.TabStop = true;
            this.radioButtonLaboratory.Text = "Laboratory";
            this.radioButtonLaboratory.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(434, 275);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(538, 275);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 32);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBuildSave
            // 
            this.btnBuildSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildSave.Location = new System.Drawing.Point(434, 81);
            this.btnBuildSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuildSave.Name = "btnBuildSave";
            this.btnBuildSave.Size = new System.Drawing.Size(90, 32);
            this.btnBuildSave.TabIndex = 28;
            this.btnBuildSave.Text = "Save";
            this.btnBuildSave.UseVisualStyleBackColor = true;
            // 
            // AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.btnBuildSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.radioButtonLaboratory);
            this.Controls.Add(this.radioButtonLectureHall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBuildingName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuildName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button1);
            this.Name = "AddLocation";
            this.Text = "AddLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuildName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBuildingName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonLectureHall;
        private System.Windows.Forms.RadioButton radioButtonLaboratory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBuildSave;
    }
}