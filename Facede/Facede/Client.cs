namespace Facede;

public class Client
{
    private String UUID;

    public Client()
    {
        this.UUID = Guid.NewGuid().ToString();
    }

    public String getUUID()
    {
        return this.UUID;
    }
}