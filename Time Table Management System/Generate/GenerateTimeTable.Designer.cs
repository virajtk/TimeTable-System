namespace Time_Table_Management_System.Generate
{
    partial class GenerateTimeTable
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
            this.title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControlTT = new System.Windows.Forms.TabControl();
            this.tabPageLec = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateLecTT = new System.Windows.Forms.Button();
            this.comboBoxLecList = new System.Windows.Forms.ComboBox();
            this.tabPageStu = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxBuildings = new System.Windows.Forms.ComboBox();
            this.tabPageLoc = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataGridGTT = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControlTT.SuspendLayout();
            this.tabPageLec.SuspendLayout();
            this.tabPageStu.SuspendLayout();
            this.tabPageLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(109, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 32);
            this.title.TabIndex = 18;
            this.title.Text = "Generate Time Tables";
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
            this.button2.TabIndex = 17;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tabControlTT
            // 
            this.tabControlTT.Controls.Add(this.tabPageLec);
            this.tabControlTT.Controls.Add(this.tabPageStu);
            this.tabControlTT.Controls.Add(this.tabPageLoc);
            this.tabControlTT.Location = new System.Drawing.Point(12, 85);
            this.tabControlTT.Name = "tabControlTT";
            this.tabControlTT.SelectedIndex = 0;
            this.tabControlTT.Size = new System.Drawing.Size(857, 345);
            this.tabControlTT.TabIndex = 19;
            // 
            // tabPageLec
            // 
            this.tabPageLec.BackColor = System.Drawing.Color.Black;
            this.tabPageLec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageLec.Controls.Add(this.dataGridGTT);
            this.tabPageLec.Controls.Add(this.label3);
            this.tabPageLec.Controls.Add(this.btnGenerateLecTT);
            this.tabPageLec.Controls.Add(this.comboBoxLecList);
            this.tabPageLec.Location = new System.Drawing.Point(4, 25);
            this.tabPageLec.Name = "tabPageLec";
            this.tabPageLec.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLec.Size = new System.Drawing.Size(849, 316);
            this.tabPageLec.TabIndex = 0;
            this.tabPageLec.Text = "Lecturer";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(44, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Lecturer Name";
            // 
            // btnGenerateLecTT
            // 
            this.btnGenerateLecTT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerateLecTT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerateLecTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateLecTT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLecTT.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateLecTT.Location = new System.Drawing.Point(689, 21);
            this.btnGenerateLecTT.Name = "btnGenerateLecTT";
            this.btnGenerateLecTT.Size = new System.Drawing.Size(120, 33);
            this.btnGenerateLecTT.TabIndex = 36;
            this.btnGenerateLecTT.Text = "Generate";
            this.btnGenerateLecTT.UseVisualStyleBackColor = false;
            // 
            // comboBoxLecList
            // 
            this.comboBoxLecList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecList.FormattingEnabled = true;
            this.comboBoxLecList.Location = new System.Drawing.Point(199, 21);
            this.comboBoxLecList.Name = "comboBoxLecList";
            this.comboBoxLecList.Size = new System.Drawing.Size(369, 33);
            this.comboBoxLecList.TabIndex = 35;
            // 
            // tabPageStu
            // 
            this.tabPageStu.BackColor = System.Drawing.Color.Black;
            this.tabPageStu.Controls.Add(this.dataGridView1);
            this.tabPageStu.Controls.Add(this.label2);
            this.tabPageStu.Controls.Add(this.comboBoxRooms);
            this.tabPageStu.Controls.Add(this.label1);
            this.tabPageStu.Controls.Add(this.button1);
            this.tabPageStu.Controls.Add(this.comboBoxBuildings);
            this.tabPageStu.Location = new System.Drawing.Point(4, 25);
            this.tabPageStu.Name = "tabPageStu";
            this.tabPageStu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStu.Size = new System.Drawing.Size(849, 316);
            this.tabPageStu.TabIndex = 1;
            this.tabPageStu.Text = "Student";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Building";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(688, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 39;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxBuildings
            // 
            this.comboBoxBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuildings.FormattingEnabled = true;
            this.comboBoxBuildings.Location = new System.Drawing.Point(141, 21);
            this.comboBoxBuildings.Name = "comboBoxBuildings";
            this.comboBoxBuildings.Size = new System.Drawing.Size(159, 33);
            this.comboBoxBuildings.TabIndex = 38;
            // 
            // tabPageLoc
            // 
            this.tabPageLoc.BackColor = System.Drawing.Color.Black;
            this.tabPageLoc.Controls.Add(this.dataGridView2);
            this.tabPageLoc.Controls.Add(this.label6);
            this.tabPageLoc.Controls.Add(this.comboBox3);
            this.tabPageLoc.Controls.Add(this.label7);
            this.tabPageLoc.Controls.Add(this.comboBox4);
            this.tabPageLoc.Controls.Add(this.label4);
            this.tabPageLoc.Controls.Add(this.comboBox1);
            this.tabPageLoc.Controls.Add(this.label5);
            this.tabPageLoc.Controls.Add(this.button3);
            this.tabPageLoc.Controls.Add(this.comboBox2);
            this.tabPageLoc.Location = new System.Drawing.Point(4, 25);
            this.tabPageLoc.Name = "tabPageLoc";
            this.tabPageLoc.Size = new System.Drawing.Size(849, 316);
            this.tabPageLoc.TabIndex = 2;
            this.tabPageLoc.Text = "Location";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPrint.Location = new System.Drawing.Point(666, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(160, 54);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(341, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Room";
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(439, 22);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(159, 33);
            this.comboBoxRooms.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(336, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Year";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(398, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 33);
            this.comboBox1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(38, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Specialization";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(689, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 33);
            this.button3.TabIndex = 44;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(157, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 33);
            this.comboBox2.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(336, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Group";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(398, 89);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 33);
            this.comboBox3.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(38, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Semester";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(157, 89);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(159, 33);
            this.comboBox4.TabIndex = 48;
            // 
            // dataGridGTT
            // 
            this.dataGridGTT.AllowUserToAddRows = false;
            this.dataGridGTT.AllowUserToDeleteRows = false;
            this.dataGridGTT.AllowUserToResizeColumns = false;
            this.dataGridGTT.AllowUserToResizeRows = false;
            this.dataGridGTT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridGTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGTT.Location = new System.Drawing.Point(48, 85);
            this.dataGridGTT.Name = "dataGridGTT";
            this.dataGridGTT.RowHeadersWidth = 51;
            this.dataGridGTT.RowTemplate.Height = 24;
            this.dataGridGTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGTT.Size = new System.Drawing.Size(761, 207);
            this.dataGridGTT.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(761, 207);
            this.dataGridView1.TabIndex = 43;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(768, 152);
            this.dataGridView2.TabIndex = 52;
            // 
            // GenerateTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tabControlTT);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button2);
            this.Name = "GenerateTimeTable";
            this.Text = "GenerateTimeTable";
            this.tabControlTT.ResumeLayout(false);
            this.tabPageLec.ResumeLayout(false);
            this.tabPageLec.PerformLayout();
            this.tabPageStu.ResumeLayout(false);
            this.tabPageStu.PerformLayout();
            this.tabPageLoc.ResumeLayout(false);
            this.tabPageLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControlTT;
        private System.Windows.Forms.TabPage tabPageLec;
        private System.Windows.Forms.TabPage tabPageStu;
        private System.Windows.Forms.TabPage tabPageLoc;
        private System.Windows.Forms.ComboBox comboBoxLecList;
        private System.Windows.Forms.Button btnGenerateLecTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxBuildings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridGTT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}