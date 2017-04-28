using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManageCore.DatabaseModel;
using JobManageCore.Interface;
using JobManageCore.Dao;

namespace JobManageMasterMente
{
    public class ProjectMasterMente : AbstractMasterMente
    {
        IMProjectDao dao = new MProjectDao();

        public ProjectMasterMente(JobManageMasterMente form)
        {
            _masterMenteForm = form;
        }

        /// <summary>
        /// 選択行の削除
        /// </summary>
        public override void Delete()
        {
            // 現在の選択数を取得
            if (_masterMenteForm.MasterDataGrid.CurrentRow == null)
            {
                return;
            }

            // プロジェクトIDを取得
            long projectId = long.Parse(_masterMenteForm.MasterDataGrid.CurrentRow.Cells[0].Value.ToString());

            dao.delete(projectId);
        }

        /// <summary>
        /// delete->insert処理
        /// </summary>
        public override void Insert()
        {
            List<string> projectNameList = new List<string>();

            for(int j = 0; j<_masterMenteForm.MasterDataGrid.Rows.Count -1;j++)
            {
                string projectName = _masterMenteForm.MasterDataGrid.Rows[j].Cells[1].Value.ToString();
                projectNameList.Add(projectName);
            }
            dao.insert(projectNameList);
        }

        /// <summary>
        /// マスタ全件取得
        /// </summary>
        public override void Select()
        {
            _masterDataList = dao.select();
        }
    }
}
