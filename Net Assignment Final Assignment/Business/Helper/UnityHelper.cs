using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;

namespace Business.Helper
{
    public class UnityHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ICusttomerRegisterRepo, CustomerRegisterRepo>();
            Container.RegisterType<IMechanicRepo, MechanicRepo>();
            Container.RegisterType<IVehicleRepo, VehicleRepo>();
            Container.RegisterType<IDealerRepo, DealerRepo>();
            Container.RegisterType<IBookingRepo, BookingRepo>();
        }
    }
}
