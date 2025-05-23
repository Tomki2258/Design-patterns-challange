namespace Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        var hero = Hero.getHero();
        var hero2 = Hero.getHero();

        if (hero == hero2) Console.WriteLine("To jest ten sam obiekt");
    }
}