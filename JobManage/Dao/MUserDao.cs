using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage.DatabaseModel;

namespace JobManage.Dao
{
    public class MUserDao
    {
        public M_USER SelectPrimaryRecord(string user_name,string user_password)
        {
            M_USER record;

            using (var db = new JobManageEntities())
            {
                record = db.M_USER.Where(x => x.USER_NAME == user_name && x.USER_PASSWORD == user_password).First();
            }

            return record;
        }
    }
}
