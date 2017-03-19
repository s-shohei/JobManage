using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;

namespace JobManageMasterMente
{
    public class AnkenMasterMente : AbstractMasterMente
    {
        public AnkenMasterMente(JobManageMasterMente form)
        {
            _masterMenteForm = form;
        }

        public override void Insert()
        {
            throw new NotImplementedException();
        }

        public override void Select()
        {
            using (var db = new JobManageEntities())
            {
                _masterDataList = db.M_ANKEN.Where(x => x.DEL_FLG != 1).ToList<Object>();
            }
        }
    }
}
