namespace Time_Table_Management_System
{
    partial class ManageSubjects
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
            this.button4 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridSubjects = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numericEvaluationHours = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericLabHours = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericTuteHours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericLecHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxSubCode = new System.Windows.Forms.TextBox();
            this.textBoxSubName = new System.Windows.Forms.TextBox();
            this.radioButtonSem2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSem1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOfferdYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEvaluationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLabHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTuteHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLecHours)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(2, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 20);
            this.button4.TabIndex = 13;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Info;
            this.title.Location = new System.Drawing.Point(87, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(180, 26);
            this.title.TabIndex = 14;
            this.title.Text = "Manage Subjects";
            // 
            // dataGridSubjects
            // 
            this.dataGridSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSubjects.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubjects.Location = new System.Drawing.Point(23, 67);
            this.dataGridSubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridSubjects.Name = "dataGridSubjects";
            this.dataGridSubjects.ReadOnly = true;
            this.dataGridSubjects.RowHeadersWidth = 51;
            this.dataGridSubjects.RowTemplate.Height = 24;
            this.dataGridSubjects.Size = new System.Drawing.Size(509, 125);
            this.dataGridSubjects.TabIndex = 5;
            this.dataGridSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSubjects_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(537, 143);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(537, 105);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(537, 67);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 32);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // numericEvaluationHours
            // 
            this.numericEvaluationHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericEvaluationHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEvaluationHours.Location = new System.Drawing.Point(565, 311);
            this.numericEvaluationHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericEvaluationHours.Name = "numericEvaluationHours";
            this.numericEvaluationHours.Size = new System.Drawing.Size(59, 23);
            this.numericEvaluationHours.TabIndex = 69;
            this.numericEvaluationHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(394, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Number of Evaluation Hours";
            // 
            // numericLabHours
            // 
            this.numericLabHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericLabHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericLabHours.Location = new System.Drawing.Point(565, 276);
            this.numericLabHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericLabHours.Name = "numericLabHours";
            this.numericLabHours.Size = new System.Drawing.Size(59, 23);
            this.numericLabHours.TabIndex = 67;
            this.numericLabHours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(394, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Number of Lab Hours";
            // 
            // numericTuteHours
            // 
            this.numericTuteHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericTuteHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTuteHours.Location = new System.Drawing.Point(565, 242);
            this.numericTuteHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericTuteHours.Name = "numericTuteHours";
            this.numericTuteHours.Size = new System.Drawing.Size(59, 23);
            this.numericTuteHours.TabIndex = 65;
            this.numericTuteHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(394, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Number of Tutorial Hours";
            // 
            // numericLecHours
            // 
            this.numericLecHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericLecHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericLecHours.Location = new System.Drawing.Point(566, 209);
            this.numericLecHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericLecHours.Name = "numericLecHours";
            this.numericLecHours.Size = new System.Drawing.Size(59, 23);
            this.numericLecHours.TabIndex = 63;
            this.numericLecHours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBoxSubCode
            // 
            this.textBoxSubCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubCode.Location = new System.Drawing.Point(149, 311);
            this.textBoxSubCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubCode.Name = "textBoxSubCode";
            this.textBoxSubCode.Size = new System.Drawing.Size(187, 23);
            this.textBoxSubCode.TabIndex = 62;
            // 
            // textBoxSubName
            // 
            this.textBoxSubName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubName.Location = new System.Drawing.Point(149, 276);
            this.textBoxSubName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubName.Name = "textBoxSubName";
            this.textBoxSubName.Size = new System.Drawing.Size(187, 23);
            this.textBoxSubName.TabIndex = 61;
            // 
            // radioButtonSem2
            // 
            this.radioButtonSem2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonSem2.AutoSize = true;
            this.radioButtonSem2.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButtonSem2.Location = new System.Drawing.Point(251, 245);
            this.radioButtonSem2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSem2.Name = "radioButtonSem2";
            this.radioButtonSem2.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSem2.TabIndex = 60;
            this.radioButtonSem2.TabStop = true;
            this.radioButtonSem2.Text = "2st Semester";
            this.radioButtonSem2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSem1
            // 
            this.radioButtonSem1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonSem1.AutoSize = true;
            this.radioButtonSem1.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButtonSem1.Location = new System.Drawing.Point(149, 245);
            this.radioButtonSem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSem1.Name = "radioButtonSem1";
            this.radioButtonSem1.Size = new System.Drawing.Size(86, 17);
            this.radioButtonSem1.TabIndex = 59;
            this.radioButtonSem1.TabStop = true;
            this.radioButtonSem1.Text = "1st Semester";
            this.radioButtonSem1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(396, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Number of Lecture Hours";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(36, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Subject Code";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(36, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(36, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Offerd Semester";
            // 
            // comboBoxOfferdYear
            // 
            this.comboBoxOfferdYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBoxOfferdYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfferdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOfferdYear.FormattingEnabled = true;
            this.comboBoxOfferdYear.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.comboBoxOfferdYear.Location = new System.Drawing.Point(151, 208);
            this.comboBoxOfferdYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxOfferdYear.Name = "comboBoxOfferdYear";
            this.comboBoxOfferdYear.Size = new System.Drawing.Size(187, 25);
            this.comboBoxOfferdYear.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(38, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Offerd Year";
            // 
            // ManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.numericEvaluationHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericLabHours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericTuteHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericLecHours);
            this.Controls.Add(this.textBoxSubCode);
            this.Controls.Add(this.textBoxSubName);
            this.Controls.Add(this.radioButtonSem2);
            this.Controls.Add(this.radioButtonSem1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOfferdYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridSubjects);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageSubjects";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEvaluationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLabHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTuteHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLecHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridSubjects;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numericEvaluationHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericLabHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericTuteHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericLecHours;
        private System.Windows.Forms.TextBox textBoxSubCode;
        private System.Windows.Forms.TextBox textBoxSubName;
        private System.Windows.Forms.RadioButton radioButtonSem2;
        private System.Windows.Forms.RadioButton radioButtonSem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOfferdYear;
        private System.Windows.Forms.Label label1;
    }
}