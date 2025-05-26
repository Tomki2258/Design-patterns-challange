using Fabric.Factories;

namespace Fabric;

internal class Program
{
    private static void Main(string[] args)
    {
        var flyingFactory = new FlyingFactory();
        var normalFactory = new NormalFactory();
        var rangeFactory = new RangeFactory();

        var gameManager = new GameManager();
        var normal = gameManager.CreateEnemy(
            normalFactory
        );

        var range = gameManager.CreateEnemy(
            rangeFactory
        );

        var flying = gameManager.CreateEnemy(
            flyingFactory
        );
        
        normal.describe();
        range.describe();
        flying.describe();
    }
}