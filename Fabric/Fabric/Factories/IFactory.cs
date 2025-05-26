namespace Fabric.Factories;

public interface IFactory
{
    IEnemy CreateEnemy(IFactory factory);
}