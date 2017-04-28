using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobManageCore.DatabaseModel;
using MetroFramework.Forms;

namespace JobManageMasterMente
{
    public abstract class AbstractMasterMente
    {
        protected JobManageMasterMente _masterMenteForm;

        protected List<Object> _masterDataList;

        public abstract void Select();

        public abstract void Insert();

        public abstract void Delete();

        public void Display()
        {
            // Grid初期化
            _masterMenteForm.MasterDataGrid.Rows.Clear();

            Select();

            if(this is ProjectMasterMente)
            {
                this.ProjectMasterDisplay();
            }
            else if(this is RegionMasterMente)
            {
                this.RegionMaserDisplay();
            }
            else if (this is AnkenMasterMente)
            {
                this.AnkenMaserDisplay();
            }
            else if (this is TaskMasterMente)
            {
                this.TaskMaserDisplay();
            }
        }
        
        private void GridViewDisplay(string id, string name)
        {
            // Gridに行挿入
            int row = _masterMenteForm.MasterDataGrid.Rows.Add(
                        id,
                        name
                       );
            // 行選択
            _masterMenteForm.MasterDataGrid.Rows[row].Selected = true;
            _masterMenteForm.MasterDataGrid.CurrentCell = _masterMenteForm.MasterDataGrid.Rows[row].Cells[0];
        }

        private void ProjectMasterDisplay()
        {
            foreach (var project in _masterDataList)
            {
                // キャスト
                M_PROJECT m = (M_PROJECT)project;
                // 値取得
                string id = m.PROJECT_ID.ToString();
                string name = m.PROJECT_NAME;

                this.GridViewDisplay(id,name);
            }
        }

        private void RegionMaserDisplay()
        {
            foreach (var region in _masterDataList)
            {
                // キャスト
                M_REGION m = (M_REGION)region;
                // 値取得
                string id = m.REGION_ID.ToString();
                string name = m.REGION_NAME;

                this.GridViewDisplay(id, name);
            }
        }
        private void AnkenMaserDisplay()
        {
            foreach (var anken in _masterDataList)
            {
                // キャスト
                M_ANKEN m = (M_ANKEN)anken;
                // 値取得
                string id = m.ANKEN_ID.ToString();
                string name = m.ANKEN_NAME;

                this.GridViewDisplay(id, name);
            }
        }
        private void TaskMaserDisplay()
        {
            foreach (var task in _masterDataList)
            {
                // キャスト
                M_TASK m = (M_TASK)task;
                // 値取得
                string id = m.TASK_ID.ToString();
                string name = m.TASK_NAME;

                this.GridViewDisplay(id, name);
            }
        }
    }
}
