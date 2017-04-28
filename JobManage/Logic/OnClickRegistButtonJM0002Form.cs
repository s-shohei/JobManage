using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Form;
using JobManage.Dao;
using JobManageCore.DatabaseModel;
using JobManageCore.Interface;
using JobManageCore.Dao;

namespace JobManage.Logic
{
    public class OnClickRegistButtonJM0002Form : AbstractButton
    {

        private JM0002Form _form;
        // グリッドビューの全件のモデルリスト
        private List<T_TASK_DETAIL> _modelList;

        /// <summary>
        /// ボタン制御
        /// </summary>
        public override void ButtonStateChange()
        {
        }

        /// <summary>
        /// 登録ボタン押下時のメイン処理
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public override int OnClickLogic(MetroForm form)
        {
            int result = 1;

            _form = (JM0002Form)form;

            // 初期処理
            this.init();

            // 登録処理
            this.regist();

            return result;
        }

        /// <summary>
        /// 初期処理
        /// </summary>
        private void init()
        {
            // 行数を取得
            int row = _form.TaskDataGridView.RowCount - 1;

            _modelList = new List<T_TASK_DETAIL>();

            // グリッドビューの全件を読み込み、リストに設定
            for (int i = 0; i < row; i++)
            {
                T_TASK_DETAIL model = new T_TASK_DETAIL();

                model.USER_ID = MUserDao._userId;
                model.PROJECT_NAME = _form.TaskDataGridView.Rows[i].Cells[0].Value.ToString();
                model.REGION_NAME = _form.TaskDataGridView.Rows[i].Cells[1].Value.ToString();
                model.ANKEN_NAME = _form.TaskDataGridView.Rows[i].Cells[2].Value.ToString();
                model.TASK_NAME = _form.TaskDataGridView.Rows[i].Cells[3].Value.ToString();
                model.START_TIME = _form.TaskDataGridView.Rows[i].Cells[4].Value.ToString();
                model.END_TIME = _form.TaskDataGridView.Rows[i].Cells[5].Value.ToString();
                model.TASK_TIME = _form.TaskDataGridView.Rows[i].Cells[6].Value.ToString();
                model.REMARKS = _form.TaskDataGridView.Rows[i].Cells[7].Value.ToString();
                model.DEL_FLG = 0;

                _modelList.Add(model);
            }
        }

        /// <summary>
        /// 登録処理
        ///     行をDBに登録する
        /// </summary>
        /// <returns></returns>
        private void regist()
        {
            ITTaskDetail dao = new TTaskDetailDao();
            dao.insertTaskData(_modelList);
        }
    }
}
