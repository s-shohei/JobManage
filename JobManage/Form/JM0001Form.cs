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
            //TODO Call OnClickLoginBtnLogic たぶんログイン判定処理
            
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
                //メッセージ出力
                MessageBox.Show("システムエラーです。管理者に問い合わせてください。",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
//            }
        }
    }
}
