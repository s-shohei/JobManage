using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManageCore.DatabaseModel;
using MetroFramework.Forms;
using JobManage.Logic;
using JobManage.Const;
using JobManage.Form;

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
                        // JM0001Formを非表示,JM0002Formを表示
                        JM0002Form JM0002Form = new JM0002Form(this);
                        JM0002Form.Show();
                        this.Hide();
                        break;

                    case 1:
                        // ログイン失敗
                        MessageBox.Show(ErrorMessageConst.ERR_MSG_LOGIN_FAILED);
                        break;
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
                // システムエラー
                MessageBox.Show(ErrorMessageConst.ERR_MSG_SYSTEM_ERROR);
            }
        }
    }
}
