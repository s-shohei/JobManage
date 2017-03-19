using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace JobManageMasterMente
{
    public partial class JobManageMasterMente : MetroForm
    {
        public JobManageMasterMente()
        {
            InitializeComponent();
        }

        private void JobManageMasterMente_Load(object sender, EventArgs e)
        {

        }

        private void MasterGetButton_Click(object sender, EventArgs e)
        {
            AbstractMasterMente masterMente;
            string masterName = MasterComboBox.SelectedItem.ToString();

            switch(masterName)
            {
                case "プロジェクト":
                    masterMente = new ProjectMasterMente(this);
                    masterMente.Display();
                    break;
                case "領域":
                    masterMente = new RegionMasterMente(this);
                    masterMente.Display();
                    break;
                case "案件":
                    masterMente = new AnkenMasterMente(this);
                    masterMente.Display();
                    break;
                case "タスク":
                    masterMente = new TaskMasterMente(this);
                    masterMente.Display();
                    break;
            }
        }
    }
}
