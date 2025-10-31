namespace RideHailingApp;

public class Passenger
{
    // Property — only one piece of information: the passenger's name
    public string Name { get; set; }

    // Constructor — initializes a new Passenger object
    public Passenger(string name)
    {
        Name = name;
    }
    
}