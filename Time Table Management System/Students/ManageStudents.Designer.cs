﻿namespace Time_Table_Management_System.Students
{
    partial class ManageStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subgroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAcYear = new System.Windows.Forms.TextBox();
            this.comboBoxProgramme = new System.Windows.Forms.ComboBox();
            this.textBoxgroupId = new System.Windows.Forms.TextBox();
            this.textBoxSubGroup = new System.Windows.Forms.TextBox();
            this.numericGroupno = new System.Windows.Forms.NumericUpDown();
            this.numericSubGroup = new System.Windows.Forms.NumericUpDown();
            this.errorManageStudent = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGenerateIds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGroupno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSubGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManageStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 25);
            this.button4.TabIndex = 14;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Info;
            this.title.Location = new System.Drawing.Point(156, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(350, 34);
            this.title.TabIndex = 15;
            this.title.Text = "Manage Student Groups";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.acYear,
            this.programme,
            this.groupno,
            this.groupid,
            this.subgroupNo,
            this.subId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(31, 82);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(679, 154);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGrid_Selection);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // acYear
            // 
            this.acYear.HeaderText = "Academic Year and Sem";
            this.acYear.MinimumWidth = 6;
            this.acYear.Name = "acYear";
            this.acYear.Width = 125;
            // 
            // programme
            // 
            this.programme.HeaderText = "Programme";
            this.programme.MinimumWidth = 6;
            this.programme.Name = "programme";
            this.programme.Width = 125;
            // 
            // groupno
            // 
            this.groupno.HeaderText = "Group No";
            this.groupno.MinimumWidth = 6;
            this.groupno.Name = "groupno";
            this.groupno.Width = 125;
            // 
            // groupid
            // 
            this.groupid.HeaderText = "Group ID";
            this.groupid.MinimumWidth = 6;
            this.groupid.Name = "groupid";
            this.groupid.Width = 125;
            // 
            // subgroupNo
            // 
            this.subgroupNo.HeaderText = "SubGroup No";
            this.subgroupNo.MinimumWidth = 6;
            this.subgroupNo.Name = "subgroupNo";
            this.subgroupNo.Width = 125;
            // 
            // subId
            // 
            this.subId.HeaderText = "SubGroup ID";
            this.subId.MinimumWidth = 6;
            this.subId.Name = "subId";
            this.subId.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(716, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(716, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(716, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(24, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Academic Year & Semester";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(24, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Programme";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(24, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Group Number";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(429, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sub Group Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(429, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Group ID";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(429, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sub Group ID";
            // 
            // textBoxAcYear
            // 
            this.textBoxAcYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAcYear.Location = new System.Drawing.Point(251, 273);
            this.textBoxAcYear.Name = "textBoxAcYear";
            this.textBoxAcYear.Size = new System.Drawing.Size(135, 22);
            this.textBoxAcYear.TabIndex = 26;
            this.textBoxAcYear.TextChanged += new System.EventHandler(this.textBoxAcYear_TextChanged);
            // 
            // comboBoxProgramme
            // 
            this.comboBoxProgramme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxProgramme.FormattingEnabled = true;
            this.comboBoxProgramme.Items.AddRange(new object[] {
            "IT",
            "CSSE",
            "CSE",
            "DS",
            "CN"});
            this.comboBoxProgramme.Location = new System.Drawing.Point(251, 328);
            this.comboBoxProgramme.Name = "comboBoxProgramme";
            this.comboBoxProgramme.Size = new System.Drawing.Size(135, 24);
            this.comboBoxProgramme.TabIndex = 27;
            this.comboBoxProgramme.Tag = "";
            this.comboBoxProgramme.SelectedIndexChanged += new System.EventHandler(this.comboBoxProgramme_SelectedIndexChanged);
            // 
            // textBoxgroupId
            // 
            this.textBoxgroupId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxgroupId.Location = new System.Drawing.Point(639, 327);
            this.textBoxgroupId.Name = "textBoxgroupId";
            this.textBoxgroupId.Size = new System.Drawing.Size(135, 22);
            this.textBoxgroupId.TabIndex = 28;
            this.textBoxgroupId.TextChanged += new System.EventHandler(this.textBoxgroupId_TextChanged);
            // 
            // textBoxSubGroup
            // 
            this.textBoxSubGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSubGroup.Location = new System.Drawing.Point(639, 381);
            this.textBoxSubGroup.Name = "textBoxSubGroup";
            this.textBoxSubGroup.Size = new System.Drawing.Size(135, 22);
            this.textBoxSubGroup.TabIndex = 29;
            this.textBoxSubGroup.TextChanged += new System.EventHandler(this.textBoxSubGroup_TextChanged);
            // 
            // numericGroupno
            // 
            this.numericGroupno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericGroupno.Location = new System.Drawing.Point(251, 385);
            this.numericGroupno.Name = "numericGroupno";
            this.numericGroupno.Size = new System.Drawing.Size(135, 22);
            this.numericGroupno.TabIndex = 30;
            this.numericGroupno.ValueChanged += new System.EventHandler(this.numericGroupno_ValueChanged);
            // 
            // numericSubGroup
            // 
            this.numericSubGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericSubGroup.Location = new System.Drawing.Point(639, 273);
            this.numericSubGroup.Name = "numericSubGroup";
            this.numericSubGroup.Size = new System.Drawing.Size(135, 22);
            this.numericSubGroup.TabIndex = 31;
            this.numericSubGroup.ValueChanged += new System.EventHandler(this.numericSubGroup_ValueChanged);
            // 
            // errorManageStudent
            // 
            this.errorManageStudent.ContainerControl = this;
            // 
            // btnGenerateIds
            // 
            this.btnGenerateIds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateIds.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateIds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateIds.Image = global::Time_Table_Management_System.Properties.Resources.generate;
            this.btnGenerateIds.Location = new System.Drawing.Point(811, 372);
            this.btnGenerateIds.Name = "btnGenerateIds";
            this.btnGenerateIds.Size = new System.Drawing.Size(41, 35);
            this.btnGenerateIds.TabIndex = 51;
            this.btnGenerateIds.UseVisualStyleBackColor = false;
            this.btnGenerateIds.Click += new System.EventHandler(this.btnGenerateIds_Click);
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.btnGenerateIds);
            this.Controls.Add(this.numericSubGroup);
            this.Controls.Add(this.numericGroupno);
            this.Controls.Add(this.textBoxSubGroup);
            this.Controls.Add(this.textBoxgroupId);
            this.Controls.Add(this.comboBoxProgramme);
            this.Controls.Add(this.textBoxAcYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button4);
            this.Name = "ManageStudents";
            this.Text = "ManageStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGroupno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSubGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManageStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAcYear;
        private System.Windows.Forms.ComboBox comboBoxProgramme;
        private System.Windows.Forms.TextBox textBoxgroupId;
        private System.Windows.Forms.TextBox textBoxSubGroup;
        private System.Windows.Forms.NumericUpDown numericGroupno;
        private System.Windows.Forms.NumericUpDown numericSubGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn acYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn programme;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subgroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subId;
        private System.Windows.Forms.ErrorProvider errorManageStudent;
        private System.Windows.Forms.Button btnGenerateIds;
    }
}