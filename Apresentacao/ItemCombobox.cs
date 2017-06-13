using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public class ItemCombobox
    {
        public string descricao { get; set; }
        public string valor { get; set; }

        /// <summary>
        /// Metodo de Criação dos Filtros das Combobox das Telas de Pesquisa, Recebe uma 
        /// Combobox como parametros e Retorna a mesma com seu dataSource Carregado e 
        /// Com o ValueMember, o mesmo segue uma ordem igual o Index
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public ComboBox combo(ComboBox cb)
        {

            List<ItemCombobox> lst = new List<ItemCombobox>();
            lst.Add(new ItemCombobox { descricao = "Iniciado Por", valor = "LIKE" });
            lst.Add(new ItemCombobox { descricao = "Igual", valor = "=" });
            lst.Add(new ItemCombobox { descricao = "Entre", valor = "BETWEEN" });
            lst.Add(new ItemCombobox { descricao = "Maior Igual", valor = ">" });
            lst.Add(new ItemCombobox { descricao = "Menor Igual", valor = "<" });
            lst.Add(new ItemCombobox { descricao = "Contem", valor = "LIKE" });
            lst.Add(new ItemCombobox { descricao = "Diferente de", valor = "<>" });
            lst.Add(new ItemCombobox { descricao = "Terminado Por", valor = "LIKE" });

            cb.DataSource = lst;
            cb.DisplayMember = "descricao";
            cb.ValueMember = "valor";

            return cb;

        }
        /// <summary>
        /// função das combobox de estatus dos form de cadastro se esta ativo ou inativo, ja preenche tambem o parametro value
        /// seno 1 para ativo 0 inativo 
        /// </summary>
        /// <param name="combo"></param>
        /// <returns></returns>
        public ComboBox comboStatus(ComboBox combo)
        {
            List<ItemCombobox> lst = new List<ItemCombobox>();
            lst.Add(new ItemCombobox { descricao = "Ativo", valor = "1" });
            lst.Add(new ItemCombobox { descricao = "Inativo", valor = "0" });

            combo.DataSource = lst;
            combo.DisplayMember = "descricao";
            combo.ValueMember = "valor";

            return combo;
        }
        /// <summary>
        /// função de preenchimento da combobox de regime do parceiro, recebe a combobox e preenche a mesma com a descrição e o parametro value
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public ComboBox Regime(ComboBox cb)
        {

            List<ItemCombobox> lst = new List<ItemCombobox>();
            lst.Add(new ItemCombobox { descricao = "Simples Nacional", valor = "0" });
            lst.Add(new ItemCombobox { descricao = "Simples Nacional - Excesso de Sublimite de Receita Bruta", valor = "1" });
            lst.Add(new ItemCombobox { descricao = "Regime Normal - Lucro Real", valor = "2" });
            lst.Add(new ItemCombobox { descricao = "Regime Credito Presumido", valor = "3" });
            lst.Add(new ItemCombobox { descricao = "Pessoa Fisica", valor = "4" });
            lst.Add(new ItemCombobox { descricao = "Orgão Publico", valor = "5" });
            lst.Add(new ItemCombobox { descricao = "Orgão Publico Federal", valor = "6" });
            lst.Add(new ItemCombobox { descricao = "Orgão Publico Estadual", valor = "7" });
            lst.Add(new ItemCombobox { descricao = "Orgão Publico Municipal", valor = "8" });

            cb.DataSource = lst;
            cb.DisplayMember = "descricao";
            cb.ValueMember = "valor";

            return cb;

        }
        /// <summary>
        /// função de preenchimento da combobox finalidade de nfe usada no form de cadastro de tipo de entrada e saida
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public ComboBox FinalidadeNfe(ComboBox cb)
        {
            List<ItemCombobox> lst = new List<ItemCombobox>();
            lst.Add(new ItemCombobox { descricao = "NF-e Normal", valor = "0" });
            lst.Add(new ItemCombobox { descricao = "NF-e Complementar", valor = "1" });
            lst.Add(new ItemCombobox { descricao = "NF-e de Ajuste", valor = "2" });
            lst.Add(new ItemCombobox { descricao = "Devolução de Mercadoria", valor = "3" });

            cb.DataSource = lst;
            cb.DisplayMember = "descricao";
            cb.ValueMember = "valor";

            return cb;
        }
        public ComboBox TipoContato(ComboBox cb)
        {
            List<ItemCombobox> lst = new List<ItemCombobox>();
            lst.Add(new ItemCombobox { descricao = "Telefone", valor = "0" });
            lst.Add(new ItemCombobox { descricao = "Email", valor = "1" });
            lst.Add(new ItemCombobox { descricao = "Celular", valor = "2" });
            lst.Add(new ItemCombobox { descricao = "Pessoal", valor = "3" });
            lst.Add(new ItemCombobox { descricao = "Site", valor = "4" });
            lst.Add(new ItemCombobox { descricao = "Chat", valor = "5" });
            lst.Add(new ItemCombobox { descricao = "Formulario", valor = "6" });
            lst.Add(new ItemCombobox { descricao = "Outros", valor = "7" });

            cb.DataSource = lst;
            cb.DisplayMember = "descricao";
            cb.ValueMember = "valor";

            return cb;
        }
        /// <summary>
        /// função para preencher combo de escolaridade do form de cadastro de parceiro
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public ComboBox Escolaridade(ComboBox cb)
        {
            List<ItemCombobox> lst = new List<ItemCombobox>();
            lst.Add(new ItemCombobox { descricao = "Analfabeto", valor = "0" });
            lst.Add(new ItemCombobox { descricao = "Até 5º Ano Incompleto", valor = "1" });
            lst.Add(new ItemCombobox { descricao = "6º ao 9º Ano Incompleto", valor = "2" });
            lst.Add(new ItemCombobox { descricao = "Ensino Fundamental Completo", valor = "3" });
            lst.Add(new ItemCombobox { descricao = "Ensino Medio Incompleto", valor = "4" });
            lst.Add(new ItemCombobox { descricao = "Ensino Medio Completo", valor = "5" });
            lst.Add(new ItemCombobox { descricao = "Ensino Superior Incompleto", valor = "6" });
            lst.Add(new ItemCombobox { descricao = "Ensino Supererior Completo", valor = "7" });
            lst.Add(new ItemCombobox { descricao = "Especialização", valor = "8" });
            lst.Add(new ItemCombobox { descricao = "Mestrado Completo", valor = "9" });
            lst.Add(new ItemCombobox { descricao = "Doutorado Completo", valor = "10" });

            cb.DataSource = lst;
            cb.DisplayMember = "descricao";
            cb.ValueMember = "valor";

            return cb;
        }
        /// <summary>
        /// função para preencher combobox tipo de pessoa do form de cadastro de parceiro
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public ComboBox TipoPessoa(ComboBox cb)
        {
            List<ItemCombobox> lst = new List<ItemCombobox>();
            lst.Add(new ItemCombobox { descricao = "Juridica", valor = "0" });
            lst.Add(new ItemCombobox { descricao = "Fisica", valor = "1" });

            cb.DataSource = lst;
            cb.DisplayMember = "descricao";
            cb.ValueMember = "valor";

            return cb;
        }

        public ComboBox TipoEmissao(ComboBox cb)
        {
            List<ItemCombobox> lst = new List<ItemCombobox>();
            lst.Add(new ItemCombobox { descricao = "Produção", valor = "1" });
            lst.Add(new ItemCombobox { descricao = "Homologação", valor = "0" });

            cb.DataSource = lst;
            cb.DisplayMember = "descricao";
            cb.ValueMember = "valor";

            return cb;
        }
    }
}
