using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;
using JobManageCore.Interface;

namespace JobManage.Dao
{
    public class MUserDao : IMUserDao
    {
        public static long _userId;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MUserDao() { }
        
        /// <summary>
        /// ユーザマスタからユーザ情報を取得
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public List<M_USER> selectUserInfo(string userName, string password)
        {
            List<M_USER> result = null;

            using (var db = new JobManageEntities())
            {
                result = db.M_USER.Where(x => x.USER_NAME == userName && x.USER_PASSWORD == password).ToList<M_USER>();
                _userId = result.First().USER_ID;
            }

            return result;
        }
    }
}
