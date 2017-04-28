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
using NLog;
using System.Data.Entity.Core;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace JobManage
{
    public partial class JM0001Form : MetroForm
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();

        public JM0001Form()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon(@".\JM.ico");
        }

        private void JM0001Form_Load(object sender, EventArgs e)
        {
            _logger.Info("[JM0001Form] : Load() Start");
            _logger.Info("[JM0001Form] : Load() End");
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            _logger.Info("[JM0001Form] : LoginBtn_Click() Start");
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.LoginButton);

            try
            {
                // ログインボタン押下処理
                switch (button.OnClickLogic(this))
                {
                    case 0:
                        // JM0001Formを非表示,JM0002Formを表示
                        JM0002Form JM0002Form = new JM0002Form(this);
                        JM0002Form.Show();
                        this.Hide();
                        break;

                    case 1:
                        // ログイン失敗
                        MessageBox.Show(ErrorMessageConst.ERR_MSG_LOGIN_FAILED);
                        break;
                }
            }
            catch (EntityException ee)
            {
                // DBエラー
                _logger.Log(LogLevel.Error, ee, "例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_DATABASE_ERROR);
            }
            catch(Exception ex)
            {
                // システムエラー
                _logger.Log(LogLevel.Error,ex,"例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_SYSTEM_ERROR);
            }
            _logger.Info("[JM0001Form] : LoginBtn_Click() End");
        }

        private void MasterButton_Click(object sender, EventArgs e)
        {
            _logger.Info("[JM0001Form] : MasterButton_Click() Start");

            var catalog = new AssemblyCatalog(typeof(Program).Assembly);
            var container = new CompositionContainer(catalog);


            JobManageMasterMente.JobManageMasterMente form = new JobManageMasterMente.JobManageMasterMente();
            form.Show();
            //this.Hide();
            _logger.Info("[JM0001Form] : MasterButton_Click() End");
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _logger.Info("[JM0001Form] : 終了ToolStripMenuItem_Click() Start");
            notifyIcon.Visible = false;
            this.Dispose();
            Application.Exit();
            _logger.Info("[JM0001Form] : 終了ToolStripMenuItem_Click() End");
        }

        private void JM0001Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logger.Info("[JM0001Form] : JM0001Form_FormClosing() Start");
            // トレイリストのアイコンを非表示にする
            notifyIcon.Visible = false;

            // 現在の状態が最小化の状態であれば通常の状態に戻す
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
            _logger.Info("[JM0001Form] : JM0001Form_FormClosing() End");
        }

        private void JM0001Form_ClientSizeChanged(object sender, EventArgs e)
        {
            _logger.Info("[JM0001Form] : JM0001Form_ClientSizeChanged() Start");
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                // フォームが最小化の状態であればフォームを非表示にする
                this.Hide();
                // トレイリストのアイコンを表示する
                notifyIcon.Visible = true;
            }
            _logger.Info("[JM0001Form] : JM0001Form_ClientSizeChanged() End");
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            _logger.Info("[JM0001Form] : notifyIcon_DoubleClick() Start");
            // フォームを表示する
            this.Visible = true;
            // 現在の状態が最小化の状態であれば通常の状態に戻す
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            // フォームをアクティブにする
            this.Activate();
            _logger.Info("[JM0001Form] : notifyIcon_DoubleClick() End");
        }
    }
}
