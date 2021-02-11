using BookingEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageBooking.Service
{
    public class BookingService
    {
        public IEnumerable<Book> GetBooks(long? id = null)
        {
            var booking = new List<Book>();
            var Garages = GetGarages();
            if (id!=null)
            {
                Garages = Garages.Where(r => r.GarageId == id);
            }
            foreach (var item in Garages)
            {
                for (int i = 1; i <= 3; i++)
                {
                    booking.Add(new Book
                    {
                        Id = i,
                        Number = $"{item.Name}_BookingNumber_{i}",
                        Amount = (double)i * 4.96,
                        Services = $"Food_{i}",
                        ServiceId = i,
                        PlaceOn = DateTime.Now.AddMinutes(i * (-10)),
                        GarageId = item.GarageId,
                        Garage = item

                    });
                }
            }
            return booking;
        }
        private IEnumerable<Garage> GetGarages()
        {
            var garages = new List<Garage>();
            for (int i = 1; i <= 3; i++)
            {
                garages.Add(new Garage
                {
                    Id=i,
                    GarageId=i,
                    Name=$"Garage_{i}",
                    Address= $"Address_{i}"
                });
            }
            return garages;
        }
    }
}
