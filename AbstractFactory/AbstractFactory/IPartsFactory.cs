using AbstractFactory.Models;

namespace AbstractFactory;

public interface IPartsFactory
{
    IGPU CreateGPU();
    IRAM CreateRAM();
    IPSU CreatePSU();
}