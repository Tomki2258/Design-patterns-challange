namespace Builder;

public class Serwer
{
    private int cpus;
    private int ram;
    private int disc;
    private int gpu;

    public void SetCpus(int cpus)
    {
        this.cpus = cpus;
    }

    public void SetRam(int ram)
    {
        this.ram = ram;
    }
    public void SetDisc(int disc)
    {
        this.disc = disc;
    }

    public void SetGpu(int gpu)
    {
        this.gpu = gpu;
    }

    public void Describe()
    {
        Console.WriteLine($"CPU:{cpus} RAM:{ram} GPU:{gpu} DISC:{disc}");
    }
}