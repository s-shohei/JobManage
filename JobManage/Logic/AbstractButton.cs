using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage;
using MetroFramework.Forms;

namespace JobManage.Logic
{
    public abstract class AbstractButton
    {
        /// <summary>
        /// ボタン押下時のメイン処理
        /// </summary>
        public abstract int OnClickLogic(MetroForm form);

        /// <summary>
        /// 各ボタンの状態を制御
        /// </summary>
        public abstract void ButtonStateChange();
    }
}
