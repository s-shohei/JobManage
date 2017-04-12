using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage.Dao;
using JobManage.Form;
using JobManage.Util;
using JobManageCore.DatabaseModel;
using MetroFramework.Forms;

namespace JobManage.Logic
{
    public class OnClickAggAnkenDayButtonJM0003Form : AbstractAggAnken
    {

        private string day;
        private long userId;

        public override void ButtonStateChange()
        {
            throw new NotImplementedException();
        }

        public override void getAggTaskDataList()
        {
            _taskDataList = new List<T_TASK_DETAIL>();

            using (var db = new JobManageEntities())
            {
                db.T_TASK_DETAIL.Load();

                _taskDataList = db.T_TASK_DETAIL.Local.Where(x => x.USER_ID == userId && x.START_TIME.Contains(day)).ToList<T_TASK_DETAIL>();
            }
        }

        public override void init()
        {
            // 月を取得
            day = TimerUtil.UntilDay();
            // ユーザIDを取得
            userId = MUserDao._userId;
        }

        public override int OnClickLogic(MetroForm form)
        {
            int result = 0;

            _form = (JM0003Form)form;

            init();

            getAggTaskDataList();

            aggTaskData();

            aggDisplay();

            return result;
        }
    }
}
