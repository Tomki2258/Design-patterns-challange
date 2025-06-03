using AbstractFactory.Models;

namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        List<dynamic> dynamicList = new List<dynamic>();

        
        //Factories
        var asusFactory = new AsusFactory();
        var gigabyteFactory = new GigabyteFactory();
        
        //Asus parts
        var asusGPU = CreateGPU(asusFactory);
        var asusRAM = CreateRAM(asusFactory);
        var asusPSU = CreatePSU(asusFactory); 
        
        //Gigabyte parts
        var gigabyteGPU = CreateGPU(gigabyteFactory);
        var gigabyteRAM = CreateRAM(gigabyteFactory);
        var gigabytePSU = CreatePSU(gigabyteFactory);

        
        dynamicList.Add(gigabyteGPU);
        dynamicList.Add(gigabyteRAM);
        dynamicList.Add(gigabytePSU);
        
        dynamicList.Add(asusGPU);
        dynamicList.Add(asusRAM);
        dynamicList.Add(asusPSU);
        foreach (var x in dynamicList)
        {
            if(x is IPSU psu) psu.ShowInfo();
            if(x is IGPU gpu) gpu.ShowOnScreen();
            if(x is IRAM ram) ram.ShowInfo();
        }
    }
    private static IGPU CreateGPU(IPartsFactory factory)
    {
        return factory.CreateGPU();
    }

    private static IRAM CreateRAM(IPartsFactory factory)
    {
        return factory.CreateRAM();
    }

    private static IPSU CreatePSU(IPartsFactory factory)
    {
        return factory.CreatePSU();
    }
}