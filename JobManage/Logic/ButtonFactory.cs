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
        public static AbstractButton CreateButtonFactory(JMConst.ButtonId id)
        {
            AbstractButton result = null;

            switch(id)
            {
                case JMConst.ButtonId.LoginButton:
                    result = new OnClickLoginButtonJM0001Form();
                    break;
                case JMConst.ButtonId.StartButton:
                    result = new OnClickStartButtonJM0002Form();
                    break;
                case JMConst.ButtonId.EndButton:
                    result = new OnClickEndButtonJM0002Form();
                    break;
                case JMConst.ButtonId.RegistButton:
                    result = new OnClickRegistButtonJM0002Form();
                    break;
                case JMConst.ButtonId.AggAnkenMonthButton:
                    result = new OnClickAggAnkenMonthButtonJM0003Form();
                    break;
                case JMConst.ButtonId.AggAnkenDayButton:
                    result = new OnClickAggAnkenDayButtonJM0003Form();
                    break;
                case JMConst.ButtonId.AggTaskMonthButton:
                    result = new OnClickAggTaskMonthButtonJM0003Form();
                    break;
                case JMConst.ButtonId.AggTaskDayButton:
                    result = new OnClickAggTaskDayButtonJM0003Form();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
