using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Util;
using JobManageCore.DatabaseModel;
using JobManage.Dao;
using System.Data.Entity;
using JobManage.Form;
using JobManage.Model;

namespace JobManage.Logic
{
    public class OnClickAggAnkenMonthButtonJM0003Form : AbstractAggAnken
    {
        private string month;
        private long userId;

        public override void ButtonStateChange()
        {
            throw new NotImplementedException();
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

        public override void init()
        {
            // 月を取得
            month = TimerUtil.UntilMonth();
            // ユーザIDを取得
            userId = MUserDao._userId;
        }

        public override void getAggTaskDataList()
        {
            _taskDataList = new List<T_TASK_DETAIL>();

            using (var db = new JobManageEntities())
            {
                db.T_TASK_DETAIL.Load();

                _taskDataList = db.T_TASK_DETAIL.Local.Where(x => x.USER_ID == userId && x.START_TIME.Contains(month)).ToList<T_TASK_DETAIL>();
            }
        }
    }
}
