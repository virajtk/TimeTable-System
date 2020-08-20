namespace Time_Table_Management_System.DaysAndHours
{
    partial class AddTimeSlots
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
            this.dataGridTimeSlots = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSTMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericSThours = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericETMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericETHours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddTimeSlot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimeSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSTMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSThours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericETMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericETHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTimeSlots
            // 
            this.dataGridTimeSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTimeSlots.Location = new System.Drawing.Point(87, 229);
            this.dataGridTimeSlots.Name = "dataGridTimeSlots";
            this.dataGridTimeSlots.RowHeadersWidth = 51;
            this.dataGridTimeSlots.RowTemplate.Height = 24;
            this.dataGridTimeSlots.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridTimeSlots.Size = new System.Drawing.Size(734, 189);
            this.dataGridTimeSlots.TabIndex = 19;
            this.dataGridTimeSlots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.title.Size = new System.Drawing.Size(269, 34);
            this.title.TabIndex = 18;
            this.title.Text = "Manage Time Slots";
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
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(83, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Start Time";
            // 
            // numericSTMinutes
            // 
            this.numericSTMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericSTMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSTMinutes.Location = new System.Drawing.Point(435, 115);
            this.numericSTMinutes.Name = "numericSTMinutes";
            this.numericSTMinutes.Size = new System.Drawing.Size(111, 27);
            this.numericSTMinutes.TabIndex = 44;
            this.numericSTMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericSThours
            // 
            this.numericSThours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericSThours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSThours.Location = new System.Drawing.Point(217, 115);
            this.numericSThours.Name = "numericSThours";
            this.numericSThours.Size = new System.Drawing.Size(111, 27);
            this.numericSThours.TabIndex = 43;
            this.numericSThours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(563, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(346, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Hours";
            // 
            // numericETMinutes
            // 
            this.numericETMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericETMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericETMinutes.Location = new System.Drawing.Point(435, 158);
            this.numericETMinutes.Name = "numericETMinutes";
            this.numericETMinutes.Size = new System.Drawing.Size(111, 27);
            this.numericETMinutes.TabIndex = 49;
            this.numericETMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericETHours
            // 
            this.numericETHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericETHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericETHours.Location = new System.Drawing.Point(217, 158);
            this.numericETHours.Name = "numericETHours";
            this.numericETHours.Size = new System.Drawing.Size(111, 27);
            this.numericETHours.TabIndex = 48;
            this.numericETHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(563, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(346, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Hours";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(83, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "End Time";
            // 
            // btnAddTimeSlot
            // 
            this.btnAddTimeSlot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTimeSlot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimeSlot.Location = new System.Drawing.Point(701, 115);
            this.btnAddTimeSlot.Name = "btnAddTimeSlot";
            this.btnAddTimeSlot.Size = new System.Drawing.Size(120, 65);
            this.btnAddTimeSlot.TabIndex = 50;
            this.btnAddTimeSlot.Text = "Add Time Slot";
            this.btnAddTimeSlot.UseVisualStyleBackColor = true;
            // 
            // AddTimeSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.btnAddTimeSlot);
            this.Controls.Add(this.numericETMinutes);
            this.Controls.Add(this.numericETHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericSTMinutes);
            this.Controls.Add(this.numericSThours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTimeSlots);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnClose);
            this.Name = "AddTimeSlots";
            this.Text = "AddTimeSlots";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimeSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSTMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSThours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericETMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericETHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTimeSlots;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSTMinutes;
        private System.Windows.Forms.NumericUpDown numericSThours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericETMinutes;
        private System.Windows.Forms.NumericUpDown numericETHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddTimeSlot;
    }
}