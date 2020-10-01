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
            this.dataGridLec = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateLec = new System.Windows.Forms.Button();
            this.comboBoxLecList = new System.Windows.Forms.ComboBox();
            this.tabPageStu = new System.Windows.Forms.TabPage();
            this.btnGenerateStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.tabPageLoc = new System.Windows.Forms.TabPage();
            this.dataGridLocation = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLocationList = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnGenerateLocation = new System.Windows.Forms.Button();
            this.tabControlTT.SuspendLayout();
            this.tabPageLec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLec)).BeginInit();
            this.tabPageStu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(108, 20);
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
            this.tabControlTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabControlTT.Location = new System.Drawing.Point(12, 68);
            this.tabControlTT.Name = "tabControlTT";
            this.tabControlTT.SelectedIndex = 0;
            this.tabControlTT.Size = new System.Drawing.Size(857, 362);
            this.tabControlTT.TabIndex = 19;
            // 
            // tabPageLec
            // 
            this.tabPageLec.BackColor = System.Drawing.Color.Snow;
            this.tabPageLec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageLec.Controls.Add(this.dataGridLec);
            this.tabPageLec.Controls.Add(this.label3);
            this.tabPageLec.Controls.Add(this.btnGenerateLec);
            this.tabPageLec.Controls.Add(this.comboBoxLecList);
            this.tabPageLec.Location = new System.Drawing.Point(4, 31);
            this.tabPageLec.Name = "tabPageLec";
            this.tabPageLec.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLec.Size = new System.Drawing.Size(849, 327);
            this.tabPageLec.TabIndex = 0;
            this.tabPageLec.Text = "Lecturer";
            // 
            // dataGridLec
            // 
            this.dataGridLec.AllowUserToAddRows = false;
            this.dataGridLec.AllowUserToDeleteRows = false;
            this.dataGridLec.AllowUserToResizeColumns = false;
            this.dataGridLec.AllowUserToResizeRows = false;
            this.dataGridLec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLec.Location = new System.Drawing.Point(20, 65);
            this.dataGridLec.Name = "dataGridLec";
            this.dataGridLec.RowHeadersWidth = 51;
            this.dataGridLec.RowTemplate.Height = 24;
            this.dataGridLec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLec.Size = new System.Drawing.Size(798, 246);
            this.dataGridLec.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(147, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Lecturer";
            // 
            // btnGenerateLec
            // 
            this.btnGenerateLec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerateLec.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerateLec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateLec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLec.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateLec.Location = new System.Drawing.Point(589, 8);
            this.btnGenerateLec.Name = "btnGenerateLec";
            this.btnGenerateLec.Size = new System.Drawing.Size(120, 48);
            this.btnGenerateLec.TabIndex = 36;
            this.btnGenerateLec.Text = "Generate";
            this.btnGenerateLec.UseVisualStyleBackColor = false;
            this.btnGenerateLec.Click += new System.EventHandler(this.btnGenerateLec_Click);
            // 
            // comboBoxLecList
            // 
            this.comboBoxLecList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecList.FormattingEnabled = true;
            this.comboBoxLecList.Location = new System.Drawing.Point(246, 19);
            this.comboBoxLecList.Name = "comboBoxLecList";
            this.comboBoxLecList.Size = new System.Drawing.Size(311, 33);
            this.comboBoxLecList.TabIndex = 35;
            // 
            // tabPageStu
            // 
            this.tabPageStu.BackColor = System.Drawing.Color.Snow;
            this.tabPageStu.Controls.Add(this.btnGenerateStudent);
            this.tabPageStu.Controls.Add(this.dataGridView1);
            this.tabPageStu.Controls.Add(this.label2);
            this.tabPageStu.Controls.Add(this.comboBoxGroups);
            this.tabPageStu.Location = new System.Drawing.Point(4, 31);
            this.tabPageStu.Name = "tabPageStu";
            this.tabPageStu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStu.Size = new System.Drawing.Size(849, 327);
            this.tabPageStu.TabIndex = 1;
            this.tabPageStu.Text = "Student";
            // 
            // btnGenerateStudent
            // 
            this.btnGenerateStudent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerateStudent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateStudent.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateStudent.Location = new System.Drawing.Point(574, 8);
            this.btnGenerateStudent.Name = "btnGenerateStudent";
            this.btnGenerateStudent.Size = new System.Drawing.Size(120, 48);
            this.btnGenerateStudent.TabIndex = 44;
            this.btnGenerateStudent.Text = "Generate";
            this.btnGenerateStudent.UseVisualStyleBackColor = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(19, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 244);
            this.dataGridView1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(180, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Group";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(265, 16);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(280, 33);
            this.comboBoxGroups.TabIndex = 41;
            // 
            // tabPageLoc
            // 
            this.tabPageLoc.BackColor = System.Drawing.Color.Snow;
            this.tabPageLoc.Controls.Add(this.btnGenerateLocation);
            this.tabPageLoc.Controls.Add(this.dataGridLocation);
            this.tabPageLoc.Controls.Add(this.label5);
            this.tabPageLoc.Controls.Add(this.comboBoxLocationList);
            this.tabPageLoc.Location = new System.Drawing.Point(4, 31);
            this.tabPageLoc.Name = "tabPageLoc";
            this.tabPageLoc.Size = new System.Drawing.Size(849, 327);
            this.tabPageLoc.TabIndex = 2;
            this.tabPageLoc.Text = "Location";
            // 
            // dataGridLocation
            // 
            this.dataGridLocation.AllowUserToAddRows = false;
            this.dataGridLocation.AllowUserToDeleteRows = false;
            this.dataGridLocation.AllowUserToResizeColumns = false;
            this.dataGridLocation.AllowUserToResizeRows = false;
            this.dataGridLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocation.Location = new System.Drawing.Point(17, 69);
            this.dataGridLocation.MultiSelect = false;
            this.dataGridLocation.Name = "dataGridLocation";
            this.dataGridLocation.RowHeadersVisible = false;
            this.dataGridLocation.RowHeadersWidth = 51;
            this.dataGridLocation.RowTemplate.Height = 24;
            this.dataGridLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLocation.Size = new System.Drawing.Size(816, 242);
            this.dataGridLocation.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(187, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Location";
            // 
            // comboBoxLocationList
            // 
            this.comboBoxLocationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLocationList.FormattingEnabled = true;
            this.comboBoxLocationList.Location = new System.Drawing.Point(285, 23);
            this.comboBoxLocationList.Name = "comboBoxLocationList";
            this.comboBoxLocationList.Size = new System.Drawing.Size(244, 33);
            this.comboBoxLocationList.TabIndex = 43;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPrint.Location = new System.Drawing.Point(745, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 37);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnGenerateLocation
            // 
            this.btnGenerateLocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerateLocation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerateLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLocation.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerateLocation.Location = new System.Drawing.Point(571, 15);
            this.btnGenerateLocation.Name = "btnGenerateLocation";
            this.btnGenerateLocation.Size = new System.Drawing.Size(120, 48);
            this.btnGenerateLocation.TabIndex = 53;
            this.btnGenerateLocation.Text = "Generate";
            this.btnGenerateLocation.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLec)).EndInit();
            this.tabPageStu.ResumeLayout(false);
            this.tabPageStu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageLoc.ResumeLayout(false);
            this.tabPageLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocation)).EndInit();
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
        private System.Windows.Forms.Button btnGenerateLec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLocationList;
        private System.Windows.Forms.DataGridView dataGridLec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridLocation;
        private System.Windows.Forms.Button btnGenerateStudent;
        private System.Windows.Forms.Button btnGenerateLocation;
    }
}