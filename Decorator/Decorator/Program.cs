namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        Burger basicBurger = new BasicBurger();
        Console.WriteLine($"{basicBurger.describe()} with price of {basicBurger.getPrice()}");
        
        Burger burger = new CheeseBurger(new BasicBurger());
        Console.WriteLine(burger.describe());
        
        Burger chickienBurger = new ChickienBurger(new BasicBurger());
        Console.WriteLine($"{chickienBurger.describe()} with price of {chickienBurger.getPrice()}");
        
        Burger doubleBurger = new DoubleBurger(new BasicBurger());
        Console.WriteLine($"{doubleBurger.describe()} with price of {doubleBurger.getPrice()}");
    }
}