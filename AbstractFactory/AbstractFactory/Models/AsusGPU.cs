using System.Diagnostics;

namespace AbstractFactory.Models;

public class AsusGPU : IGPU
{
    public void ShowOnScreen()
    {
        Console.WriteLine("Asus GPU");
    }
}