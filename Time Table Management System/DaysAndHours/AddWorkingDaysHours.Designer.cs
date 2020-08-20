namespace Time_Table_Management_System.DaysAndHours
{
    partial class AddWorkingDaysHours
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numericNoOfDays = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListWorkingDays = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericTPerDayHours = new System.Windows.Forms.NumericUpDown();
            this.numericTPerDayMinutes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoOfDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTPerDayHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTPerDayMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(579, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(718, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // numericNoOfDays
            // 
            this.numericNoOfDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericNoOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNoOfDays.Location = new System.Drawing.Point(295, 115);
            this.numericNoOfDays.Name = "numericNoOfDays";
            this.numericNoOfDays.Size = new System.Drawing.Size(79, 27);
            this.numericNoOfDays.TabIndex = 30;
            this.numericNoOfDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNoOfDays.ValueChanged += new System.EventHandler(this.numericTuteHours_ValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClose.Location = new System.Drawing.Point(3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 25);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(54, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "No of Working Days";
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
            this.title.Size = new System.Drawing.Size(347, 34);
            this.title.TabIndex = 26;
            this.title.Text = "Add Working Days Hours";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(54, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Working Days";
            // 
            // checkedListWorkingDays
            // 
            this.checkedListWorkingDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListWorkingDays.BackColor = System.Drawing.SystemColors.Desktop;
            this.checkedListWorkingDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListWorkingDays.ColumnWidth = 120;
            this.checkedListWorkingDays.ForeColor = System.Drawing.SystemColors.Info;
            this.checkedListWorkingDays.FormattingEnabled = true;
            this.checkedListWorkingDays.Items.AddRange(new object[] {
            "Monday",
            "Wednesday",
            "Tuesday",
            "Thursday",
            "Saturday",
            "Friday",
            "Sunday"});
            this.checkedListWorkingDays.Location = new System.Drawing.Point(295, 175);
            this.checkedListWorkingDays.MultiColumn = true;
            this.checkedListWorkingDays.Name = "checkedListWorkingDays";
            this.checkedListWorkingDays.Size = new System.Drawing.Size(487, 36);
            this.checkedListWorkingDays.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(54, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Working Time Per Day";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(424, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Hours";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(641, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Minutes";
            // 
            // numericTPerDayHours
            // 
            this.numericTPerDayHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericTPerDayHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTPerDayHours.Location = new System.Drawing.Point(295, 244);
            this.numericTPerDayHours.Name = "numericTPerDayHours";
            this.numericTPerDayHours.Size = new System.Drawing.Size(111, 27);
            this.numericTPerDayHours.TabIndex = 39;
            this.numericTPerDayHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericTPerDayMinutes
            // 
            this.numericTPerDayMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericTPerDayMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTPerDayMinutes.Location = new System.Drawing.Point(513, 245);
            this.numericTPerDayMinutes.Name = "numericTPerDayMinutes";
            this.numericTPerDayMinutes.Size = new System.Drawing.Size(111, 27);
            this.numericTPerDayMinutes.TabIndex = 40;
            this.numericTPerDayMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddWorkingDaysHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.numericTPerDayMinutes);
            this.Controls.Add(this.numericTPerDayHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListWorkingDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericNoOfDays);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "AddWorkingDaysHours";
            this.Text = "AddWorkingDaysHours";
            ((System.ComponentModel.ISupportInitialize)(this.numericNoOfDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTPerDayHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTPerDayMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericNoOfDays;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListWorkingDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericTPerDayHours;
        private System.Windows.Forms.NumericUpDown numericTPerDayMinutes;
    }
}