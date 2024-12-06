namespace DesignPatterns.Behavioral.MediatorDP.ChatRoomExample;

public class ChatRoom() : IChatMediator
{
    private readonly List<User> _users = [];
    public void AddUser(User user)
    {
        _users.Add(user);
        user.SetMediator(this);
    }
    
    public void Notify(User sender, string message)
    {
        foreach (var user in _users.Where(user => user != sender))
        {
            user.Receive(message, sender.Name);
        }
    }
}