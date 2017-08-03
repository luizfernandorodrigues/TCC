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
    public partial class FormA22Cadastro : Form
    {
        //variavel pra controlar se é editar ou incluir
        private int flag = 1;
        public FormA22Cadastro()
        {
            InitializeComponent();
        }
        //função para o botao novo habilitar o form para inclusão de registro
        private void Novo()
        {
            Util.HabilitaBotoesTabControl(this);
            Util.HabilitaCamposTabControl(this);
        }
        //função do botao gravar carrega o model e passa para o repositorio
        private void Adiconar()
        {
            using (var repPais = new PaisRepositorio())
            {
                A22 pais = new A22();
                pais.a22_001_c = txtNome.Text;
                pais.a22_002_c = txtCodigo.Text;

                //chamo a função statica que valida se o objeto esta corretamente preenchido
                //atraves do model que foi setado os parametros
                Validacao.ValidarEntidade(pais);

                //adiciono o objeto na memoria
                repPais.Adicionar(pais);

                //disparo comando para gravar fisicamente no banco de dados
                repPais.SalvarTodos();
            }

        }
        /// <summary>
        /// função do botao novo
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //salvar **insert
            if (flag == 1)
            {
                try
                {
                    Adiconar();
                    MessageBox.Show(Util.sucesso, Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Util.DesabilitaCamposTabControl(this);
                    btnSalvar.Enabled = false;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Util.erro + ex.Message, Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            // edição
            else if (flag == 2)
            {

            }
        }
        //botao sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //load do form
        private void FormA22Cadastro_Load(object sender, EventArgs e)
        {
            toolTipA22Cadastro.SetToolTip(btnanterior, Util.anterior);
            toolTipA22Cadastro.SetToolTip(btnProximo, Util.proximo);
            toolTipA22Cadastro.SetToolTip(btnPrimeiro, Util.primeiro);
            toolTipA22Cadastro.SetToolTip(btnUltimo, Util.ultimo);
            toolTipA22Cadastro.SetToolTip(btnRelatorio, Util.relatorio);
            toolTipA22Cadastro.SetToolTip(btnPesquisa, Util.pesquisa);
            toolTipA22Cadastro.SetToolTip(btnNovo, Util.novo);
            toolTipA22Cadastro.SetToolTip(btnEditar, Util.editar);
            toolTipA22Cadastro.SetToolTip(btnSalvar, Util.salvar);
            toolTipA22Cadastro.SetToolTip(btnExcluir, Util.excluir);
            toolTipA22Cadastro.SetToolTip(btnSair, Util.sair);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FormPesquisa frm = new FormPesquisa();
            frm.Show();
        }
    }
}
