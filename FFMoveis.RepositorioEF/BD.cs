using FFMoveis.Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FFMoveis.RepositorioEF
{
    public class BD : DbContext
    {
        public BD() : base("conexaoBD") { }

        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Subcategoria> subcategorias { get; set;}
        public DbSet<Produto> produtos { get; set; }
    }

    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


    //}
}