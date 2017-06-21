using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormMestre : Form
    {
        public FormMestre()
        {
            InitializeComponent();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormA22Cadastro frm = new FormA22Cadastro();
            frm.Show();
        }
    }
}
