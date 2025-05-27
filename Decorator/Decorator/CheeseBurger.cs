using Decorator;

public class CheeseBurger : BurgerDecorator
{
    public CheeseBurger(Burger burger) : base(burger)
    {
    }

    public override string describe()
    {
        return base.describe() + " with cheese";
    }
}