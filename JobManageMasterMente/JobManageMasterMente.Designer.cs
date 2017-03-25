namespace JobManageMasterMente
{
    partial class JobManageMasterMente
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MasterDataGrid = new MetroFramework.Controls.MetroGrid();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.データ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.MasterGetButton = new MetroFramework.Controls.MetroButton();
            this.MasterInsButton = new MetroFramework.Controls.MetroButton();
            this.EndButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.MasterDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterDataGrid
            // 
            this.MasterDataGrid.AllowUserToResizeRows = false;
            this.MasterDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MasterDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MasterDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MasterDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MasterDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MasterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.データ});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MasterDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.MasterDataGrid.EnableHeadersVisualStyles = false;
            this.MasterDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MasterDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MasterDataGrid.Location = new System.Drawing.Point(24, 132);
            this.MasterDataGrid.Name = "MasterDataGrid";
            this.MasterDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MasterDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MasterDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MasterDataGrid.RowTemplate.Height = 21;
            this.MasterDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MasterDataGrid.Size = new System.Drawing.Size(377, 277);
            this.MasterDataGrid.TabIndex = 4;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // データ
            // 
            this.データ.HeaderText = "データ";
            this.データ.Name = "データ";
            // 
            // MasterComboBox
            // 
            this.MasterComboBox.FormattingEnabled = true;
            this.MasterComboBox.ItemHeight = 23;
            this.MasterComboBox.Items.AddRange(new object[] {
            "プロジェクト",
            "領域",
            "案件",
            "タスク"});
            this.MasterComboBox.Location = new System.Drawing.Point(24, 75);
            this.MasterComboBox.Name = "MasterComboBox";
            this.MasterComboBox.Size = new System.Drawing.Size(180, 29);
            this.MasterComboBox.TabIndex = 5;
            this.MasterComboBox.UseSelectable = true;
            // 
            // MasterGetButton
            // 
            this.MasterGetButton.Location = new System.Drawing.Point(211, 75);
            this.MasterGetButton.Name = "MasterGetButton";
            this.MasterGetButton.Size = new System.Drawing.Size(81, 29);
            this.MasterGetButton.TabIndex = 6;
            this.MasterGetButton.Text = "マスタ取得";
            this.MasterGetButton.UseSelectable = true;
            this.MasterGetButton.Click += new System.EventHandler(this.MasterGetButton_Click);
            // 
            // MasterInsButton
            // 
            this.MasterInsButton.Location = new System.Drawing.Point(326, 75);
            this.MasterInsButton.Name = "MasterInsButton";
            this.MasterInsButton.Size = new System.Drawing.Size(75, 29);
            this.MasterInsButton.TabIndex = 7;
            this.MasterInsButton.Text = "マスタ登録";
            this.MasterInsButton.UseSelectable = true;
            this.MasterInsButton.Click += new System.EventHandler(this.MasterInsButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(435, 75);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 29);
            this.EndButton.TabIndex = 8;
            this.EndButton.Text = "終了";
            this.EndButton.UseSelectable = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // JobManageMasterMente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 535);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.MasterInsButton);
            this.Controls.Add(this.MasterGetButton);
            this.Controls.Add(this.MasterComboBox);
            this.Controls.Add(this.MasterDataGrid);
            this.Name = "JobManageMasterMente";
            this.Text = "マスタメンテ画面";
            this.Load += new System.EventHandler(this.JobManageMasterMente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasterDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroGrid MasterDataGrid;
        internal System.Windows.Forms.DataGridViewTextBoxColumn No;
        internal System.Windows.Forms.DataGridViewTextBoxColumn データ;
        private MetroFramework.Controls.MetroButton MasterGetButton;
        internal MetroFramework.Controls.MetroComboBox MasterComboBox;
        private MetroFramework.Controls.MetroButton MasterInsButton;
        private MetroFramework.Controls.MetroButton EndButton;
    }
}

