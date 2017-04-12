using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManage.Const
{
    public class JMConst
    {
        public enum ButtonId
        {
            LoginButton = 1,
            StartButton = 2,
            EndButton = 3,
            RegistButton = 4,
            AggAnkenMonthButton = 5,
            AggAnkenDayButton = 6,
            AggTaskMonthButton = 7,
            AggTaskDayButton = 8
        }

        public enum FormId
        {
            JM0001Form = 1,
            JM0002Form = 2
        }

        public static TimeSpan INTERVAL_TIME = TimeSpan.FromMinutes(15);
    }
}
