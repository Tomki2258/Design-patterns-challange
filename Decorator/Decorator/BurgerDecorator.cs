using Decorator;

public abstract class BurgerDecorator : Burger
{
    private readonly Burger burger;

    protected BurgerDecorator(Burger burger)
    {
        this.burger = burger;
    }

    public virtual int getPrice()
    {
        return burger.getPrice();
    }

    public virtual string describe()
    {
        return burger.describe();
    }
}