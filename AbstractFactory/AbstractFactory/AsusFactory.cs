using AbstractFactory.Models;

namespace AbstractFactory;

public class AsusFactory : IPartsFactory
{
    public IGPU CreateGPU()
    {
        return new AsusGPU();
    }

    public IRAM CreateRAM()
    {
        return new AsusRAM();
    }

    public IPSU CreatePSU()
    {
        return new AsusPSU();
    }
}