using System.Diagnostics;

namespace AbstractFactory.Models;

public class GigabytePSU : IPSU
{
    public void ShowInfo()
    {
        Debug.WriteLine("Gigabyte PSU");
    }
}