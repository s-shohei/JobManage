using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage.DatabaseModel;
namespace JobManage.Dao
{
    public class MRegionDao
    {
        public static List<string> SelectRecord(long userId)
        {
            List<string> recordList = null;

            using (var db = new JobManageEntities())
            {
                recordList = db.M_REGION.Where(x => x.USER_ID == userId).Select(x => x.REGION_NAME).ToList();
            }

            return recordList;
        }

        public static long SelectRegionId(long userID)
        {
            List<long> result;

            using (var db = new JobManageEntities())
            {
                result = db.M_REGION.Where(x => x.USER_ID == userID).Select(x => x.REGION_ID).ToList();
            }
            return result.First();
        }
    }
}
