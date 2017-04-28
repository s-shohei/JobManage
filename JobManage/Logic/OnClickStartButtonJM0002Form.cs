using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Form;
using JobManage.Util;
using JobManage.Const;

namespace JobManage.Logic
{
    public class OnClickStartButtonJM0002Form : AbstractButton
    {
        private JM0002Form _form;

        /// <summary>
        /// ボタン制御
        /// </summary>
        public override void ButtonStateChange()
        {
            _form.StartBtn.Enabled = false;
            _form.EndBtn.Enabled = true;
            _form.RegistBtn.Enabled = false;

        }

        /// <summary>
        /// 開始ボタン押下時のメイン処理
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public override int OnClickLogic(MetroForm form)
        {
            int result = 0;

            // JM0001Formにキャスト
            _form = (JM0002Form)form;

            // 初期処理
            this.init();

            // ボタン制御
            this.ButtonStateChange();

            return result;
        }

        /// <summary>
        /// 初期処理
        ///     選択したプロジェクト・領域・案件・作業内容に開始時刻を設定
        /// </summary>
        private void init()
        {

            // 開始時刻を取得
            var startTime = DateTime.Now.ToString();

            // GridViewに値をセット
            int row =_form.TaskDataGridView.Rows.Add(
                _form.ProjectCombBox.SelectedItem.ToString(),
                _form.RegionCombBox.SelectedItem.ToString(),
                _form.AnkenCombBox.SelectedItem.ToString(),
                _form.TaskComboBox.SelectedItem.ToString(),
                startTime,
                "",
                "",
                ""
            );

            // 行選択
            _form.TaskDataGridView.Rows[row].Selected = true;
            _form.TaskDataGridView.CurrentCell = _form.TaskDataGridView.Rows[row].Cells[0];

        }
    }
}
