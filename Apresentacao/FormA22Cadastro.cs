using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormA22Cadastro : Apresentacao.FormBase
    {
        public FormA22Cadastro()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu su um teste!@");
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("teste dois eu sou herdado e comando");
        }
    }
}