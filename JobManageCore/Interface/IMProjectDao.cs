using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManageCore.Interface
{
    public interface IMProjectDao
    {
        /// <summary>
        /// マスタ全件取得
        /// </summary>
        /// <returns></returns>
        List<object> select();

        /// <summary>
        /// delete->insert処理
        /// </summary>
        /// <param name="projectNameList"></param>
        void insert(List<string> projectNameList);

        /// <summary>
        /// delete->insert処理で使用する全件削除
        /// </summary>
        void deleteAll();

        /// <summary>
        /// 選択行の削除
        /// </summary>
        void delete(long projectId);
    }
}
