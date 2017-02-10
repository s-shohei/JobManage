namespace JobManage.Form
{
    partial class JM0002Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RegionLabel = new MetroFramework.Controls.MetroLabel();
            this.ProjectLabel = new MetroFramework.Controls.MetroLabel();
            this.TaskLabel = new MetroFramework.Controls.MetroLabel();
            this.RegionCombBox = new MetroFramework.Controls.MetroComboBox();
            this.ProjectCombBox = new MetroFramework.Controls.MetroComboBox();
            this.TaskCombBox = new MetroFramework.Controls.MetroComboBox();
            this.StartBtn = new MetroFramework.Controls.MetroButton();
            this.EndBtn = new MetroFramework.Controls.MetroButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.RegistBtn = new MetroFramework.Controls.MetroButton();
            this.TaskDataGridView = new MetroFramework.Controls.MetroGrid();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.領域 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.案件 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作業項目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.開始時刻 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.終了時刻 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作業時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(36, 58);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(39, 19);
            this.RegionLabel.TabIndex = 0;
            this.RegionLabel.Text = "領域";
            this.RegionLabel.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(182, 58);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(39, 19);
            this.ProjectLabel.TabIndex = 1;
            this.ProjectLabel.Text = "案件";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(325, 58);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(69, 19);
            this.TaskLabel.TabIndex = 2;
            this.TaskLabel.Text = "作業項目";
            // 
            // RegionCombBox
            // 
            this.RegionCombBox.BackColor = System.Drawing.SystemColors.Window;
            this.RegionCombBox.FormattingEnabled = true;
            this.RegionCombBox.ItemHeight = 23;
            this.RegionCombBox.Location = new System.Drawing.Point(36, 80);
            this.RegionCombBox.Name = "RegionCombBox";
            this.RegionCombBox.Size = new System.Drawing.Size(121, 29);
            this.RegionCombBox.TabIndex = 3;
            this.RegionCombBox.UseSelectable = true;
            // 
            // ProjectCombBox
            // 
            this.ProjectCombBox.FormattingEnabled = true;
            this.ProjectCombBox.ItemHeight = 23;
            this.ProjectCombBox.Location = new System.Drawing.Point(182, 80);
            this.ProjectCombBox.Name = "ProjectCombBox";
            this.ProjectCombBox.Size = new System.Drawing.Size(121, 29);
            this.ProjectCombBox.TabIndex = 4;
            this.ProjectCombBox.UseSelectable = true;
            // 
            // TaskCombBox
            // 
            this.TaskCombBox.FormattingEnabled = true;
            this.TaskCombBox.ItemHeight = 23;
            this.TaskCombBox.Location = new System.Drawing.Point(325, 80);
            this.TaskCombBox.Name = "TaskCombBox";
            this.TaskCombBox.Size = new System.Drawing.Size(121, 29);
            this.TaskCombBox.TabIndex = 5;
            this.TaskCombBox.UseSelectable = true;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(541, 80);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 30);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "開始";
            this.StartBtn.UseSelectable = true;
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(641, 80);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 30);
            this.EndBtn.TabIndex = 7;
            this.EndBtn.Text = "終了";
            this.EndBtn.UseSelectable = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // RegistBtn
            // 
            this.RegistBtn.Location = new System.Drawing.Point(641, 383);
            this.RegistBtn.Name = "RegistBtn";
            this.RegistBtn.Size = new System.Drawing.Size(75, 29);
            this.RegistBtn.TabIndex = 8;
            this.RegistBtn.Text = "登録";
            this.RegistBtn.UseSelectable = true;
            // 
            // TaskDataGridView
            // 
            this.TaskDataGridView.AllowUserToResizeRows = false;
            this.TaskDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TaskDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TaskDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.領域,
            this.案件,
            this.作業項目,
            this.開始時刻,
            this.終了時刻,
            this.作業時間,
            this.備考});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.TaskDataGridView.EnableHeadersVisualStyles = false;
            this.TaskDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TaskDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TaskDataGridView.Location = new System.Drawing.Point(36, 129);
            this.TaskDataGridView.Name = "TaskDataGridView";
            this.TaskDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TaskDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TaskDataGridView.RowTemplate.Height = 21;
            this.TaskDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskDataGridView.Size = new System.Drawing.Size(703, 235);
            this.TaskDataGridView.TabIndex = 9;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // 領域
            // 
            this.領域.HeaderText = "領域";
            this.領域.Name = "領域";
            this.領域.ReadOnly = true;
            // 
            // 案件
            // 
            this.案件.HeaderText = "案件";
            this.案件.Name = "案件";
            this.案件.ReadOnly = true;
            // 
            // 作業項目
            // 
            this.作業項目.HeaderText = "作業項目";
            this.作業項目.Name = "作業項目";
            this.作業項目.ReadOnly = true;
            // 
            // 開始時刻
            // 
            this.開始時刻.HeaderText = "開始時刻";
            this.開始時刻.Name = "開始時刻";
            this.開始時刻.ReadOnly = true;
            // 
            // 終了時刻
            // 
            this.終了時刻.HeaderText = "終了時刻";
            this.終了時刻.Name = "終了時刻";
            this.終了時刻.ReadOnly = true;
            // 
            // 作業時間
            // 
            this.作業時間.HeaderText = "作業時間";
            this.作業時間.Name = "作業時間";
            this.作業時間.ReadOnly = true;
            // 
            // 備考
            // 
            this.備考.HeaderText = "備考";
            this.備考.Name = "備考";
            this.備考.ReadOnly = true;
            // 
            // JM0002Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 435);
            this.Controls.Add(this.TaskDataGridView);
            this.Controls.Add(this.RegistBtn);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.TaskCombBox);
            this.Controls.Add(this.ProjectCombBox);
            this.Controls.Add(this.RegionCombBox);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.RegionLabel);
            this.Name = "JM0002Form";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JM0002Form_Closing);
            this.Load += new System.EventHandler(this.JM0002Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel RegionLabel;
        private MetroFramework.Controls.MetroLabel ProjectLabel;
        private MetroFramework.Controls.MetroLabel TaskLabel;
        private MetroFramework.Controls.MetroComboBox RegionCombBox;
        private MetroFramework.Controls.MetroComboBox ProjectCombBox;
        private MetroFramework.Controls.MetroComboBox TaskCombBox;
        private MetroFramework.Controls.MetroButton StartBtn;
        private MetroFramework.Controls.MetroButton EndBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroButton RegistBtn;
        private MetroFramework.Controls.MetroGrid TaskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn 領域;
        private System.Windows.Forms.DataGridViewTextBoxColumn 案件;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作業項目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 開始時刻;
        private System.Windows.Forms.DataGridViewTextBoxColumn 終了時刻;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作業時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考;
    }
}