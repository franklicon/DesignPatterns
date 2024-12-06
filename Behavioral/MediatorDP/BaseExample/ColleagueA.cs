namespace DesignPatterns.Behavioral.MediatorDP.BaseExample;

public class ColleagueA : Colleague
{
    public void OperationA()
    {
        Console.WriteLine("ColleagueA does OperationA");
        Mediator.Notify(this, "OperationA performed by ColleagueA");
    }

    public void Receive(string @event)
    {
        Console.WriteLine("ColleagueA received: " + @event);
    }
}