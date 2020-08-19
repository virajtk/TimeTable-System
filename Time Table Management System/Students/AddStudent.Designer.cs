﻿namespace Time_Table_Management_System.Students
{
    partial class AddStudent
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
            this.title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYearSem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProgramme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGroupNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGroupID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSubGroupNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSubGroupID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btngenerateIDs = new System.Windows.Forms.Button();
            this.errorStudent = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorStudent)).BeginInit();
            this.SuspendLayout();
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
            this.title.Size = new System.Drawing.Size(292, 34);
            this.title.TabIndex = 2;
            this.title.Text = "Add Student Groups";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(54, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Academic Year & Semester";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxYearSem
            // 
            this.textBoxYearSem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxYearSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYearSem.Location = new System.Drawing.Point(289, 109);
            this.textBoxYearSem.Name = "textBoxYearSem";
            this.textBoxYearSem.Size = new System.Drawing.Size(219, 27);
            this.textBoxYearSem.TabIndex = 15;
            this.textBoxYearSem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(54, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Programme";
            // 
            // comboBoxProgramme
            // 
            this.comboBoxProgramme.FormattingEnabled = true;
            this.comboBoxProgramme.Items.AddRange(new object[] {
            "IT",
            "CSSE",
            "CSE",
            "DS",
            "CN"});
            this.comboBoxProgramme.Location = new System.Drawing.Point(299, 169);
            this.comboBoxProgramme.Name = "comboBoxProgramme";
            this.comboBoxProgramme.Size = new System.Drawing.Size(219, 24);
            this.comboBoxProgramme.TabIndex = 17;
            this.comboBoxProgramme.Tag = "";
            this.comboBoxProgramme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(54, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Group Number";
            // 
            // textBoxGroupNo
            // 
            this.textBoxGroupNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGroupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupNo.Location = new System.Drawing.Point(289, 213);
            this.textBoxGroupNo.Name = "textBoxGroupNo";
            this.textBoxGroupNo.Size = new System.Drawing.Size(219, 27);
            this.textBoxGroupNo.TabIndex = 19;
            this.textBoxGroupNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(73, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Group ID";
            // 
            // textBoxGroupID
            // 
            this.textBoxGroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupID.Location = new System.Drawing.Point(289, 325);
            this.textBoxGroupID.Name = "textBoxGroupID";
            this.textBoxGroupID.ReadOnly = true;
            this.textBoxGroupID.Size = new System.Drawing.Size(219, 27);
            this.textBoxGroupID.TabIndex = 21;
            this.textBoxGroupID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(63, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sub Group Number";
            // 
            // textBoxSubGroupNo
            // 
            this.textBoxSubGroupNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSubGroupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubGroupNo.Location = new System.Drawing.Point(289, 265);
            this.textBoxSubGroupNo.Name = "textBoxSubGroupNo";
            this.textBoxSubGroupNo.Size = new System.Drawing.Size(219, 27);
            this.textBoxSubGroupNo.TabIndex = 23;
            this.textBoxSubGroupNo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(73, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sub Group ID";
            // 
            // textBoxSubGroupID
            // 
            this.textBoxSubGroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSubGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubGroupID.Location = new System.Drawing.Point(289, 373);
            this.textBoxSubGroupID.Name = "textBoxSubGroupID";
            this.textBoxSubGroupID.ReadOnly = true;
            this.textBoxSubGroupID.Size = new System.Drawing.Size(219, 27);
            this.textBoxSubGroupID.TabIndex = 25;
            this.textBoxSubGroupID.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(592, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 26;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(718, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngenerateIDs
            // 
            this.btngenerateIDs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btngenerateIDs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerateIDs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btngenerateIDs.Location = new System.Drawing.Point(605, 231);
            this.btngenerateIDs.Name = "btngenerateIDs";
            this.btngenerateIDs.Size = new System.Drawing.Size(200, 40);
            this.btngenerateIDs.TabIndex = 28;
            this.btngenerateIDs.Text = "Generate IDs";
            this.btngenerateIDs.UseVisualStyleBackColor = true;
            this.btngenerateIDs.Click += new System.EventHandler(this.btnGenerateIDs_Click);
            // 
            // errorStudent
            // 
            this.errorStudent.ContainerControl = this;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.btngenerateIDs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxSubGroupID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSubGroupNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGroupID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGroupNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProgramme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYearSem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYearSem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProgramme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGroupNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGroupID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSubGroupNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSubGroupID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btngenerateIDs;
        private System.Windows.Forms.ErrorProvider errorStudent;
    }
}