using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades
{
    [Table("A23")]
    public class A23
    {
        [Key]
        [Column("UKEY")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ukey { get; set; }
        
        [Display(Name ="Nome")]
        [Column("A23_001_C", TypeName = "nvarchar")]
        [Required(ErrorMessage = "Campo Nome é Obrigatório!")]
        [StringLength(100, MinimumLength = 1)]
        public string a23_001_c { get; set; }

        [Display(Name ="Sigla")]
        [Column("A23_002_C", TypeName = "nvarchar")]
        [Required(ErrorMessage = "Campo Sigla é Obrigatório!")]
        [StringLength(2, MinimumLength = 2)]
        public string a23_002_c { get; set; }

        [Column("TIMESTAMP", TypeName = "DateTime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime timestamp { get; set; }

        public int A22_UKEY { get; set; }
        [ForeignKey("A22_UKEY")]
        public virtual A22 pais { get; set; }

        public virtual ICollection<A24> cidade { get; set; }


    }
}
