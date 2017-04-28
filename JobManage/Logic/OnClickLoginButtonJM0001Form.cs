using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManage.Dao;
using JobManage.Logic;
using MetroFramework.Forms;
using JobManageCore.DatabaseModel;
using JobManageCore.Interface;

namespace JobManage.Logic
{
    //ログイン押下時のロジック
    public class OnClickLoginButtonJM0001Form:AbstractButton
    {
        private JM0001Form _form;

        /// <summary>
        /// ユーザ名とパスワードでユーザ認証
        /// </summary>
        /// <param name="form"></param>
        /// <returns>成功：0 失敗:1</returns>
        public override int OnClickLogic(MetroForm form)
        {
            // 返却値
            int result = 0;

            // JM0001Formにキャスト
            _form = (JM0001Form)form;

            // ログイン処理
            if(!this.LoginProcess())
            {
                result = 1;
            }
            return result;
        }
        
        public override void ButtonStateChange()
        {

        }

        private bool LoginProcess()
        {
            // 返却値
            bool result = false;

            // ユーザ名の取得
            string userName = _form.UserNameTextbox.Text;
            // パスワードの取得
            string password = _form.PasswordTextbox.Text;

            // Daoインスタンス生成
            IMUserDao dao = new MUserDao();

            // パスワードの照合
            List<M_USER> mUser = dao.selectUserInfo(userName,password);

            if(mUser != null && mUser.Count != 0)
            {
                // レコードが取得できる場合は成功
                result = true;
            }

            return result;
        }
    }
}
