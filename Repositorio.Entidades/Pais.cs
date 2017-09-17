using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades
{
    [Table("tblPais")]
    public class Pais
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display (Name ="Nome")]
        [Column("descricaoPais")]
        [Required(ErrorMessage ="Campo Nome é Obrigatorio!")]
        [StringLength(50, MinimumLength =2)]
        public string descricaoPais { get; set; }

        [Display(Name ="Código")]
        [Column("codigoPais")]
        [Required(ErrorMessage ="Campo Código é Obrigatorio!")]
        [MaxLength(4), MinLength(2)]
        public string codigoPais { get; set; }


        [Column("TIMESTAMP")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime TIMESTAMP { get; set; }

        public virtual ICollection<Estado> estado { get; set; }

       

    }
}
