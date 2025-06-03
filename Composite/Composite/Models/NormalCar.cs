namespace Composite.Models;

public class NormalCar : ICar
{
    private string carType = "Normal";

    public void MoveCar()
    {
        Console.WriteLine($"Moved car with type: {carType}");
    }
}