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
            long userId = MUserDao.SelectUserId(_form._jm0001form.UserNameTextbox.Text);
            // 領域ID取得
            long regionId = MRegionDao.SelectRegionId(userId);

            // 領域リストをコンボボックスへ設定
            List<string> regionList = MRegionDao.SelectRecord(userId);
            _form.RegionCombBox.DataSource = regionList;

            // 案件リストをコンボボックスへ設定
            List<string> projectList = MProjectDao.SelectRecord(userId,regionId);
            _form.ProjectCombBox.DataSource = projectList;



        }
    }
}
