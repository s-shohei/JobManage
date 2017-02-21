using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using JobManage.Form;

namespace JobManage.Logic
{
    public class OnClickEndButtonJM0002Form : AbstractButton
    {

        private JM0002Form _form;

        public override void ButtonStateChange()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 終了ボタン押下時のメイン処理
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public override int OnClickLogic(MetroForm form)
        {
            int result = 0;

            _form = (JM0002Form)form;

            this.init();

            return result;
        }

        private void init()
        {

        }
    }
}
