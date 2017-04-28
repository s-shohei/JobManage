using System;
using System.Collections.Generic;
using System.Linq;
using JobManageCore.DatabaseModel;
using JobManageCore.Interface;

namespace JobManageCore.Dao
{
    public class TTaskDetailDao : ITTaskDetail
    {
        public TTaskDetailDao() { }

        /// <summary>
        /// 作業内容をDB登録する
        /// </summary>
        /// <param name="taskDataList"></param>
        public void insertTaskData(List<T_TASK_DETAIL> taskDataList)
        {
            using (var db = new JobManageEntities())
            {
                foreach (T_TASK_DETAIL m in taskDataList)
                {
                    var record = db.T_TASK_DETAIL.Where(
                        x => x.USER_ID == m.USER_ID &&
                        x.PROJECT_NAME == m.PROJECT_NAME &&
                        x.REGION_NAME == m.REGION_NAME &&
                        x.ANKEN_NAME == m.ANKEN_NAME &&
                        x.TASK_NAME == m.TASK_NAME &&
                        x.START_TIME == m.START_TIME &&
                        x.END_TIME == m.END_TIME).ToList<T_TASK_DETAIL>();

                    if (record.Count == 0)
                    {
                        // 登録
                        db.T_TASK_DETAIL.Add(m);
                    }
                    else
                    {
                        // 更新
                        T_TASK_DETAIL model = record.First();
                        model.REMARKS = m.REMARKS;
                        db.SaveChanges();
                    }
                }
                // コミット
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 起動日の作業データを返す
        /// </summary>
        /// <returns></returns>
        public List<T_TASK_DETAIL> selectTodayTaskData()
        {
            List<T_TASK_DETAIL> result = new List<T_TASK_DETAIL>();
            // 起動日を取得
            string datatime = System.DateTime.Today.ToString().Substring(0, 10);

            using (var db = new JobManageEntities())
            {
                result = db.T_TASK_DETAIL.Where(x => x.START_TIME.Contains(datatime)).ToList<T_TASK_DETAIL>();
            }
            return result;
        }
    }
}
