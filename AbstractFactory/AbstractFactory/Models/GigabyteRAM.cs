namespace AbstractFactory.Models;

public class GigabyteRAM : IRAM
{
    public void ShowInfo()
    {
        Console.WriteLine("Gigabyte RAM");
    }
}