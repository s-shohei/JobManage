using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobManage.DatabaseModel;

namespace JobManage
{
    public partial class JM0001Form : Form
    {
        public JM0001Form()
        {
            InitializeComponent();
        }

        private void JM0001Form_Load(object sender, EventArgs e)
        {
            using (var db = new JobManageEntities())
            {

                var userList = db.M_USER;

                foreach(var user in userList)
                {
                    string test = user.USER_ID.ToString() + "  ";
                    test = test + user.USER_NAME + "\r\n";
                    textBox1.AppendText(test);
                }


            }
        }
    }
}
