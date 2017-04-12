namespace JobManage.Form
{
    partial class JM0003Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AggAnkenMonthButton = new MetroFramework.Controls.MetroButton();
            this.AggTaskButton = new MetroFramework.Controls.MetroButton();
            this.AggGrid = new MetroFramework.Controls.MetroGrid();
            this.案件 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.累計工数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AggAnkenDayButton = new MetroFramework.Controls.MetroButton();
            this.AggTaskDayButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.AggGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AggAnkenMonthButton
            // 
            this.AggAnkenMonthButton.Location = new System.Drawing.Point(23, 63);
            this.AggAnkenMonthButton.Name = "AggAnkenMonthButton";
            this.AggAnkenMonthButton.Size = new System.Drawing.Size(118, 23);
            this.AggAnkenMonthButton.TabIndex = 0;
            this.AggAnkenMonthButton.Text = "案件(月)";
            this.AggAnkenMonthButton.UseSelectable = true;
            this.AggAnkenMonthButton.Click += new System.EventHandler(this.AggAnkenButton_Click);
            // 
            // AggTaskButton
            // 
            this.AggTaskButton.Location = new System.Drawing.Point(23, 92);
            this.AggTaskButton.Name = "AggTaskButton";
            this.AggTaskButton.Size = new System.Drawing.Size(118, 23);
            this.AggTaskButton.TabIndex = 1;
            this.AggTaskButton.Text = "作業内容(月)";
            this.AggTaskButton.UseSelectable = true;
            this.AggTaskButton.Click += new System.EventHandler(this.AggTaskButton_Click);
            // 
            // AggGrid
            // 
            this.AggGrid.AllowUserToResizeRows = false;
            this.AggGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AggGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AggGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AggGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.AggGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AggGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AggGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AggGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.案件,
            this.累計工数});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AggGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AggGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.AggGrid.EnableHeadersVisualStyles = false;
            this.AggGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AggGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AggGrid.Location = new System.Drawing.Point(23, 126);
            this.AggGrid.MultiSelect = false;
            this.AggGrid.Name = "AggGrid";
            this.AggGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AggGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AggGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AggGrid.RowTemplate.Height = 21;
            this.AggGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AggGrid.Size = new System.Drawing.Size(553, 177);
            this.AggGrid.TabIndex = 2;
            // 
            // 案件
            // 
            this.案件.HeaderText = "案件";
            this.案件.Name = "案件";
            this.案件.ReadOnly = true;
            this.案件.Width = 54;
            // 
            // 累計工数
            // 
            this.累計工数.HeaderText = "累計工数";
            this.累計工数.Name = "累計工数";
            this.累計工数.ReadOnly = true;
            this.累計工数.Width = 78;
            // 
            // AggAnkenDayButton
            // 
            this.AggAnkenDayButton.Location = new System.Drawing.Point(147, 63);
            this.AggAnkenDayButton.Name = "AggAnkenDayButton";
            this.AggAnkenDayButton.Size = new System.Drawing.Size(118, 23);
            this.AggAnkenDayButton.TabIndex = 3;
            this.AggAnkenDayButton.Text = "案件(日)";
            this.AggAnkenDayButton.UseSelectable = true;
            this.AggAnkenDayButton.Click += new System.EventHandler(this.AggAnkenDayButton_Click);
            // 
            // AggTaskDayButton
            // 
            this.AggTaskDayButton.Location = new System.Drawing.Point(147, 92);
            this.AggTaskDayButton.Name = "AggTaskDayButton";
            this.AggTaskDayButton.Size = new System.Drawing.Size(118, 23);
            this.AggTaskDayButton.TabIndex = 4;
            this.AggTaskDayButton.Text = "作業内容(日)";
            this.AggTaskDayButton.UseSelectable = true;
            this.AggTaskDayButton.Click += new System.EventHandler(this.AggTaskDayButton_Click);
            // 
            // JM0003Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 394);
            this.Controls.Add(this.AggTaskDayButton);
            this.Controls.Add(this.AggAnkenDayButton);
            this.Controls.Add(this.AggGrid);
            this.Controls.Add(this.AggTaskButton);
            this.Controls.Add(this.AggAnkenMonthButton);
            this.Name = "JM0003Form";
            this.Text = "集計画面";
            ((System.ComponentModel.ISupportInitialize)(this.AggGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroButton AggAnkenMonthButton;
        internal MetroFramework.Controls.MetroButton AggTaskButton;
        internal MetroFramework.Controls.MetroGrid AggGrid;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 案件;
        internal System.Windows.Forms.DataGridViewTextBoxColumn 累計工数;
        internal MetroFramework.Controls.MetroButton AggAnkenDayButton;
        internal MetroFramework.Controls.MetroButton AggTaskDayButton;
    }
}