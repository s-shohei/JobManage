using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;

namespace JobManageCore.Interface
{
    /// <summary>
    /// ユーザマスタへのDBアクセスインターフェースクラス
    /// </summary>
    public interface IMUserDao
    {
        /// <summary>
        /// ユーザ情報を取得する
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        List<M_USER> selectUserInfo(string userName, string password);
    }
}
