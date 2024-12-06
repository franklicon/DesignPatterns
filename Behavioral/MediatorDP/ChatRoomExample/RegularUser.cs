namespace DesignPatterns.Behavioral.MediatorDP.ChatRoomExample;

public class RegularUser(string name) : User(name)
{
    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        Mediator.Notify(this, message);
    }

    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"{Name} receives from {senderName}: {message}");
    }
}