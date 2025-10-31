
using System;

namespace RideHailingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // crete ride service objectcreation
            RideService rideService = new RideService();
            bool running = true;
            while (running)
            {
                 Console.WriteLine("\n==display menu options==");
                 Console.WriteLine("\n  RIDE HAILING SYSTEM  :");
                 Console.WriteLine("1. Register a Driver");
                 Console.WriteLine("2. Register a Passenger");
                 Console.WriteLine("3. Show All Drivers");
                 Console.WriteLine("4. Show All Passengers");
                 Console.WriteLine("5. Exit");
                 Console.Write("Choose an option: ");
                 string choice = Console.ReadLine();
                 switch (choice)
                 {
                     case "1":
                         Console.Write("\n Collective driver information respect menu options\n");
                         Console.WriteLine("Enter the driver name: ");
                         string driverName = Console.ReadLine();
                         Console.WriteLine(" Enter Moto Plate Number:  ");
                         string motoPlates = Console.ReadLine();
                         Console.Write("Is the driver available? (true/false): ");
                         bool ISavailable = bool.Parse(Console.ReadLine());
                         
                         Driver driver = new Driver(driverName, motoPlates, ISavailable); 
                         // Register it
                         rideService.RegisterDriver(driver);
                         break;
                         
                     case "2":
                         // Collect passenger name
                         Console.Write("Enter Passenger Name: ");
                         string pName = Console.ReadLine();

                         // Create a Passenger object
                         Passenger passenger = new Passenger(pName);

                         // Register it
                         rideService.RegisterPassenger(passenger);
                         break;
                     
                     case "3":
                         rideService.ShowAllDrivers();
                         break;
                     case "4":
                         rideService.ShowAllPassengers();
                         break;
                     case "5":
                         running = false;
                         
                         Console.WriteLine($" thanks  you are Exiting program...");
                         break;
                     default:
                         Console.WriteLine("Invalid option ..");
                         break;
                     
                     
                     
                     
                         
                         
                         
                         
                         
                         
                 
                     
                 }
                
                
                
            }
            
        }
    }
}

