namespace Composite.Models;

public class SportsCar : ICar
{
    private string carType = "Sports car";
    public void MoveCar()
    {
        Console.WriteLine($"Moved car with type: {carType}");
    }
}