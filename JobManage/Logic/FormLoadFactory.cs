using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage.Const;
namespace JobManage.Logic
{
    public class FormLoadFactory
    {
        public AbstractFormLoad CreateFormLoad(JMConst.FormId id)
        {
            AbstractFormLoad result = null;

            switch(id)
            {
                case JMConst.FormId.JM0002Form:
                    result = new OnFormLoadJM0002();
                        break;
                default:
                    break;
            }
            return result;
        }
    }
}
