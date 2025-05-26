namespace Fabric.Factories;

public class NormalFactory : IFactory
{
    public IEnemy CreateEnemy()
    {
        return new  NormalEnemy();
    }
}