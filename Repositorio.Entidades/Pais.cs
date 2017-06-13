using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades
{
    [Table("A22")]
    public class Pais
    {
        [Key]
        [Column("UKEY")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int paisId { get; set; }

        [Column("A22_001_C")]
        [Required(ErrorMessage ="Campo Nome é Obrigatorio!")]
        [StringLength(50, MinimumLength =2)]
        public string nome { get; set; }

        [Column("A22_002_C")]
        [Required(ErrorMessage ="Campo Código é Obrigatorio!")]
        [StringLength(10, MinimumLength =2)]
        public string codigo { get; set; }

        public DateTime TIMESTAMP { get; set; }

    }
}
