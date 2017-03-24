using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManageCore.DatabaseModel;
namespace JobManageMasterMente
{
    public class ProjectMasterMente : AbstractMasterMente
    {
        private JobManageEntities db = new JobManageEntities();

        public ProjectMasterMente(JobManageMasterMente form)
        {
            _masterMenteForm = form;
        }

        public override void Insert()
        {
            using (db)
            {
                Delete();

                for (int i = 0; i < _masterMenteForm.MasterDataGrid.Rows.Count - 1; i++)
                {
                    db.M_PROJECT.Add(new M_PROJECT
                    {
                        SEQ = i,
                        PROJECT_ID = i + 1,
                        PROJECT_NAME = _masterMenteForm.MasterDataGrid.Rows[i].Cells[1].Value.ToString(),
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
                _masterDataList = db.M_PROJECT.Where(x => x.DEL_FLG != 1).ToList<Object>();
            }
        }

        private void Delete()
        {
            db.M_PROJECT.Load();

            List<M_PROJECT> list = new List<M_PROJECT>();

            list = db.M_PROJECT.Local.ToList<M_PROJECT>();

            db.M_PROJECT.RemoveRange(list);

            db.SaveChanges();
        }
    }
}
