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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProjectLabel = new MetroFramework.Controls.MetroLabel();
            this.RegionLabel = new MetroFramework.Controls.MetroLabel();
            this.AnkenLabel = new MetroFramework.Controls.MetroLabel();
            this.ProjectCombBox = new MetroFramework.Controls.MetroComboBox();
            this.RegionCombBox = new MetroFramework.Controls.MetroComboBox();
            this.AnkenCombBox = new MetroFramework.Controls.MetroComboBox();
            this.StartBtn = new MetroFramework.Controls.MetroButton();
            this.EndBtn = new MetroFramework.Controls.MetroButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.RegistBtn = new MetroFramework.Controls.MetroButton();
            this.TaskDataGridView = new MetroFramework.Controls.MetroGrid();
            this.プロジェクト = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.領域 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.案件 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作業項目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.開始時刻 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.終了時刻 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作業時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskLabel = new MetroFramework.Controls.MetroLabel();
            this.TaskComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(36, 58);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(70, 19);
            this.ProjectLabel.TabIndex = 0;
            this.ProjectLabel.Text = "プロジェクト";
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(182, 58);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(37, 19);
            this.RegionLabel.TabIndex = 1;
            this.RegionLabel.Text = "領域";
            // 
            // AnkenLabel
            // 
            this.AnkenLabel.AutoSize = true;
            this.AnkenLabel.Location = new System.Drawing.Point(325, 58);
            this.AnkenLabel.Name = "AnkenLabel";
            this.AnkenLabel.Size = new System.Drawing.Size(37, 19);
            this.AnkenLabel.TabIndex = 2;
            this.AnkenLabel.Text = "案件";
            // 
            // ProjectCombBox
            // 
            this.ProjectCombBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProjectCombBox.FormattingEnabled = true;
            this.ProjectCombBox.ItemHeight = 23;
            this.ProjectCombBox.Location = new System.Drawing.Point(36, 80);
            this.ProjectCombBox.Name = "ProjectCombBox";
            this.ProjectCombBox.Size = new System.Drawing.Size(121, 29);
            this.ProjectCombBox.TabIndex = 3;
            this.ProjectCombBox.UseSelectable = true;
            // 
            // RegionCombBox
            // 
            this.RegionCombBox.FormattingEnabled = true;
            this.RegionCombBox.ItemHeight = 23;
            this.RegionCombBox.Location = new System.Drawing.Point(182, 80);
            this.RegionCombBox.Name = "RegionCombBox";
            this.RegionCombBox.Size = new System.Drawing.Size(121, 29);
            this.RegionCombBox.TabIndex = 4;
            this.RegionCombBox.UseSelectable = true;
            // 
            // AnkenCombBox
            // 
            this.AnkenCombBox.FormattingEnabled = true;
            this.AnkenCombBox.ItemHeight = 23;
            this.AnkenCombBox.Location = new System.Drawing.Point(325, 80);
            this.AnkenCombBox.Name = "AnkenCombBox";
            this.AnkenCombBox.Size = new System.Drawing.Size(318, 29);
            this.AnkenCombBox.TabIndex = 5;
            this.AnkenCombBox.UseSelectable = true;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(876, 80);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 30);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "開始";
            this.StartBtn.UseSelectable = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(957, 80);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 30);
            this.EndBtn.TabIndex = 7;
            this.EndBtn.Text = "終了";
            this.EndBtn.UseSelectable = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // RegistBtn
            // 
            this.RegistBtn.Location = new System.Drawing.Point(957, 383);
            this.RegistBtn.Name = "RegistBtn";
            this.RegistBtn.Size = new System.Drawing.Size(75, 29);
            this.RegistBtn.TabIndex = 8;
            this.RegistBtn.Text = "登録";
            this.RegistBtn.UseSelectable = true;
            this.RegistBtn.Click += new System.EventHandler(this.RegistBtn_Click);
            // 
            // TaskDataGridView
            // 
            this.TaskDataGridView.AllowUserToResizeRows = false;
            this.TaskDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TaskDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TaskDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TaskDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.プロジェクト,
            this.領域,
            this.案件,
            this.作業項目,
            this.開始時刻,
            this.終了時刻,
            this.作業時間,
            this.備考});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.TaskDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.TaskDataGridView.EnableHeadersVisualStyles = false;
            this.TaskDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TaskDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TaskDataGridView.Location = new System.Drawing.Point(36, 129);
            this.TaskDataGridView.MultiSelect = false;
            this.TaskDataGridView.Name = "TaskDataGridView";
            this.TaskDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TaskDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TaskDataGridView.RowTemplate.Height = 21;
            this.TaskDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskDataGridView.Size = new System.Drawing.Size(1005, 235);
            this.TaskDataGridView.TabIndex = 9;
            // 
            // プロジェクト
            // 
            this.プロジェクト.HeaderText = "プロジェクト";
            this.プロジェクト.Name = "プロジェクト";
            this.プロジェクト.ReadOnly = true;
            this.プロジェクト.Width = 102;
            // 
            // 領域
            // 
            this.領域.HeaderText = "領域";
            this.領域.Name = "領域";
            this.領域.ReadOnly = true;
            this.領域.Width = 54;
            // 
            // 案件
            // 
            this.案件.HeaderText = "案件";
            this.案件.Name = "案件";
            this.案件.ReadOnly = true;
            this.案件.Width = 54;
            // 
            // 作業項目
            // 
            this.作業項目.HeaderText = "作業項目";
            this.作業項目.Name = "作業項目";
            this.作業項目.ReadOnly = true;
            this.作業項目.Width = 78;
            // 
            // 開始時刻
            // 
            this.開始時刻.HeaderText = "開始時刻";
            this.開始時刻.Name = "開始時刻";
            this.開始時刻.ReadOnly = true;
            this.開始時刻.Width = 78;
            // 
            // 終了時刻
            // 
            this.終了時刻.HeaderText = "終了時刻";
            this.終了時刻.Name = "終了時刻";
            this.終了時刻.ReadOnly = true;
            this.終了時刻.Width = 78;
            // 
            // 作業時間
            // 
            this.作業時間.HeaderText = "作業時間";
            this.作業時間.Name = "作業時間";
            this.作業時間.ReadOnly = true;
            this.作業時間.Width = 78;
            // 
            // 備考
            // 
            this.備考.HeaderText = "備考";
            this.備考.Name = "備考";
            this.備考.Width = 54;
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(647, 58);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(65, 19);
            this.TaskLabel.TabIndex = 10;
            this.TaskLabel.Text = "作業項目";
            // 
            // TaskComboBox
            // 
            this.TaskComboBox.FormattingEnabled = true;
            this.TaskComboBox.ItemHeight = 23;
            this.TaskComboBox.Location = new System.Drawing.Point(647, 81);
            this.TaskComboBox.Name = "TaskComboBox";
            this.TaskComboBox.Size = new System.Drawing.Size(208, 29);
            this.TaskComboBox.TabIndex = 11;
            this.TaskComboBox.UseSelectable = true;
            // 
            // JM0002Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 435);
            this.Controls.Add(this.TaskComboBox);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.TaskDataGridView);
            this.Controls.Add(this.RegistBtn);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.AnkenCombBox);
            this.Controls.Add(this.RegionCombBox);
            this.Controls.Add(this.ProjectCombBox);
            this.Controls.Add(this.AnkenLabel);
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.ProjectLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JM0002Form";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JM0002Form_Closing);
            this.Load += new System.EventHandler(this.JM0002Form_Load);
            this.ClientSizeChanged += new System.EventHandler(this.JM0002Form_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLabel ProjectLabel;
        internal MetroFramework.Controls.MetroLabel RegionLabel;
        internal MetroFramework.Controls.MetroLabel AnkenLabel;
        internal MetroFramework.Controls.MetroComboBox ProjectCombBox;
        internal MetroFramework.Controls.MetroComboBox RegionCombBox;
        internal MetroFramework.Controls.MetroComboBox AnkenCombBox;
        internal MetroFramework.Controls.MetroButton StartBtn;
        internal MetroFramework.Controls.MetroButton EndBtn;
        internal System.Windows.Forms.Timer timer;
        internal MetroFramework.Controls.MetroButton RegistBtn;
        internal MetroFramework.Controls.MetroGrid TaskDataGridView;
        internal MetroFramework.Controls.MetroLabel TaskLabel;
        internal MetroFramework.Controls.MetroComboBox TaskComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn プロジェクト;
        private System.Windows.Forms.DataGridViewTextBoxColumn 領域;
        private System.Windows.Forms.DataGridViewTextBoxColumn 案件;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作業項目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 開始時刻;
        private System.Windows.Forms.DataGridViewTextBoxColumn 終了時刻;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作業時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考;
    }
}