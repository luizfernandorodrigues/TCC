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
using Repositorio.DALL.Contexto;

namespace Apresentacao
{
    public partial class FormA22Cadastro : Form
    {
        public FormA22Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var repPais = new PaisRepositorio())
            {
                BDContexto db = new BDContexto();

                try {
                    Pais pais = new Pais();
                    pais.codigo = textBox2.Text;
                    pais.nome = textBox1.Text;
                    pais.TIMESTAMP = System.DateTime.Now;
                    ValidarPais(pais);
                   
                    repPais.Adicionar(pais);
                    repPais.SalvarTodos();

                    MessageBox.Show("Registro gravado com sucesso!");
                } catch(Exception ex)
                {
                    MessageBox.Show("erro" + ex.Message);
                }
                }

        }

        private void ValidarPais(object obj)
        {
            var erros = Validacao.getValidationErros(obj);

            foreach(var error in erros)
            {
                MessageBox.Show((error.ErrorMessage));
            }
        }
    }
}
