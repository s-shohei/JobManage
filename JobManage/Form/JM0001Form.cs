using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManageCore.DatabaseModel;
using MetroFramework.Forms;
using JobManage.Logic;
using JobManage.Const;
using JobManage.Form;
using JobManageMasterMente;

namespace JobManage
{
    public partial class JM0001Form : MetroForm
    {
        private Boolean _loginFlg = false;

        public JM0001Form()
        {
           InitializeComponent();
            this.Icon = new System.Drawing.Icon(@".\JM.ico");
        }

        private void JM0001Form_Load(object sender, EventArgs e)
        {
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.LoginButton);

            try
            {
                // ログインボタン押下処理
                switch(button.OnClickLogic(this))
                {
                    case 0:
                        // JM0001Formを非表示,JM0002Formを表示
                        JM0002Form JM0002Form = new JM0002Form(this);
                        JM0002Form.Show();
                        this.Hide();
                        _loginFlg = true;
                        break;

                    case 1:
                        // ログイン失敗
                        MessageBox.Show(ErrorMessageConst.ERR_MSG_LOGIN_FAILED);
                        break;
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
                // システムエラー
                MessageBox.Show(ErrorMessageConst.ERR_MSG_SYSTEM_ERROR);
            }
        }

        private void MasterButton_Click(object sender, EventArgs e)
        {
            JobManageMasterMente.JobManageMasterMente form = new JobManageMasterMente.JobManageMasterMente();
            form.Show();
            //this.Hide();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Dispose();
            Application.Exit();
        }

        private void JM0001Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // トレイリストのアイコンを非表示にする
            notifyIcon.Visible = false;

            // 現在の状態が最小化の状態であれば通常の状態に戻す
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void JM0001Form_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                // フォームが最小化の状態であればフォームを非表示にする
                this.Hide();
                // トレイリストのアイコンを表示する
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            // フォームを表示する
            this.Visible = true;
            // 現在の状態が最小化の状態であれば通常の状態に戻す
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            // フォームをアクティブにする
            this.Activate();
        }
    }
}
