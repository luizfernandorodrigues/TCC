using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Repositorio.Entidades
{
   public class A24
    {
        [Key]
        [Column("UKEY")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ukey { get; set; }

        [Column("A24_001_C", TypeName ="nvarchar")]
        [Required(ErrorMessage ="Campo Nome da Cidade é Obrigatorio!")]
        [MaxLength(60), MinLength(2)]
        public string a24_001_c { get; set; }

        [Column("A24_002_N", TypeName ="int")]
        [Required(ErrorMessage ="Campo Código do IBGE é Obrigatório!")]
        [MinLength(7)]
        public int a24_002_n { get; set; }

        [Column("TIMESTAMP", TypeName = "DateTime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timestamp { get; set; }

        public int A23_UKEY { get; set; }
        [ForeignKey("A23_UKEY")]
        public virtual A23 estado { get; set; }
    }
}
