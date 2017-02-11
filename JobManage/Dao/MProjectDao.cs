using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage.DatabaseModel;
namespace JobManage.Dao
{
    public class MProjectDao
    {
        public static List<string> SelectRecord(long userId,long regionId)
        {
            List<string> recordList = null;

            using (var db = new JobManageEntities())
            {
                recordList = db.M_PROJECT.Where(x => x.USER_ID == userId && x.REGION_ID == regionId).Select(x => x.PROJECT_NAME).ToList();
            }

            return recordList;
        }
    }
}
