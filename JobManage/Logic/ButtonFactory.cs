using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage.Const;
namespace JobManage.Logic
{

    public class ButtonFactory
    {
        public AbstractButton CreateButtonFactory(JMConst.ButtonId id)
        {
            AbstractButton result = null;

            switch(id)
            {
                case JMConst.ButtonId.LoginButton:
                    result = new OnClickLoginButtonJM0001Form();
                    break;
                case JMConst.ButtonId.RegistButton:
                    result = new OnClickRegistButtonJM0002Form();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
