using FactoryPattern;
using System.Data.Common;
string[] locations = new string[] { "forest", "mountains", "beach", "city" };
bool validLocation;

Console.Write("\nTell us where you'd like to live. Your options are: ");
for (int i = 0; i < locations.Length - 1; i++)
    Console.Write($"{locations[i]}, ");
Console.WriteLine($"or {locations[locations.Length - 1]}.");

do
{
    string location = Console.ReadLine().ToLower();

    validLocation = locations.Contains(location);

    if (validLocation)
    {
        IHome yourRental = RealEstate.RentHome(location);
        Console.WriteLine();
        yourRental.Dwell();
    }
    else
    {
        Console.WriteLine("Your input was invalid. Please try again.");
    }
} while (!validLocation);