using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManageCore.Interface
{
    public interface IMTaskDao
    {
        /// <summary>
        /// /// 作業内容を全件返す
        /// </summary>
        /// <returns></returns>
        List<string> selectTaskList();
    }
}
