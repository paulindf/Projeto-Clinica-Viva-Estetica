using ClinicaEstetica.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ClinicaEstetica.Infra.Data.EntidadesConfig
{
    public class TipoDocumentoConfig : EntityTypeConfiguration<TipoDocumento>
    {
        public TipoDocumentoConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(80);
        }
    }
}
