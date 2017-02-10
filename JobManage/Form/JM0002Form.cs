﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using JobManage.Form;

namespace JobManage.Form
{
    public partial class JM0002Form : MetroForm
    {

        private JM0001Form _jm0001form;

        public JM0002Form(JM0001Form jm0001form)
        {
            InitializeComponent();
            this._jm0001form = jm0001form;
        }

        private void JM0002Form_Load(object sender, EventArgs e)
        {
            //JM0001Formクローズ
            _jm0001form.Close();

            //[トップ画面読み込み処理](OnLoadLogicJM0002)を呼び出す
        }
        private void JM0002Form_Closing(object sender, FormClosingEventArgs e)
        {
            //JM0001Formクローズ
            _jm0001form.Close();
            //フォームを最小化

            //イベントキャンセル

            //フォームの状態で分岐


        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}