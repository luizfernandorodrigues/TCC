using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using Repositorio.DALL.Repositorios.Base;
using System.Windows.Forms;


namespace Repositorio.DALL.Repositorios
{
    public class PaisRepositorio : Repositorio<Pais>
    {
        /// <summary>
        /// Função para pesquisar o objeto pais no banco de dados, recebe uma grid e o parametro a ser pesquisadso
        /// e o operador que determina o filtro no where
        /// </summary>
        /// <param name="dados"></param>
        /// <param name="nome"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public int pesquisa(DataGridView dados, string nome, int operador)
        {
            using (var repPais = new PaisRepositorio())
            {
                //se não passar nenhum parametro entra aqui e executo um getAll
                if (nome.Equals(""))
                {
                    dados.DataSource = repPais.GetAll().ToList();
                }
                //se for iniciado por
                else if (operador == 0)
                {
                    dados.DataSource = repPais.Get(c => c.descricaoPais.StartsWith(nome.ToUpper())).ToList();
                }
                //se for igual
                else if (operador == 1)
                {
                    dados.DataSource = repPais.Get(c => c.descricaoPais.Equals(nome.ToUpper())).ToList();
                }
                //se for contem
                else if (operador == 5)
                {
                    dados.DataSource = repPais.Get(c => c.descricaoPais.Contains(nome.ToUpper())).ToList();
                }
                //se for diferente
                else if (operador == 6)
                {
                    dados.DataSource = repPais.Get(c => c.descricaoPais != nome.ToUpper()).ToList();
                }
                //se for terminado por
                else if (operador == 7)
                {
                    dados.DataSource = repPais.Get(c => c.descricaoPais.EndsWith(nome.ToUpper())).ToList();
                }
                int cont = dados.RowCount;
                return cont;

            }

        }
        /// <summary>
        /// Função para carregar estados quando selecionar um pais.
        /// </summary>
        /// <param name="dados"></param>
        /// <param name="idPais"></param>
        public void carregaEstados(DataGridView dados, int idPais)
        {
            using(var repEstado = new EstadoRepositorio())
            {
                dados.DataSource = repEstado.Get(c => c.idPais.Equals(idPais)).ToList();
            }
        }
    }


}

