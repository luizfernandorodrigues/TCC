using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades
{
   public class Estado
    {
        public int estadoId { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
    }
}
