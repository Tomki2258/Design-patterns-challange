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
        var asusGPU = asusFactory.CreateGPU();
        var asusRAM = asusFactory.CreateRAM();
        var asusPSU = asusFactory.CreatePSU(); 
        
        //Gigabyte parts
        var gigabyteGPU = gigabyteFactory.CreateGPU();
        var gigabyteRAM = gigabyteFactory.CreateRAM();
        var gigabytePSU = gigabyteFactory.CreatePSU();

        
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
    
}