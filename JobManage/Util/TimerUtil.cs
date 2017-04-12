using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManage.Const;

namespace JobManage.Util
{
    public class TimerUtil
    {
        /// <summary>
        /// 時刻切り下げ
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static DateTime RoundDown(DateTime input, TimeSpan interval)
        {
            return new DateTime((((input.Ticks + interval.Ticks) / interval.Ticks) - 1) * interval.Ticks, input.Kind);
        }

        /// <summary>
        /// 時刻切り上げ
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static DateTime RoundUp(DateTime input, TimeSpan interval)
        {
            return new DateTime(((input.Ticks + interval.Ticks - 1) / interval.Ticks) * interval.Ticks, input.Kind);
        }

        public static string UntilMonth()
        {
            string sysDate = DateTime.Today.ToString();

            return sysDate.Substring(0,8);
        }

        public static string UntilDay()
        {
            string sysDate = DateTime.Today.ToString();

            return sysDate.Substring(0, 10);
        }
    }
}
