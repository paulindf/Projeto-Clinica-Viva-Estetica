using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Infra.Data.EntidadesConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEstetica.Infra.Data.Contexto
{
    public class ProjetoContexto : DbContext
    {
        public ProjetoContexto()
            : base("ConexaoClinicaEstetica")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<TipoServico> Servicos { get; set; }
        public DbSet<TipoDocumento> TiposDocumentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Conventions.Remove<PluralizingTableNameConvention>();
            mb.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            mb.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            mb.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            mb.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            mb.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            mb.Configurations.Add(new ClienteConfig());
            mb.Configurations.Add(new AgendaConfig());
            mb.Configurations.Add(new TipoServicoConfig());
            mb.Configurations.Add(new TipoDocumentoConfig());

            base.OnModelCreating(mb);

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(p => p.Entity.GetType().GetProperty("DataRegistro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataRegistro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataRegistro").IsModified = false;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(p => p.Entity.GetType().GetProperty("Ativado") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Ativado").CurrentValue = true;
                }
            }

            return base.SaveChanges();
        }
    }
}
