using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.Interface;
using JobManageCore.DatabaseModel;
using JobManage.Dao;
using JobManageCore.Model;

namespace JobManageCore.Dao
{
    public class DatabaseDao : IDatabaseDao
    {
        public DatabaseDao() { }

        /// <summary>
        /// コンボボックスに設定する内容(プロジェクト・領域・案件)を返す
        /// </summary>
        /// <returns></returns>
        public List<JM0002ComboBoxListModel> selectComboBoxData()
        {
            List<JM0002ComboBoxListModel> result = new List<JM0002ComboBoxListModel>();

            using (var db = new JobManageEntities())
            {
                // ユーザID取得
                long userId = MUserDao._userId;

                result = (from mUser in db.M_USER
                          join mSyozoku in db.M_SYOZOKU on mUser.USER_ID equals mSyozoku.USER_ID
                          join mProject in db.M_PROJECT on mSyozoku.PROJECT_ID equals mProject.PROJECT_ID
                          join mRegion in db.M_REGION on mSyozoku.REGION_ID equals mRegion.REGION_ID
                          join mAnken in db.M_ANKEN on mSyozoku.ANKEN_ID equals mAnken.ANKEN_ID
                          where mUser.USER_ID == userId && mSyozoku.DEL_FLG != 0 && mProject.DEL_FLG != 0 && mRegion.DEL_FLG != 0 && mAnken.DEL_FLG != 0
                          select new JM0002ComboBoxListModel
                          {
                              ProjectName = mProject.PROJECT_NAME,
                              RegionName = mRegion.REGION_NAME,
                              AnkenName = mAnken.ANKEN_NAME
                          }).ToList<JM0002ComboBoxListModel>();
            }
            return result;
        }
    }
}
