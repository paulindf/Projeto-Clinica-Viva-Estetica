using ClinicaEstetica.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ClinicaEstetica.Infra.Data.EntidadesConfig
{
    public class TipoServicoConfig : EntityTypeConfiguration<TipoServico>
    {
        public TipoServicoConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(80);
        }
    }
}
