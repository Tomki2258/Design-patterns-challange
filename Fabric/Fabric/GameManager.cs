using Fabric.Factories;

namespace Fabric;

public class GameManager
{
    public IEnemy CreateEnemy(IFactory factory)
    {
        return factory.CreateEnemy(factory);
    }
}