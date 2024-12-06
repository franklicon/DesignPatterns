namespace DesignPatterns.Behavioral.MediatorDP.ChatRoomExample;

public abstract class User(string name)
{
    public string Name { get; protected set; } = name;
    protected IChatMediator Mediator = null!;

    public void SetMediator(IChatMediator mediator)
    {
        Mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message, string senderName);
}