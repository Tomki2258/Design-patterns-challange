namespace Fabric;

public class FlyingEnemy : IEnemy
{
    private int damage = 45;
    private readonly int health = 15000;
    private string name = "Helicopter";
    
    public void attack()
    {
        throw new NotImplementedException();
    }

    public void die()
    {
        throw new NotImplementedException();
    }

    public void describe()
    {
        Console.WriteLine("Flying enemy");
    }

    public bool isAlive()
    {
        return health > 0;
    }
}