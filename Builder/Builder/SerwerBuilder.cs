namespace Builder;

public class SerwerBuilder : ISerwerBuilder
{
    private Serwer serwer = new  Serwer();
    
    public void AddProcessors(int count)
    {
        serwer.SetCpus(count);
    }

    public void AddRAM(int count)
    {
        serwer.SetRam(count);
    }

    public void AddGPUs(int count)
    {
        serwer.SetGpu(count);
    }

    public void AddTBDiscSpace(int count)
    {
        serwer.SetDisc(count);
    }

    public Serwer Build()
    {
        return serwer;
    }
}