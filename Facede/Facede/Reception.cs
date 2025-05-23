namespace Facede;

public class Reception
{
    private List<Client> clients = new List<Client>();
    private Parking parking = new Parking();
    private Restaurant restaurant = new Restaurant();
    private Hotel hotel = new Hotel();
    
    public void AddClient(Client client)
    {
        if(clients.Contains(client)) return;
        
        this.clients.Add(client);
        this.parking.AddClient(client);
        this.restaurant.AddClient(client);
        this.hotel.AddClient(client);
        Console.WriteLine($"Registered Client: {client.getUUID()}");
    }

    public void RemoveClient(Client client)
    {
        if(!clients.Contains(client)) return;
        
        this.clients.Remove(client);
        this.parking.RemoveClient(client);
        this.hotel.RemoveClient(client);
        this.restaurant.RemoveClient(client);
        Console.WriteLine($"Removed Client: {client.getUUID()}");
    }
}