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
        public static List<Pais> list = new List<Pais>();
        public static BindingSource navegar = new BindingSource();
        BindingSource aux = new BindingSource();

        public FormA22Cadastro()
        {
            InitializeComponent();
        }
        //função para o botao novo habilitar o form para inclusão de registro
        private void Novo()
        {
            Util.HabilitaBotoesTabControl(this);
            Util.HabilitaCamposTabControl(this);
            Util.LimpaCampos(this);
        }
        //função do botao gravar carrega o model e passa para o repositorio
        private void Adiconar()
        {
            using (var repPais = new PaisRepositorio())
            {
                Pais pais = new Pais();
                pais.descricaoPais = txtNome.Text;
                pais.codigoPais = txtCodigo.Text;

                //chamo a função statica que valida se o objeto esta corretamente preenchido
                //atraves do model que foi setado os parametros
                Validacao.ValidarEntidade(pais);

                //adiciono o objeto na memoria
                repPais.Adicionar(pais);

                //disparo comando para gravar fisicamente no banco de dados
                repPais.SalvarTodos();
            }
            btnExcluiEstado.Enabled = false;
            btnNovoEstado.Enabled = false;

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
                try
                {
                    Alterar();
                    Util.DesabilitaCamposTabControl(this);
                    MessageBox.Show(Util.sucesso, Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSalvar.Enabled = false;
                    btnPesquisa.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Util.erro + ex.Message, Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
            toolTipA22Cadastro.SetToolTip(btnEditaEstado, Util.botaEditaGrade);
            toolTipA22Cadastro.SetToolTip(btnExcluiEstado, Util.botaoexcluirRegistroGrade);
            toolTipA22Cadastro.SetToolTip(btnNovoEstado, Util.botaoNovoGrade);
            toolTipA22Cadastro.SetToolTip(btnVisualizaEstado, Util.botaVisualizarRegistroGrade);


        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FormPesquisa frm = new FormPesquisa(this);
            frm.Show();
        }
        //botao anterior
        private void btnanterior_Click(object sender, EventArgs e)
        {
            Navegar(0, list);
        }

        private void Navegar(int flag, List<Pais> lst)
        {
            if (navegar.DataSource == null)
            {
                navegar.DataSource = lst;
            }
            //se for anterior
            if (flag == 0)
            {
                if (navegar.Position == 0)
                {
                    MessageBox.Show("Primeiro Registro!", Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        navegar.MovePrevious();
                        txtNome.DataBindings.Add("Text", navegar, "descricaoPais");
                        txtCodigo.DataBindings.Add("Text", navegar, "codigoPais");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            // se for proximo
            else if (flag == 1)
            {
                if (navegar.Position + 1 >= navegar.Count)
                {
                    MessageBox.Show("Ultimo Registro!", Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    try
                    {
                        navegar.MoveNext();
                        txtCodigo.DataBindings.Add("Text", navegar, "codigoPais");
                        txtNome.DataBindings.Add("Text", navegar, "descricaoPais");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //se for primeiro
            else if (flag == 2)
            {
                try
                {
                    navegar.MoveFirst();
                    txtCodigo.DataBindings.Add("Text", navegar, "codigoPais");
                    txtNome.DataBindings.Add("Text", navegar, "descricaoPais");
                    MessageBox.Show("Primeiro Registro!", Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //se for ultimo
            else
            {
                try
                {
                    navegar.MoveLast();
                    txtCodigo.DataBindings.Add("Text", navegar, "codigoPais");
                    txtNome.DataBindings.Add("Text", navegar, "descricaoPais");
                    MessageBox.Show("Ultimo Registro!", Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Navegar(1, list);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            Navegar(2, list);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            Navegar(3, list);
        }
        //botao editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        //função botao editar
        private void Editar()
        {
            Util.HabilitaCamposTabControl(this);
            flag = 2;
            btnExcluir.Enabled = false;
            btnanterior.Enabled = false;
            btnEditar.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisa.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnRelatorio.Enabled = false;
            btnUltimo.Enabled = false;
            btnProximo.Enabled = false;
            btnEditaEstado.Enabled = true;
            btnNovoEstado.Enabled = true;
        }
        //função para alterar dados
        private void Alterar()
        {
            using (var repPais = new PaisRepositorio())
            {
                Pais pais = new Pais();
                pais = navegar.Current as Pais;
                pais.descricaoPais = txtNome.Text;
                pais.codigoPais = txtCodigo.Text;

                //chamo a função statica que valida se o objeto esta corretamente preenchido
                //atraves do model que foi setado os parametros
                Validacao.ValidarEntidade(pais);

                //adiciono o objeto na memoria
                repPais.Atualizar(pais);

                //disparo comando para gravar fisicamente no banco de dados
                repPais.SalvarTodos();
            }
        }
        //função para excluir
        private void Excluir()
        {
            using (var repPais = new PaisRepositorio())
            {
                Pais pais = new Pais();
                pais = navegar.Current as Pais;
                int id = pais.id;
                repPais.Excluir(c => c.id.Equals(id));
                repPais.SalvarTodos();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
                Util.LimpaCampos(this);
                navegar.MoveNext();
                MessageBox.Show(Util.exclusaoSucesso, Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(Util.exclusaoErro + ex.Message, Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
