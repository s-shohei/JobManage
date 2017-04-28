using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;

namespace JobManageMasterMente
{
    public class RegionMasterMente : AbstractMasterMente
    {
        private JobManageEntities db = new JobManageEntities();

        public RegionMasterMente(JobManageMasterMente form)
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
                    db.M_REGION.Add(new M_REGION
                    {
                        SEQ = i,
                        REGION_ID = i + 1,
                        REGION_NAME = _masterMenteForm.MasterDataGrid.Rows[i].Cells[1].Value.ToString(),
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
                _masterDataList = db.M_REGION.Where(x => x.DEL_FLG != 1).ToList<Object>();
            }
        }

        private void delete()
        {
            db.M_REGION.Load();

            List<M_REGION> list = new List<M_REGION>();

            list = db.M_REGION.Local.ToList<M_REGION>();

            db.M_REGION.RemoveRange(list);

            db.SaveChanges();
        }
    }
}
