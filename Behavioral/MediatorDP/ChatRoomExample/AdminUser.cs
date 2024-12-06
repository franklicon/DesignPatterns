namespace DesignPatterns.Behavioral.MediatorDP.ChatRoomExample;

public class AdminUser(string name) : User(name)
{
    public override void Send(string message)
    {
        Console.WriteLine($"Admin {Name} announces: {message}");
        Mediator.Notify(this, $"ADMIN MESSAGE: {message}");
    }

    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"Admin {Name} receives from {senderName}: {message}");
    }

    internal void BroadcastAlert(string alert)
    {
        Console.WriteLine($"Admin {Name} broadcast: {alert}");
        Mediator.Notify(this, $"ADMIN ALERT: {alert}");
    }
}