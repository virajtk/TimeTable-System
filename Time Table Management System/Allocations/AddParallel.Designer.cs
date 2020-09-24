namespace Time_Table_Management_System.Allocations
{
    partial class AddParallel
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
            this.close = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Maroon;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.ForeColor = System.Drawing.SystemColors.Info;
            this.close.Location = new System.Drawing.Point(3, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 25);
            this.close.TabIndex = 15;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Info;
            this.title.Location = new System.Drawing.Point(95, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(229, 34);
            this.title.TabIndex = 20;
            this.title.Text = "Parallel Sessions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lecturer,
            this.subject,
            this.subjCode,
            this.groupId,
            this.tag,
            this.select});
            this.dataGridView1.Location = new System.Drawing.Point(27, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 234);
            this.dataGridView1.TabIndex = 21;
            // 
            // lecturer
            // 
            this.lecturer.HeaderText = "Lecturer";
            this.lecturer.MinimumWidth = 6;
            this.lecturer.Name = "lecturer";
            this.lecturer.Width = 125;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.Width = 125;
            // 
            // subjCode
            // 
            this.subjCode.HeaderText = "Subject Code";
            this.subjCode.MinimumWidth = 6;
            this.subjCode.Name = "subjCode";
            this.subjCode.Width = 125;
            // 
            // groupId
            // 
            this.groupId.HeaderText = "Group ID";
            this.groupId.MinimumWidth = 6;
            this.groupId.Name = "groupId";
            this.groupId.Width = 125;
            // 
            // tag
            // 
            this.tag.HeaderText = "Tag";
            this.tag.MinimumWidth = 6;
            this.tag.Name = "tag";
            this.tag.Width = 125;
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            this.select.Width = 125;
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnView.Location = new System.Drawing.Point(407, 372);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(120, 40);
            this.btnView.TabIndex = 25;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnSession
            // 
            this.btnSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSession.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSession.Location = new System.Drawing.Point(244, 372);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(120, 40);
            this.btnSession.TabIndex = 24;
            this.btnSession.Text = "Add Session";
            this.btnSession.UseVisualStyleBackColor = true;
            // 
            // AddParallel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSession);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.close);
            this.Name = "AddParallel";
            this.Text = "AddParallel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn select;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSession;
    }
}