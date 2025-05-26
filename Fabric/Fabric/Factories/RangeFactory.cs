namespace Fabric.Factories;

public class RangeFactory : IFactory
{
    public IEnemy CreateEnemy(IFactory factory)
    {
        return new RangeEnemy();
    }
}