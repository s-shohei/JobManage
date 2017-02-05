using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManage.Logic
{
    public abstract class IButton
    {
        /// <summary>
        /// ボタン押下時のメイン処理
        /// </summary>
        public abstract void OnClickLogic();

        /// <summary>
        /// 各ボタンの状態を制御
        /// </summary>
        public abstract void ButtonStateChange();
    }
}
