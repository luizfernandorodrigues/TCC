using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using System.Data.Entity;

namespace Repositorio.DALL.Contexto
{
    public class BDContexto : DbContext
    {
        public BDContexto()

            : base("SAERP") {}

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estado { get; set;}
        public DbSet<A24> Cidade { get; set; }
        public DbSet<A25> Cep { get; set; }
    }
}
