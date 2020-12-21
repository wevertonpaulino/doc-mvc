using DocMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DocMvc.Infrastructure.Data.Configuration
{
    public class DocumentoConfiguration : EntityTypeConfiguration<Documento>
    {
        public DocumentoConfiguration()
        {
            HasKey(p => p.Codigo);

            Property(p => p.Titulo)
                .IsRequired();

            Property(p => p.Revisao)
                .IsRequired()
                .HasMaxLength(1);

            Property(p => p.DataPlanejada)
                .IsRequired();

            Property(p => p.Valor)
                .IsRequired()
                .HasPrecision(18, 2);
        }
    }
}
