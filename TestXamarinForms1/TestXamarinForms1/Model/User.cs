using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarinForms1.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Owner : User
    {
        List<ParkingSpot> ParkingSpots { get; set; }

        public class ParkingSpot
        {
            public int ID { get; set; }
            public bool AvailableForRent { get; set; }
            public int HoursAvailable { get; set; }
            public int? RenterId { get; set; }
        }

    }

    public class Driver : User
    {
        public string LicenscePlate { get; set; }
    }
}
