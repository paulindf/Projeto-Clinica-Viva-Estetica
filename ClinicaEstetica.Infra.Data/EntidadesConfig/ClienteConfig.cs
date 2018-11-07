using ClinicaEstetica.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ClinicaEstetica.Infra.Data.EntidadesConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);
            
            Property(p => p.Documento)
                .HasMaxLength(30)
                .IsRequired();

            Property(p => p.Email)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Senha)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.Endereco)
                .HasMaxLength(200)
                .IsRequired();

        }
    }
}
