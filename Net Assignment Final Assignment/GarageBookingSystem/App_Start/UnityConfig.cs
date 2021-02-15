using Business;
using Business.Helper;
using Business.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace GarageBookingSystem
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICreateCustomer, CreateCustomer>();
            container.RegisterType<IMechanicmanager,Mechanicmanager>();
            container.RegisterType<IDealerManager, DealerManager>();
            container.AddNewExtension<UnityHelper>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}