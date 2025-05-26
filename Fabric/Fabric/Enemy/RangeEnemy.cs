namespace Fabric;

public class RangeEnemy : IEnemy
{
    private int damage = 30;
    private int health = 7000;
    private string name = "Tank";

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
        Console.WriteLine("Range enemy");
    }
}