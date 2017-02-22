using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Form;
using JobManage.Dao;
using JobManage.DatabaseModel;

namespace JobManage.Logic
{
    public class OnClickRegistButtonJM0002Form : AbstractButton
    {

        private JM0002Form _form;

        private List<T_TASK_DETAIL> modelList;

        public override void ButtonStateChange()
        {
            throw new NotImplementedException();
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

            this.init();

            if(this.regist())
            {
                result = 0;
            }
            else
            {
                result = 1;
            }

            return result;
        }

        private void init()
        {
            // 行数を取得
            int row = _form.TaskDataGridView.RowCount - 1;

            modelList = new List<T_TASK_DETAIL>();

            for(int i = 0; i < row; i++)
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

                modelList.Add(model);
            }
        }

        private bool regist()
        {
            bool result = false;

            using (var db = new JobManageEntities())
            {
                try
                {
                    foreach (T_TASK_DETAIL m in modelList)
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
                            // コミット
                            db.SaveChanges();
                            result = true;
                        }
                        else
                        {
                            // 更新
                            result = true;
                        }
                    }
                }
                catch(Exception ex)
                {
                }
            }

            return result;
        }
    }
}
