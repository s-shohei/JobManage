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
        AbstractMasterMente masterMente;

        public JobManageMasterMente()
        {
            InitializeComponent();
        }

        private void JobManageMasterMente_Load(object sender, EventArgs e)
        {

        }

        private void MasterGetButton_Click(object sender, EventArgs e)
        {
            string masterName = "";
            if (MasterComboBox.SelectedIndex !=-1)
            {
                masterName = MasterComboBox.SelectedItem.ToString();
            }
            else
            {
                return;
            }

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

        private void MasterInsButton_Click(object sender, EventArgs e)
        {
            masterMente.Insert();
            masterMente.Display();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
