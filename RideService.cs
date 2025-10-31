namespace RideHailingApp;

public class RideService
{
    
    private List<Driver> drivers;
    private List<Passenger> passengers;

    public RideService()
    {
        drivers = new List<Driver>();
        passengers = new List<Passenger>();
    }

    public void RegisterDriver(Driver driver)
    {
        drivers.Add(driver);
        Console.WriteLine($"Driver {driver.Name} registered successfully!");
    }

    public void RegisterPassenger(Passenger passenger)
    {
        passengers.Add(passenger);
        Console.WriteLine($"Passenger {passenger.Name} registered successfully!");
    }

    public void ShowAllDrivers()
    {
        Console.WriteLine("\nList of Registered Drivers:");
        foreach (var driver in drivers)
        {
            Console.WriteLine($"Name: {driver.Name}, Plate: {driver.MotoPlateNumber}, Available: {driver.IsAvailable}");
        }
    }

    public void ShowAllPassengers()
    {
        Console.WriteLine("\nList of Registered Passengers:");
        foreach (var passenge in passengers)
        {
            Console.WriteLine($"Name: {passenge.Name}");
        }
    }
}