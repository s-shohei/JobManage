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
        public static List<M_USER> SelectRecord(string user_name,string user_password)
        {
            List<M_USER> recordList = null;

            using (var db = new JobManageEntities())
            {
                recordList = db.M_USER.Where(x => x.USER_NAME == user_name && x.USER_PASSWORD == user_password).ToList();
            }

            return recordList;
        }
    }
}
