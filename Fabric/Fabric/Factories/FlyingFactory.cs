namespace Fabric.Factories;

public class FlyingFactory : IFactory
{
    public IEnemy CreateEnemy(IFactory factory)
    {
        return new FlyingEnemy();
    }
}