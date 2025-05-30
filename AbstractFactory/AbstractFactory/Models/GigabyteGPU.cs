namespace AbstractFactory.Models;

public class GigabyteGPU : IGPU
{
    public void ShowOnScreen()
    {
        Console.WriteLine("Gigabyte GPU");
    }
}