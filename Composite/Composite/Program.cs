using Composite.Models;

namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        CarComposite carComposite = new CarComposite();
        var truck = new Truck();
        var car = new NormalCar();
        var sportsCar = new SportsCar();
        
        sportsCar.MoveCar();
        Console.WriteLine();
        
        carComposite.AddCar(truck);
        carComposite.AddCar(car);
        carComposite.AddCar(sportsCar);
        
        carComposite.MoveCar();
    }
}