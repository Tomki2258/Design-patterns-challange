namespace Facede;

public class Restaurant
{
    List<Client> clients = new List<Client>();

    public void AddClient(Client client)
    {
        this.clients.Add(client);
        Console.WriteLine($"Restaurant - Registered Client: {client.getUUID()}");
    }

    public void RemoveClient(Client client)
    {
        this.clients.Remove(client);
        Console.WriteLine($"Restaurant - Removed Client: {client.getUUID()}");
    }
}