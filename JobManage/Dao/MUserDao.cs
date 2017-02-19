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
        public static long _userId = 0;

        public static List<M_USER> SelectRecord(string userName, string passWord)
        {
            List<M_USER> result = null;

            using (var db = new JobManageEntities())
            {
                result = db.M_USER.Where(x => x.USER_NAME == userName && x.USER_PASSWORD == passWord).ToList<M_USER>();
                _userId = result.First().USER_ID;
            }

            return result;
        }
    }
}
