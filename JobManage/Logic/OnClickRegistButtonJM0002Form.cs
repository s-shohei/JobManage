using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Model;
using JobManage.Form;

namespace JobManage.Logic
{
    public class OnClickRegistButtonJM0002Form : AbstractButton
    {
        private JM0002Form _form;
        private TaskDetailModel model;

        public override void ButtonStateChange()
        {
            
        }

        public override int OnClickLogic(MetroForm form)
        {
            int result = 0;

            // JM0001Formにキャスト
            _form = (JM0002Form)form;

            // 初期処理
            this.init();


            return 0;
        }

        private void init()
        {
            model = new TaskDetailModel();

            // 各種コンボボックスの値を記憶
            model.ProjectName = _form.ProjectCombBox.SelectedItem.ToString();
            model.RegionName  = _form.RegionCombBox.SelectedItem.ToString();
            model.AnkenName   = _form.AnkenCombBox.SelectedItem.ToString();
            model.TaskName    = _form.TaskComboBox.SelectedItem.ToString();

            // 現在の選択行数を取得
            int rowNum = _form.TaskDataGridView.SelectedRows.Count;

            // GridViewに値をセット
            _form.TaskDataGridView.Rows[rowNum].Cells[0].Value = rowNum + 1;
            _form.TaskDataGridView.Rows[rowNum].Cells[1].Value = model.ProjectName;
            _form.TaskDataGridView.Rows[rowNum].Cells[2].Value = model.RegionName;
            _form.TaskDataGridView.Rows[rowNum].Cells[3].Value = model.AnkenName;
            _form.TaskDataGridView.Rows[rowNum].Cells[4].Value = model.TaskName;
        }
    }
}
