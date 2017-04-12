using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using JobManage.Form;
using JobManage.Logic;
namespace JobManage.Form
{
    public partial class JM0002Form : MetroForm
    {

        public JM0001Form _jm0001form;

        public JM0002Form(JM0001Form jm0001form)
        {
            InitializeComponent();
            this._jm0001form = jm0001form;
            this.Icon = new System.Drawing.Icon(@".\JM.ico");
        }

        private void JM0002Form_Load(object sender, EventArgs e)
        {
            //[トップ画面読み込み処理](OnLoadLogicJM0002)を呼び出す
            FormLoadFactory factory = new FormLoadFactory();
            AbstractFormLoad formload = factory.CreateFormLoad(Const.JMConst.FormId.JM0002Form);
            formload.OnLoad(this);
        }
        /// <summary>
        /// 開始ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            // ボタン押下時の処理クラスを生成
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.StartButton);
            // ボタン押下時の処理を実行
            button.OnClickLogic(this);
        }

        /// <summary>
        /// 終了ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndBtn_Click(object sender, EventArgs e)
        {
            // ボタン押下時の処理クラスを生成
            AbstractButton end_button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.EndButton);
            AbstractButton regist_button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.RegistButton);
            // ボタン押下時の処理を実行
            // 終了ボタン押下時にDB登録も実行
            end_button.OnClickLogic(this);
            regist_button.OnClickLogic(this);
        }

        /// <summary>
        /// 登録ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistBtn_Click(object sender, EventArgs e)
        {
            // ボタン押下時の処理クラスを生成
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.RegistButton);
            // ボタン押下時の処理を実行
            if(button.OnClickLogic(this) == 0)
            {
                MessageBox.Show("登録完了！");
            }
        }

        private void AggButton_Click(object sender, EventArgs e)
        {
            JM0003Form JM0003Form = new JM0003Form();
            JM0003Form.Show();
            //this.Hide();
        }

        private void JM0002Form_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                // フォームが最小化の状態であればフォームを非表示にする
                this.Hide();
            }
        }

        private void JM0002Form_Closing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void MasterButton_Click(object sender, EventArgs e)
        {
            JobManageMasterMente.JobManageMasterMente form = new JobManageMasterMente.JobManageMasterMente();
            form.Show();
        }

        private void MasterButton_Click_1(object sender, EventArgs e)
        {
            JobManageMasterMente.JobManageMasterMente form = new JobManageMasterMente.JobManageMasterMente();
            form.Show();
        }
    }
}
