using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Form;
using JobManageCore.DatabaseModel;
using JobManage.Dao;

namespace JobManage.Logic
{
    public class OnFormLoadJM0002 : AbstractFormLoad
    {
        private JM0002Form _form;
        JobManageEntities db = new JobManageEntities();
        private long _userId;

        public override void OnLoad(MetroForm form)
        {
            _form = (JM0002Form)form;

            _userId = MUserDao._userId;

            // 初期表示用のデータを取得
            this.init();
        }

        private void init()
        {
            // ユーザID取得
            

            using (db)
            {
                try
                {
                    // コンボボックスの内容を取得しセット
                    setComboboxValue();

                    // 当日の作業内容を取得しセット
                    setTodayTask();

                }
                catch(Exception ex)
                {
                }
            }
        }

        private void setComboboxValue()
        {
            List<JM0002ComboBoxListModel> test = (from mUser in db.M_USER
                                                  join mSyozoku in db.M_SYOZOKU on mUser.USER_ID equals mSyozoku.USER_ID
                                                  join mProject in db.M_PROJECT on mSyozoku.PROJECT_ID equals mProject.PROJECT_ID
                                                  join mRegion in db.M_REGION on mSyozoku.REGION_ID equals mRegion.REGION_ID
                                                  join mAnken in db.M_ANKEN on mSyozoku.ANKEN_ID equals mAnken.ANKEN_ID
                                                  where mUser.USER_ID == _userId
                                                  select new JM0002ComboBoxListModel
                                                  {
                                                      ProjectName = mProject.PROJECT_NAME,
                                                      RegionName = mRegion.REGION_NAME,
                                                      AnkenName = mAnken.ANKEN_NAME
                                                  }).ToList<JM0002ComboBoxListModel>();
            // 作業項目名を取得
            List<string> taskNameList = db.M_TASK.Select(x => x.TASK_NAME).ToList<string>();

            // コンボボックス用のデータを取得
            List<string> projectNameList = test.Select(x => x.ProjectName).Distinct().ToList<string>();
            List<string> RegionNameList = test.Select(x => x.RegionName).Distinct().ToList<string>();
            List<string> AnkenNameList = test.Select(x => x.AnkenName).Distinct().ToList<string>();

            // コンボボックスへ値をセット
            _form.ProjectCombBox.DataSource = projectNameList;
            _form.RegionCombBox.DataSource = RegionNameList;
            _form.AnkenCombBox.DataSource = AnkenNameList;
            _form.TaskComboBox.DataSource = taskNameList;
        }

        private void setTodayTask()
        {
            List<T_TASK_DETAIL> dataList = new List<T_TASK_DETAIL>();
            string datatime = System.DateTime.Today.ToString().Substring(0,10);
            dataList = db.T_TASK_DETAIL.Where(x => x.START_TIME.Contains(datatime)).ToList<T_TASK_DETAIL>();

            foreach(T_TASK_DETAIL data in dataList)
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
