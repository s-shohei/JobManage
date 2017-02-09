using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManage.DatabaseModel;
using MetroFramework.Forms;
using JobManage.Logic;
using JobManage.Const;

namespace JobManage
{
    public partial class JM0001Form : MetroForm
    {
        public JM0001Form()
        {
           InitializeComponent();
        }

        private void JM0001Form_Load(object sender, EventArgs e)
        {
            using (var db = new JobManageEntities())
            {

                var userList = db.M_USER;

                foreach(var user in userList)
                {
                    string test = user.USER_ID.ToString() + "  ";
                    test = test + user.USER_NAME + "\r\n";
                }
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Factoryよりインスタンスを生成
            ButtonFactory factory = new ButtonFactory();
            AbstractButton button = factory.CreateButtonFactory(Const.JMConst.ButtonId.LoginButton);

            try
            {
                // ログインボタン押下処理
                switch(button.OnClickLogic(this))
                {
                    case 0:
                        // JM0002Formを表示
                        MessageBox.Show("成功！！");
                        break;
                    case 1:
                        // ログイン失敗
                        MessageBox.Show(ErrorMessageConst.ERR_MSG_LOGIN_FAILED);
                        break;
                }
                // ボタン押下時の処理
                ;
            }
            catch(Exception ex)
            {
                // システムエラー
                MessageBox.Show(ErrorMessageConst.ERR_MSG_SYSTEM_ERROR);
            }






            //TODO Call OnclickLoginButtonJM0001From
            //メッセージ出力
            //MessageBox.Show(xxxxx, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //AbstractButton logicButton = new OnClickLoginButtonJM0001Form();
            //logicButton.OnClickLogic();
            //if resultCode = 0{
            //JM0001クローズ
            //JM0002Formへ遷移する
            //}
            //ユーザ名パスワード名の不正
            //else if resultCode = 1{
            //メッセージ出力
            //MessageBox.Show("ユーザ名orパスワードが不正です。",
            //"エラー",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Error);
            //}
            //システムエラーおよびその他エラー
            //else {
            //}

        }
    }
}
