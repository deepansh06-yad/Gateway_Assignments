using BAL;
using BAL.Helpers;
using BAL.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace CruiseLinePassenger
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICruiseManager, CruiseManager>();
            container.AddNewExtension<UnityHelper>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}