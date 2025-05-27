namespace Fabric.Factories;

public class RangeFactory : IFactory
{
    public IEnemy CreateEnemy()
    {
        return new RangeEnemy();
    }
}