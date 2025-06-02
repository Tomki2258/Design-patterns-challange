namespace Composite.Models;

public class Truck : ICar
{
    private string carType = "Truck";
    public void MoveCar()
    {
        Console.WriteLine($"Moved car with type: {carType}");
    }
}