[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ClinicaEstetica.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ClinicaEstetica.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ClinicaEstetica.MVC.App_Start
{
    using System;
    using System.Web;
    using ClinicaEstetica.Application;
    using ClinicaEstetica.Application.Interface;
    using ClinicaEstetica.Domain.Interfaces.Repositorios;
    using ClinicaEstetica.Domain.Interfaces.Servicos;
    using ClinicaEstetica.Domain.Servicos;
    using ClinicaEstetica.Infra.Data.Repositorio;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            kernel.Bind<IAgendaAppService>().To<AgendaAppService>();
            kernel.Bind<ITipoServicoAppService>().To<TipoServicoAppService>();
            kernel.Bind<ITipoDocumentoAppService>().To<TipoDocumentoAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<IAgendaService>().To<AgendaService>();
            kernel.Bind<ITipoServicoService>().To<TipoServicoService>();
            kernel.Bind<ITipoDocumentoService>().To<TipoDocumentoService>();

            kernel.Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));
            kernel.Bind<IClienteRepositorio>().To<ClienteRepositorio>();
            kernel.Bind<IAgendaRepositorio>().To<AgendaRepositorio>();
            kernel.Bind<ITipoServicoRepositorio>().To<TipoServicoRepositorio>();
            kernel.Bind<ITipoDocumentoRepositorio>().To<TipoDocumentoRepositorio>();
        }        
    }
}
