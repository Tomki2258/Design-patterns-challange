namespace Facede;

public class Hotel
{
    List<Client> clients = new List<Client>();

    public void AddClient(Client client)
    {
        this.clients.Add(client);
        Console.WriteLine($"Hotel - Registered Client: {client.getUUID()}");
    }

    public void RemoveClient(Client client)
    {
        this.clients.Remove(client);
        Console.WriteLine($"Hotel - Removed Client {client.getUUID()}");
    }
}