using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;

namespace JobManageMasterMente
{
    public class TaskMasterMente : AbstractMasterMente
    {
        private JobManageEntities db = new JobManageEntities();

        public TaskMasterMente(JobManageMasterMente form)
        {
            _masterMenteForm = form;
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Insert()
        {
            using (db)
            {
                Delete();

                for (int i = 0; i < _masterMenteForm.MasterDataGrid.Rows.Count - 1; i++)
                {
                    db.M_TASK.Add(new M_TASK
                    {
                        SEQ = i,
                        TASK_ID = i + 1,
                        TASK_NAME = _masterMenteForm.MasterDataGrid.Rows[i].Cells[1].Value.ToString(),
                        DEL_FLG = 0
                    });
                }
                db.SaveChanges();
            }
        }

        public override void Select()
        {
            using (var db = new JobManageEntities())
            {
                _masterDataList = db.M_TASK.Where(x => x.DEL_FLG != 1).ToList<Object>();
            }
        }

        private void delete()
        {
            db.M_TASK.Load();

            List<M_TASK> list = new List<M_TASK>();

            list = db.M_TASK.Local.ToList<M_TASK>();

            db.M_TASK.RemoveRange(list);

            db.SaveChanges();
        }
    }
}
