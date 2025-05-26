namespace Fabric.Factories;

public class NormalFactory : IFactory
{
    public IEnemy CreateEnemy(IFactory factory)
    {
        return new NormalEnemy();
    }
}