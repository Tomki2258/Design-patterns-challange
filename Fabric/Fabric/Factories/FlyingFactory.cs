namespace Fabric.Factories;

public class FlyingFactory : IFactory
{
    public IEnemy CreateEnemy()
    {
        return new FlyingEnemy();
    }
}