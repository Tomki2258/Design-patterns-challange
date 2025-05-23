namespace Facede;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        Client client2 = new Client();
        Console.WriteLine(client.getUUID());

        Reception reception = new Reception();
        
        reception.AddClient(client);
        
        reception.RemoveClient(client);
    }
}