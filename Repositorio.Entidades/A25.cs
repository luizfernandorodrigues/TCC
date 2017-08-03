using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades
{
  public class A25
    {
        [Key]
        [Column("UKEY")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ukey { get; set; }

        [Display(Name = "Cep")]
        [Column("A25_001_C", TypeName = "nvarchar")]
        [Required(ErrorMessage = "Campo cep é Obrigatorio!")]
        [MaxLength(8), MinLength(8)]
        public string a25_001_c { get; set; }

        [Display(Name = "Logradouro")]
        [Column("A25_002_C", TypeName = "nvarchar")]
        [Required(ErrorMessage = "Campo logradouro é Obrigatorio!")]
        [MaxLength(60), MinLength(2)]
        public string a25_002_c { get; set; }

        [Display(Name = "Bairro")]
        [Column("A25_003_C", TypeName = "nvarchar")]
        [Required(ErrorMessage = "Campo bairro é Obrigatorio!")]
        [MaxLength(60), MinLength(2)]
        public string a25_003_c { get; set; }

        [Column("TIMESTAMP", TypeName = "DateTime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timestamp { get; set; }

        public int A24_UKEY { get; set; }
        [ForeignKey("A24_UKEY")]
        public virtual A24 cidade { get; set; }
    }
}
