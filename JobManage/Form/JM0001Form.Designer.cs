﻿namespace JobManage
{
    partial class JM0001Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JM0001Form));
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.UserNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.MasterButton = new MetroFramework.Controls.MetroButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(53, 68);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(57, 19);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "ユーザ名";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(53, 139);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 19);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "パスワード";
            // 
            // UserNameTextbox
            // 
            // 
            // 
            // 
            this.UserNameTextbox.CustomButton.Image = null;
            this.UserNameTextbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.UserNameTextbox.CustomButton.Name = "";
            this.UserNameTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserNameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameTextbox.CustomButton.TabIndex = 1;
            this.UserNameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameTextbox.CustomButton.UseSelectable = true;
            this.UserNameTextbox.CustomButton.Visible = false;
            this.UserNameTextbox.Lines = new string[] {
        "下津曲翔平"};
            this.UserNameTextbox.Location = new System.Drawing.Point(53, 90);
            this.UserNameTextbox.MaxLength = 32767;
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.PasswordChar = '\0';
            this.UserNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTextbox.SelectedText = "";
            this.UserNameTextbox.SelectionLength = 0;
            this.UserNameTextbox.SelectionStart = 0;
            this.UserNameTextbox.ShortcutsEnabled = true;
            this.UserNameTextbox.Size = new System.Drawing.Size(170, 23);
            this.UserNameTextbox.TabIndex = 2;
            this.UserNameTextbox.Text = "下津曲翔平";
            this.UserNameTextbox.UseSelectable = true;
            this.UserNameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordTextbox
            // 
            // 
            // 
            // 
            this.PasswordTextbox.CustomButton.Image = null;
            this.PasswordTextbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.PasswordTextbox.CustomButton.Name = "";
            this.PasswordTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextbox.CustomButton.TabIndex = 1;
            this.PasswordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextbox.CustomButton.UseSelectable = true;
            this.PasswordTextbox.CustomButton.Visible = false;
            this.PasswordTextbox.Lines = new string[] {
        "1234"};
            this.PasswordTextbox.Location = new System.Drawing.Point(53, 161);
            this.PasswordTextbox.MaxLength = 32767;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.SelectionLength = 0;
            this.PasswordTextbox.SelectionStart = 0;
            this.PasswordTextbox.ShortcutsEnabled = true;
            this.PasswordTextbox.Size = new System.Drawing.Size(170, 23);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.Text = "1234";
            this.PasswordTextbox.UseSelectable = true;
            this.PasswordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(148, 206);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseSelectable = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // MasterButton
            // 
            this.MasterButton.Location = new System.Drawing.Point(148, 235);
            this.MasterButton.Name = "MasterButton";
            this.MasterButton.Size = new System.Drawing.Size(75, 23);
            this.MasterButton.TabIndex = 5;
            this.MasterButton.Text = "マスタ";
            this.MasterButton.UseSelectable = true;
            this.MasterButton.Click += new System.EventHandler(this.MasterButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.metroContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "JM";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // metroContextMenu
            // 
            this.metroContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Size = new System.Drawing.Size(134, 34);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // JM0001Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MasterButton);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "JM0001Form";
            this.Text = "JobManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JM0001Form_FormClosing);
            this.Load += new System.EventHandler(this.JM0001Form_Load);
            this.ClientSizeChanged += new System.EventHandler(this.JM0001Form_ClientSizeChanged);
            this.metroContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroLabel UserNameLabel;
        internal MetroFramework.Controls.MetroLabel PasswordLabel;
        internal MetroFramework.Controls.MetroTextBox UserNameTextbox;
        internal MetroFramework.Controls.MetroTextBox PasswordTextbox;
        internal MetroFramework.Controls.MetroButton LoginBtn;
        private MetroFramework.Controls.MetroButton MasterButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    }
}