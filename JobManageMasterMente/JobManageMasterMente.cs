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
using NLog;

namespace JobManageMasterMente
{
    public partial class JobManageMasterMente : MetroForm
    {
        // ロガー
        private Logger _logger = LogManager.GetCurrentClassLogger();

        AbstractMasterMente masterMente;

        public JobManageMasterMente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JobManageMasterMente_Load(object sender, EventArgs e)
        {
            _logger.Info("[JobManageMasterMente] : JobManageMasterMente_Load() Start");
            _logger.Info("[JobManageMasterMente] : JobManageMasterMente_Load() End");
        }

        /// <summary>
        /// マスタ取得時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterGetButton_Click(object sender, EventArgs e)
        {
            _logger.Info("[JobManageMasterMente] : MasterGetButton_Click() Start");
            string masterName = "";
            if (MasterComboBox.SelectedIndex !=-1)
            {
                // 選択されたマスタ名を取得
                masterName = MasterComboBox.SelectedItem.ToString();
                _logger.Info("[JobManageMasterMente] : masterName = " + masterName);
            }
            else
            {
                // 選択されていない場合は処理しない
                _logger.Info("[JobManageMasterMente] : マスタが選択されていない。");
                return;
            }

            // 選択されたマスタの実クラスを呼び出し、マスタ情報を表示する
            switch(masterName)
            {
                case "プロジェクト":
                    masterMente = new ProjectMasterMente(this);
                    masterMente.Display();
                    break;
                case "領域":
                    masterMente = new RegionMasterMente(this);
                    masterMente.Display();
                    break;
                case "案件":
                    masterMente = new AnkenMasterMente(this);
                    masterMente.Display();
                    break;
                case "タスク":
                    masterMente = new TaskMasterMente(this);
                    masterMente.Display();
                    break;
            }
            _logger.Info("[JobManageMasterMente] : MasterGetButton_Click() End");
        }

        /// <summary>
        /// マスタ登録時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterInsButton_Click(object sender, EventArgs e)
        {
            _logger.Info("[JobManageMasterMente] : MasterInsButton_Click() Start");
            masterMente.Insert();
            masterMente.Display();
            _logger.Info("[JobManageMasterMente] : MasterInsButton_Click() End");
        }

        /// <summary>
        /// 終了時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndButton_Click(object sender, EventArgs e)
        {
            _logger.Info("[JobManageMasterMente] : EndButton_Click() Start");
            this.Close();
            _logger.Info("[JobManageMasterMente] : EndButton_Click() End");
        }

        /// <summary>
        /// マスタ削除時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterDelButton_Click(object sender, EventArgs e)
        {
            _logger.Info("[JobManageMasterMente] : MasterDelButton_Click() Start");
            masterMente.Delete();
            _logger.Info("[JobManageMasterMente] : MasterDelButton_Click() End");
        }
    }
}
