namespace Decorator;

public class DoubleBurger : BurgerDecorator
{
    public DoubleBurger(Burger burger) : base(burger)
    {
        
    }

    public override int getPrice()
    {
        return base.getPrice() + 10;
    }
    public override string describe()
    {
        return base.describe() + " with double meal";
    }
}