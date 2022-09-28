using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class RealEstate
    {
        public static IHome RentHome(string location)
        {
            switch (location)
            {
                case "forest":
                    var cottage = new Cottage();
                    return cottage;
                case "mountains":
                    var cabin = new MountainCabin();
                    return cabin;
                case "beach":
                    var beachHouse = new BeachHouse();
                    return beachHouse;
                case "city":
                    var flat = new Flat();
                    return flat;
                default:
                    Console.WriteLine("Your location was not in the correct format. Rental failed.");
                    var flat2 = new Flat();
                    return flat2;
            }
        }
    }
}
