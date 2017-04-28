using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;

namespace JobManageCore.Interface
{
    public interface ITTaskDetail
    {
        /// <summary>
        /// 起動日の作業データを返す
        /// </summary>
        /// <returns></returns>
        List<T_TASK_DETAIL> selectTodayTaskData();

        /// <summary>
        /// 作業内容をDB登録する
        /// </summary>
        /// <param name="taskDataList"></param>
        void insertTaskData(List<T_TASK_DETAIL> taskDataList);
    }
}
