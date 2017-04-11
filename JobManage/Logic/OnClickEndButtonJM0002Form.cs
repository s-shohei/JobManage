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
    public class OnClickEndButtonJM0002Form : AbstractButton
    {

        private JM0002Form _form;

        public override void ButtonStateChange()
        {
            _form.StartBtn.Enabled = true;
            //_form.EndBtn.Enabled = false;
            _form.RegistBtn.Enabled = true;
        }

        /// <summary>
        /// 終了ボタン押下時のメイン処理
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public override int OnClickLogic(MetroForm form)
        {
            int result = 0;

            _form = (JM0002Form)form;

            this.init();

            this.ButtonStateChange();

            // 行選択をクリア
            _form.TaskDataGridView.ClearSelection();

            return result;
        }

        private void init()
        {
            // 現在の選択数を取得
            if(_form.TaskDataGridView.CurrentRow == null)
            {
                return;
            }

            // 開始時刻を取得
            var startTime = _form.TaskDataGridView.CurrentRow.Cells[4].Value;
            if(startTime == null)
            {
                // 現在の選択行にデータが入っていないとみなし処理しない
                return;
            }

            // 終了時間を取得してセット
            _form.TaskDataGridView.CurrentRow.Cells[5].Value = DateTime.Now.ToString();

            // 終了時間を取得
            var endTime = _form.TaskDataGridView.CurrentRow.Cells[5].Value;

            // 作業時間を計算
            var taskTime = DateTime.Parse(endTime.ToString()) - DateTime.Parse(startTime.ToString());

            // 作業時間をセット
            _form.TaskDataGridView.CurrentRow.Cells[6].Value = taskTime;
        }
    }
}
