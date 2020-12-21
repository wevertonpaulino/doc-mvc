using DocMvc.Domain.Entities;
using MySql.Data.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DocMvc.Infrastructure.Data.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DocumentoContext : DbContext
    {
        public DocumentoContext() : base("name=DocMvcConnection") { }

        public DbSet<Documento> Documentos { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            base.OnModelCreating(modelBuilder);
        }
    }
}
