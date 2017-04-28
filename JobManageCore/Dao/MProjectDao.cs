using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.Interface;
using JobManageCore.DatabaseModel;

namespace JobManageCore.Dao
{
    public class MProjectDao : IMProjectDao
    {
        public void delete(long projectId)
        {
            using (var db = new JobManageEntities())
            {
                var mProject = db.M_PROJECT.Where(x=>x.PROJECT_ID == projectId).First();
                mProject.DEL_FLG = 1;

                db.SaveChanges();
            }
        }

        public void deleteAll()
        {
            using (var db = new JobManageEntities())
            {
                List<M_PROJECT> list = new List<M_PROJECT>();

                list = db.M_PROJECT.ToList<M_PROJECT>();

                db.M_PROJECT.RemoveRange(list);

                db.SaveChanges();
            }
        }

        public void insert(List<string> projectNameList)
        {
            using (var db = new JobManageEntities())
            {
                deleteAll();

                for (int i = 0; i < projectNameList.Count(); i++)
                {
                    db.M_PROJECT.Add(new M_PROJECT
                    {
                        SEQ = i,
                        PROJECT_ID = i + 1,
                        PROJECT_NAME = projectNameList.ElementAt(i),
                        DEL_FLG = 0
                    });
                }
                db.SaveChanges();
            }
        }

        public List<object> select()
        {
            List<object> result = new List<object>();
            using (var db = new JobManageEntities())
            {
                result = db.M_PROJECT.Where(x => x.DEL_FLG != 1).ToList<Object>();
            }
            return result;
        }
    }
}
