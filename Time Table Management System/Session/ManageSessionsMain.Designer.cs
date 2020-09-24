namespace Time_Table_Management_System.Session
{
    partial class ManageSessionsMain
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
            this.button2 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnAddSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
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
            this.button2.TabIndex = 15;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(109, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(240, 32);
            this.title.TabIndex = 16;
            this.title.Text = "Manage Sessions";
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.AllowUserToAddRows = false;
            this.dataGridViewSessions.AllowUserToDeleteRows = false;
            this.dataGridViewSessions.AllowUserToResizeColumns = false;
            this.dataGridViewSessions.AllowUserToResizeRows = false;
            this.dataGridViewSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lecturer,
            this.subject,
            this.subjectCode,
            this.groupID,
            this.tag});
            this.dataGridViewSessions.Location = new System.Drawing.Point(39, 145);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.RowHeadersWidth = 51;
            this.dataGridViewSessions.RowTemplate.Height = 24;
            this.dataGridViewSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSessions.Size = new System.Drawing.Size(652, 261);
            this.dataGridViewSessions.TabIndex = 17;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // lecturer
            // 
            this.lecturer.HeaderText = "Lectuter";
            this.lecturer.MinimumWidth = 6;
            this.lecturer.Name = "lecturer";
            this.lecturer.ReadOnly = true;
            this.lecturer.Width = 125;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Width = 125;
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "Subject Code";
            this.subjectCode.MinimumWidth = 6;
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.ReadOnly = true;
            this.subjectCode.Width = 125;
            // 
            // groupID
            // 
            this.groupID.HeaderText = "Group ID";
            this.groupID.MinimumWidth = 6;
            this.groupID.Name = "groupID";
            this.groupID.ReadOnly = true;
            this.groupID.Width = 125;
            // 
            // tag
            // 
            this.tag.HeaderText = "Tag";
            this.tag.MinimumWidth = 6;
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(724, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(724, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnView.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.Info;
            this.btnView.Location = new System.Drawing.Point(724, 192);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(120, 40);
            this.btnView.TabIndex = 31;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKey.Location = new System.Drawing.Point(58, 96);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(276, 30);
            this.txtSearchKey.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Location = new System.Drawing.Point(558, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 33);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(356, 95);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(181, 33);
            this.comboBoxSearch.TabIndex = 34;
            // 
            // btnAddSession
            // 
            this.btnAddSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSession.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSession.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddSession.Location = new System.Drawing.Point(704, 21);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(160, 54);
            this.btnAddSession.TabIndex = 35;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // ManageSessionsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(881, 442);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchKey);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridViewSessions);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "ManageSessionsMain";
            this.Text = "ManageSessionsMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.Button btnAddSession;
    }
}