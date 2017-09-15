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
        FormA22Cadastro paisForm;
        public FormPesquisa(FormA22Cadastro frm)
        {
            InitializeComponent();
            paisForm = frm;
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            dataGridViewDados.AutoGenerateColumns = false;
            combo.combo(comboBoxNomePesquisa);
            toolTipA22Pesquisa.SetToolTip(btnCarregaSelecionados, Util.carregarSelecionados);
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
        //carrego os registros selecionados do grid
        private void button1_Click(object sender, EventArgs e)
        {
            Pais p = new Pais();
            List<Pais> pais = new List<Pais>();
            foreach (DataGridViewRow linha in dataGridViewDados.Rows)
            {
                foreach (DataGridViewCell cel in dataGridViewDados.Rows[linha.Index].Cells)
                {
                    if (cel.ColumnIndex == 0)
                    {
                        if (cel.Value != null)
                        {
                            //aqui implemento o carregamento do datareader que sera percorrido
                            p = linha.DataBoundItem as Pais;
                            //atribuo o p para a lista de pais
                            pais.Add(p);
                        }
                    }
                }

            }
            paisForm.txtNome.Text = pais[0].descricaoPais;
            paisForm.txtCodigo.Text = pais[0].codigoPais;
            paisForm.btnEditar.Enabled = true;
            paisForm.btnanterior.Enabled = true;
            paisForm.btnProximo.Enabled = true;
            paisForm.btnPrimeiro.Enabled = true;
            paisForm.btnUltimo.Enabled = true;
            paisForm.btnExcluir.Enabled = true;
            FormA22Cadastro.list = pais;
            FormA22Cadastro.navegar.DataSource = FormA22Cadastro.list;
            Close();
        }
    }
}
