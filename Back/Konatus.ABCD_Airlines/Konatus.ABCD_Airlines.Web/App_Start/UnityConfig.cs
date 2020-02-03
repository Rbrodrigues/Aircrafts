using Konatus.ABCD_Airlines.Core.Interfaces.Repository;
using Konatus.ABCD_Airlines.Core.Interfaces.Services;
using Konatus.ABCD_Airlines.Core.Services;
using Konatus.ABCD_Airlines.Infra.Repository;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Konatus.ABCD_Airlines.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IAeronaveRepository, AeronaveRepository>();
            container.RegisterType<IAeronaveService, AeronaveService>();

            container.RegisterType<IModeloAeronaveRepository, ModeloAeronaveRepository>();
            container.RegisterType<IModeloAeronaveService, ModeloAeronaveService>();

            container.RegisterType<IRelatorioRepository, RelatorioRepository>();
            container.RegisterType<IRelatorioService, RelatorioService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}