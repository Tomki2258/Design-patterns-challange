using AbstractFactory.Models;

namespace AbstractFactory;

public class GigabyteFactory : IPartsFactory
{
    public IGPU CreateGPU()
    {
        return new GigabyteGPU();
    }

    public IRAM CreateRAM()
    {
        return new GigabyteRAM();
    }

    public IPSU CreatePSU()
    {
        return new GigabytePSU();
    }
}