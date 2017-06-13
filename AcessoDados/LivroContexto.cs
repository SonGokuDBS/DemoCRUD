using DemoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DemoCRUD.AcessoDados
{
    public class LivroContexto : DbContext
    {
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Esse comando para de plurarizar as tabelas, como ocorria no Azure
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(a => a.HasMaxLength(100));
        }
    }
}