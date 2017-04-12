using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManage.Logic;
using MetroFramework.Forms;

namespace JobManage.Form
{
    public partial class JM0003Form : MetroForm
    {
        public JM0003Form()
        {
            InitializeComponent();
        }

        private void AggAnkenButton_Click(object sender, EventArgs e)
        {
            // ボタン押下時の処理クラスを生成
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.AggAnkenMonthButton);
            // ボタン押下時の処理を実行
            button.OnClickLogic(this);
        }

        private void AggTaskButton_Click(object sender, EventArgs e)
        {
            // ボタン押下時の処理クラスを生成
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.AggTaskMonthButton);
            // ボタン押下時の処理を実行
            button.OnClickLogic(this);
        }

        private void AggAnkenDayButton_Click(object sender, EventArgs e)
        {
            // ボタン押下時の処理クラスを生成
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.AggAnkenDayButton);
            // ボタン押下時の処理を実行
            button.OnClickLogic(this);
        }

        private void AggTaskDayButton_Click(object sender, EventArgs e)
        {
            // ボタン押下時の処理クラスを生成
            AbstractButton button = ButtonFactory.CreateButtonFactory(Const.JMConst.ButtonId.AggTaskDayButton);
            // ボタン押下時の処理を実行
            button.OnClickLogic(this);
        }
    }
}
