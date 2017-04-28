using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.Model;

namespace JobManageCore.Interface
{
    /// <summary>
    /// 複数テーブルを操作するDao
    /// </summary>
    public interface IDatabaseDao
    {
        /// <summary>
        /// コンボボックスに設定する内容(プロジェクト・領域・案件)を返す
        /// </summary>
        /// <returns></returns>
        List<JM0002ComboBoxListModel> selectComboBoxData();
    }
}
