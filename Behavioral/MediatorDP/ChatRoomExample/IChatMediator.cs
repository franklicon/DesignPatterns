namespace DesignPatterns.Behavioral.MediatorDP.ChatRoomExample;

public interface IChatMediator
{
    void Notify(User sender, string message);
}