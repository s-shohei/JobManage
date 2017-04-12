using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage.Form;
using JobManage.Model;
using JobManageCore.DatabaseModel;

namespace JobManage.Logic
{
    public abstract class AbstractAggAnken : AbstractButton
    {
        protected JM0003Form _form;

        protected List<T_TASK_DETAIL> _taskDataList;

        protected List<JM0003AggModel> _aggDataList = new List<JM0003AggModel>();

        public abstract void init();

        public abstract void getAggTaskDataList();

        public void aggTaskData()
        {
            List<string> aggAnkenNameList = new List<string>();
            aggAnkenNameList = _taskDataList.Select(x => x.ANKEN_NAME).Distinct().ToList<string>();

            foreach (string ankne in aggAnkenNameList)
            {
                List<string> timeList = new List<string>();
                timeList = _taskDataList.Where(x => x.ANKEN_NAME == ankne).Select(x => x.TASK_TIME).ToList<string>();
                TimeSpan span1 = new TimeSpan(0, 0, 0);
                foreach (string time in timeList)
                {
                    span1 += TimeSpan.Parse(time);
                }
                JM0003AggModel model = new JM0003AggModel();
                model.aggAnkenName = ankne;
                model.aggTaskTime = span1;
                _aggDataList.Add(model);

            }
        }

        public void aggDisplay()
        {
            gridViewInit();

            foreach (JM0003AggModel model in _aggDataList)
            {
                // GridViewに値をセット
                int row = _form.AggGrid.Rows.Add(
                    model.aggAnkenName,
                    model.aggTaskTime
                );

                // 行選択
                _form.AggGrid.Rows[row].Selected = true;
                _form.AggGrid.CurrentCell = _form.AggGrid.Rows[row].Cells[0];
            }
        }

        public void gridViewInit()
        {
            // Grid初期化
            _form.AggGrid.Rows.Clear();
        }
    }
}
