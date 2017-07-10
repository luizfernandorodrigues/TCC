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
    public partial class FormBase : Form
    {
        private string novo = "Adicionar Registro!";
        private string editar = "Editar Registro da Tela!";
        private string salvar = "Salvar Registro da Tela!";
        private string excluir = "Excluir Registro da Tela";
        private string proximo = "Próximo Registro!";
        private string anterior = "Registro Anterior!";
        private string ultimo = "Pular para o ultimo Registro!";
        private string primeiro = "Ir para o Primeiro Registro!";
        private string pesquisa = "Pesquisar Registros do Banco de Dados!";
        private string relatorio = "Abrir tela de Relatórios!";
        private string sair = "Sair da Tela";

        public FormBase()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            toolTipFormBase.SetToolTip(btnNovo, novo);
            toolTipFormBase.SetToolTip(btnPesquisa, pesquisa);
            toolTipFormBase.SetToolTip(btnRelatorio, relatorio);
            toolTipFormBase.SetToolTip(btnExcluir, excluir);
            toolTipFormBase.SetToolTip(btnSair, sair);
            toolTipFormBase.SetToolTip(btnPrimeiro, primeiro);
            toolTipFormBase.SetToolTip(btnProximo, proximo);
            toolTipFormBase.SetToolTip(btnUltimo, ultimo);
            toolTipFormBase.SetToolTip(btnSalvar, salvar);
            toolTipFormBase.SetToolTip(btnEditar, editar);
            toolTipFormBase.SetToolTip(btnanterior, anterior);
        }

        
    }
}
