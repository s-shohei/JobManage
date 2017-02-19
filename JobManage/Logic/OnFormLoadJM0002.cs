using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Form;
using JobManage.DatabaseModel;
using JobManage.Dao;

namespace JobManage.Logic
{
    public class OnFormLoadJM0002 : AbstractFormLoad
    {
        private JM0002Form _form;

        public override void OnLoad(MetroForm form)
        {
            _form = (JM0002Form)form;
            // 初期表示用のデータを取得
            this.init();
        }

        private void init()
        {
            // ユーザID取得
            long userId = MUserDao._userId;

            using (var db = new JobManageEntities())
            {
                try
                {
                    List<JM0002ComboBoxListModel> test = (from mUser in db.M_USER
                                                            join mSyozoku in db.M_SYOZOKU on mUser.USER_ID equals mSyozoku.USER_ID
                                                            join mProject in db.M_PROJECT on mSyozoku.PROJECT_ID equals mProject.PROJECT_ID
                                                            join mRegion in db.M_REGION on mSyozoku.REGION_ID equals mRegion.REGION_ID
                                                            join mAnken in db.M_ANKEN on mSyozoku.ANKEN_ID equals mAnken.ANKEN_ID
                                                            where mUser.USER_ID == userId
                                                            select new JM0002ComboBoxListModel
                                                            {
                                                                ProjectName = mProject.PROJECT_NAME,
                                                                RegionName = mRegion.REGION_NAME,
                                                                AnkenName = mAnken.ANKEN_NAME
                                                            }).ToList<JM0002ComboBoxListModel>();
                    // コンボボックス用のデータを取得
                    List<string> projectNameList = test.Select(x=>x.ProjectName).Distinct().ToList<string>();
                    List<string> RegionNameList = test.Select(x => x.RegionName).Distinct().ToList<string>();
                    List<string> AnkenNameList = test.Select(x => x.AnkenName).Distinct().ToList<string>();

                    // コンボボックスへ値をセット
                    _form.ProjectCombBox.DataSource = projectNameList;
                    _form.RegionCombBox.DataSource = RegionNameList;
                    _form.AnkenCombBox.DataSource = AnkenNameList;

                }
                catch(Exception ex)
                {
                }
            }
        }
    }
}
