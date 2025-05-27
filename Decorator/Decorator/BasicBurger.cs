namespace Decorator;

public class BasicBurger: Burger
{
    public int getPrice()
    {
        return 20;
    }

    public string describe()
    {
        return "Burger";
    }
}