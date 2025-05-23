namespace Singleton;

public class Hero
{
    private static Hero hero = null;

    public Hero()
    {
    }

    public static Hero getHero()
    {
        if (hero == null) 
            hero =  new Hero();
        return hero;
    }
}