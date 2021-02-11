using System;
using System.Collections.Generic;
using System.Text;

namespace BookingEntities
{
    public class Book
    {
        public long Id { get; set; }
        public string Number { get; set; }

        public DateTime PlaceOn { get; set; }
        public long GarageId { get; set; }
        public Garage Garage { get; set; }

        public long ServiceId { get; set; }
        public string Services { get; set; }
        public double Amount { get; set; }
    }
}
