using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Apresentacao
{
   public static class Validacao
    {
        public static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }

        public static void ValidarEntidade(object obj)
        {
            var erros = Validacao.getValidationErros(obj);
            foreach(var error in erros)
            {
                MessageBox.Show((error.ErrorMessage));
            }
        }
    }

    
}
