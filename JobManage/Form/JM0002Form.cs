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
using System.Data.Entity.Core;
using NLog;
using JobManage.Const;

namespace JobManage.Form
{
    public partial class JM0002Form : MetroForm
    {
        // ロガー
        private Logger _logger = LogManager.GetCurrentClassLogger();

        public JM0001Form _jm0001form;

        /// <summary>
        /// コンストラクタ
        ///     JM0001Formを受け取る
        ///     アイコンセット
        /// </summary>
        /// <param name="jm0001form"></param>
        public JM0002Form(JM0001Form jm0001form)
        {
            InitializeComponent();
            this._jm0001form = jm0001form;
            this.Icon = new System.Drawing.Icon(@".\JM.ico");
        }

        /// <summary>
        /// JM0002ロードイベント
        ///     コンボボックスへの値設定
        ///     当日のデータの設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JM0002Form_Load(object sender, EventArgs e)
        {
            _logger.Info("[JM0002Form] : JM0002Form_Load() Start");
            //[トップ画面読み込み処理](OnLoadLogicJM0002)を呼び出す
            FormLoadFactory factory = new FormLoadFactory();
            AbstractFormLoad formload = factory.CreateFormLoad(Const.JMConst.FormId.JM0002Form);
            try
            {
                // フォームロード時の処理
                formload.OnLoad(this);
            }
            catch (EntityException ee)
            {
                // DBエラー
                _logger.Log(LogLevel.Error, ee, "例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_DATABASE_ERROR);
            }
            catch (Exception ex)
            {
                // システムエラー
                _logger.Log(LogLevel.Error, ex, "例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_SYSTEM_ERROR);
            }
            _logger.Info("[JM0002Form] : JM0002Form_Load() End");
        }
        /// <summary>
        /// 開始ボタン押下時
        ///     開始時刻をグリッドビューに設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            _logger.Info("[JM0002Form] : StartBtn_Click() Start");
            // ボタン押下時の処理クラスを生成
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.StartButton);

            try
            {
                // ボタン押下時の処理を実行
                button.OnClickLogic(this);
            }
            catch (Exception ex)
            {
                // システムエラー
                _logger.Log(LogLevel.Error, ex, "例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_SYSTEM_ERROR);
            }
            _logger.Info("[JM0002Form] : StartBtn_Click() End");
        }

        /// <summary>
        /// 終了ボタン押下時
        ///     終了時間・作業時間を設定
        ///     選択行の内容をDBに登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndBtn_Click(object sender, EventArgs e)
        {
            _logger.Info("[JM0002Form] : EndBtn_Click() Start");
            // ボタン押下時の処理クラスを生成
            AbstractButton end_button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.EndButton);
            AbstractButton regist_button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.RegistButton);

            try
            {
                // ボタン押下時の処理を実行
                end_button.OnClickLogic(this);
                // 終了ボタン押下時にDB登録も実行
                regist_button.OnClickLogic(this);

            }
            catch (EntityException ee)
            {
                // DBエラー
                _logger.Log(LogLevel.Error, ee, "例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_DATABASE_ERROR);
            }
            catch (Exception ex)
            {
                // システムエラー
                _logger.Log(LogLevel.Error, ex, "例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_SYSTEM_ERROR);
            }
            _logger.Info("[JM0002Form] : StartBtn_Click() End");
        }

        /// <summary>
        /// 登録ボタン押下時
        ///     選択行の内容をDBに登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistBtn_Click(object sender, EventArgs e)
        {
            _logger.Info("[JM0002Form] : RegistBtn_Click() Start");
            // ボタン押下時の処理クラスを生成
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.RegistButton);
            try
            {
                // 作業内容を登録する
                button.OnClickLogic(this);
            }
            catch (EntityException ee)
            {
                // DBエラー
                _logger.Log(LogLevel.Error, ee, "例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_DATABASE_ERROR);
            }
            catch (Exception ex)
            {
                // システムエラー
                _logger.Log(LogLevel.Error, ex, "例外発生");
                MessageBox.Show(ErrorMessageConst.ERR_MSG_SYSTEM_ERROR);
            }

            MessageBox.Show("登録完了！");
            _logger.Info("[JM0002Form] : StartBtn_Click() End");

        }

        /// <summary>
        /// JM0003フォーム(分析画面)を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AggButton_Click(object sender, EventArgs e)
        {
            _logger.Info("[JM0002Form] : AggButton_Click() Start");
            JM0003Form JM0003Form = new JM0003Form();
            JM0003Form.Show();
            _logger.Info("[JM0002Form] : StartBtn_Click() End");
        }

        /// <summary>
        /// フォームサイズ変更時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JM0002Form_ClientSizeChanged(object sender, EventArgs e)
        {
            _logger.Info("[JM0002Form] : JM0002Form_ClientSizeChanged() Start");
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                // フォームが最小化の状態であればフォームを非表示にする
                this.Hide();
            }
            _logger.Info("[JM0002Form] : StartBtn_Click() End");
        }
        /// <summary>
        /// フォームクローズ時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JM0002Form_Closing(object sender, FormClosingEventArgs e)
        {
            _logger.Info("[JM0002Form] : JM0002Form_Closing() Start");
            this.Dispose();
            _logger.Info("[JM0002Form] : StartBtn_Click() End");
        }
        /// <summary>
        /// マスタボタン押下時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterButton_Click_1(object sender, EventArgs e)
        {
            _logger.Info("[JM0002Form] : MasterButton_Click_1() Start");
            JobManageMasterMente.JobManageMasterMente form = new JobManageMasterMente.JobManageMasterMente();
            form.Show();
            _logger.Info("[JM0002Form] : MasterButton_Click_1() End");
        }
    }
}
