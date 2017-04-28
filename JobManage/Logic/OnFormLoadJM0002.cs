using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Form;
using JobManageCore.DatabaseModel;
using JobManageCore.Interface;
using JobManageCore.Dao;
using JobManageCore.Model;

namespace JobManage.Logic
{
    public class OnFormLoadJM0002 : AbstractFormLoad
    {
        private JM0002Form _form;

        public override void OnLoad(MetroForm form)
        {
            _form = (JM0002Form)form;

            // 初期処理
            this.init();
        }

        /// <summary>
        /// 初期処理
        ///     コンボボックスに値を設定
        ///     グリッドビューに作業データを設定
        /// </summary>
        private void init()
        {
                // コンボボックスの内容を取得しセット
                setComboboxValue();

                // 当日の作業内容を取得しセット
                setTodayTask();
        }

        /// <summary>
        /// コンボボックスに値を設定する
        /// </summary>
        private void setComboboxValue()
        {
            IDatabaseDao dDao = new DatabaseDao();

            // コンボボックスの内容を取得
            List<JM0002ComboBoxListModel> dataList = dDao.selectComboBoxData();

            // コンボボックス用のデータを取得
            List<string> projectNameList = dataList.Select(x => x.ProjectName).Distinct().ToList<string>();
            List<string> RegionNameList = dataList.Select(x => x.RegionName).Distinct().ToList<string>();
            List<string> AnkenNameList = dataList.Select(x => x.AnkenName).Distinct().ToList<string>();

            // 作業項目名を取得
            IMTaskDao tDao = new MTaskDao();
            List<string> taskNameList = tDao.selectTaskList();

            // コンボボックスへ値をセット
            _form.ProjectCombBox.DataSource = projectNameList;
            _form.RegionCombBox.DataSource = RegionNameList;
            _form.AnkenCombBox.DataSource = AnkenNameList;
            _form.TaskComboBox.DataSource = taskNameList;
        }

        /// <summary>
        /// 起動日の作業がある場合は、グリッドビューに設定する
        /// </summary>
        private void setTodayTask()
        {
            ITTaskDetail dao = new TTaskDetailDao();
            List<T_TASK_DETAIL> dataList = dao.selectTodayTaskData();

            foreach (T_TASK_DETAIL data in dataList)
            {
                // GridViewに値をセット
                int row = _form.TaskDataGridView.Rows.Add(
                    data.PROJECT_NAME,
                    data.REGION_NAME,
                    data.ANKEN_NAME,
                    data.TASK_NAME,
                    data.START_TIME,
                    data.END_TIME,
                    data.TASK_TIME,
                    data.REMARKS
                );

                // 行選択
                _form.TaskDataGridView.Rows[row].Selected = true;
                _form.TaskDataGridView.CurrentCell = _form.TaskDataGridView.Rows[row].Cells[0];
            }
        }
    }
}
