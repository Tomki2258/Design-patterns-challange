namespace Builder;

public interface ISerwerBuilder
{
    void AddProcessors(int count);
    void AddRAM(int count);
    void AddGPUs(int count);
    void AddTBDiscSpace(int count);
}