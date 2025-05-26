namespace Fabric;

public class NormalEnemy : IEnemy
{
    private int damage = 15;
    private int health = 2000;
    private string name = "Soldier";


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
        Console.WriteLine("Normal enemy");
    }
}