using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;

namespace JobManageMasterMente
{
    public class AnkenMasterMente : AbstractMasterMente
    {

        private JobManageEntities db = new JobManageEntities();

        public AnkenMasterMente(JobManageMasterMente form)
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
                    db.M_ANKEN.Add(new M_ANKEN
                    {
                        SEQ = i,
                        ANKEN_ID = i + 1,
                        ANKEN_NAME = _masterMenteForm.MasterDataGrid.Rows[i].Cells[1].Value.ToString(),
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
                _masterDataList = db.M_ANKEN.Where(x => x.DEL_FLG != 1).ToList<Object>();
            }
        }

        private void Delete()
        {
            db.M_ANKEN.Load();

            List<M_ANKEN> list = new List<M_ANKEN>();

            list = db.M_ANKEN.Local.ToList<M_ANKEN>();

            db.M_ANKEN.RemoveRange(list);

            db.SaveChanges();
        }
    }
}
