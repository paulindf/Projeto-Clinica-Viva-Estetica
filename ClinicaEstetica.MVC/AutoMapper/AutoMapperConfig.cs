using AutoMapper;
using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.MVC.ViewModels;

namespace ClinicaEstetica.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void InitializeAutoMapper()
        {
            Mapper.Initialize(x =>
                x.AddProfile<Mapeamento>()
            );
        }
    }

    public class Mapeamento : Profile
    {
        public Mapeamento()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<TipoServico, ServicoViewModel>();
            CreateMap<TipoDocumento, TipoDocumentoViewModel>();
            CreateMap<Agenda, AgendaViewModel>();

            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ServicoViewModel, TipoServico>();
            CreateMap<TipoDocumentoViewModel, TipoDocumento>();
            CreateMap<AgendaViewModel, Agenda>();
        }
    }
}