namespace Decorator;

public class ChickienBurger : BurgerDecorator
{
    public ChickienBurger(Burger burger) : base(burger)
    {
    }

    public override int getPrice()
    {
        return base.getPrice() + 5;
    }
    public override string describe()
    {
        return base.describe() + " with chickien";
    }
}