namespace Composite.Models;

public class CarComposite : ICar    
{
    private List<ICar> cars = new List<ICar>();

    public void AddCar(ICar car)
    {
        cars.Add(car);
    }

    public void MoveCar()
    {
        foreach (var car in cars)
        {
            car.MoveCar();
        }
    }
}