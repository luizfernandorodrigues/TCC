using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio.DALL.Repositorios;
using Repositorio.Entidades;

namespace Apresentacao
{
    public partial class FormPesquisa : Form
    {
        PreencheComboBox combo = new PreencheComboBox();
        public FormPesquisa()
        {
            InitializeComponent();
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            dataGridViewDados.AutoGenerateColumns = false;
            combo.combo(comboBoxNomePesquisa);
        }
        // funçao para preencher o grid
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            PaisRepositorio rep = new PaisRepositorio();
            int registros = 0;
            
            registros = rep.pesquisa(dataGridViewDados, txtNomePesquisa.Text, comboBoxNomePesquisa.SelectedIndex);

            // verifico a quantidade de registros retornado caso seja zero exibe uma mensagem
            if (registros == 0)
            {
                MessageBox.Show("Nenhum Registro Encontrado!", Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
           
        }
    }
}
