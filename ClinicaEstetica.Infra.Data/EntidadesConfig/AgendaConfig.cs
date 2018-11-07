using ClinicaEstetica.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ClinicaEstetica.Infra.Data.EntidadesConfig
{
    public class AgendaConfig : EntityTypeConfiguration<Agenda>
    {
        public AgendaConfig()
        {
            HasKey(h => h.Id);

            Property(p => p.Duracao)
                .IsRequired();

            Property(p => p.Horario)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);

        }
    }
}
