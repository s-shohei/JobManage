using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;
using JobManageCore.Interface;

namespace JobManageCore.Dao
{
    public class MTaskDao : IMTaskDao
    {
        /// <summary>
        /// 作業内容を全件返す
        /// </summary>
        /// <returns></returns>
        public List<string> selectTaskList()
        {
            List<string> result = new List<string>();
            using (var db = new JobManageEntities())
            {
                result = db.M_TASK.Select(x => x.TASK_NAME).ToList<string>();
            }

            return result;
        }
    }
}
