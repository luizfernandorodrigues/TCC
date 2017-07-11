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

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormA22Cadastro pais = new FormA22Cadastro();
            pais.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja Realmente Sair do Sistema ?", Util.titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensagem == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }
    }
}
