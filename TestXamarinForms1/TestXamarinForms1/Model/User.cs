using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarinForms1.Model
{
    public class User
    {
        int ID { get; set; }
        string Name { get; set; }
        string Address { get; set; }
    }

    public class Owner : User
    {
        List<ParkingSpot> ParkingSpots { get; set; }

        public class ParkingSpot
        {
            int ID { get; set; }
            bool AvailableForRent { get; set; }
            int HoursAvailable { get; set; }
            int? RenterId { get; set; }
        }

    }

    public class Driver : User
    {
        int ID { get; set; }
        string LicenscePlate { get; set; }
    }
}
