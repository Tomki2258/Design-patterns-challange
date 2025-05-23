namespace Facede;

public class Parking
{
    List<Client> clients = new List<Client>();

    public void AddClient(Client client)
    {
        this.clients.Add(client);
        Console.WriteLine($"Parking - Registered Client: {client.getUUID()}");
    }

    public void RemoveClient(Client client)
    {
        this.clients.Add(client);
        Console.WriteLine($"Parking - Removed Client: {client.getUUID()}");
    }
}