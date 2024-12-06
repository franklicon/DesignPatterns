namespace DesignPatterns.Behavioral.MediatorDP.BaseExample;

public class ColleagueB : Colleague
{
    public void OperationB()
    {
        Console.WriteLine("ColleagueB does OperationB");
        Mediator.Notify(this, "OperationB performed by ColleagueB");
    }
    
    public void Receive(string @event)
    {
        Console.WriteLine("ColleagueB received: " + @event);
    }
}