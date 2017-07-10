using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Repositorio.DALL.Repositorios;
using Repositorio.Entidades;

namespace Apresentacao
{
    public partial class FormA22Cadastro : Apresentacao.FormBase
    {
        private int flag = 1;
        public FormA22Cadastro()
        {
            InitializeComponent();
        }
        //função para preencher o model e gravar no banco de dados
        private void Adiconar()
        {
            using (var repPais = new PaisRepositorio())
            {
                A22 pais = new A22();
                pais.a22_001_c = txtNome.Text;
                pais.a22_002_c = txtCodigo.Text;
                repPais.SalvarTodos();
            }

        }
        //função do botão salvar
        private void btnNovo_Click(object sender, EventArgs e)
        {
            //salvar **insert
            if (flag == 1)
            {
                try
                {
                    Adiconar();
                    MessageBox.Show(Util.sucesso, Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Util.DesabilitaCamposTabControl(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Util.erro + ex.Message, Util.titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}