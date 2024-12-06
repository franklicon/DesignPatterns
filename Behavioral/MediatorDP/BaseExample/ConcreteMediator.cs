namespace DesignPatterns.Behavioral.MediatorDP.BaseExample;

public class ConcreteMediator : Mediator
{
    private readonly ColleagueA _colleagueA;
    private readonly ColleagueB _colleagueB;

    public ConcreteMediator(ColleagueA colleagueA, ColleagueB colleagueB)
    {
        _colleagueA = colleagueA;
        _colleagueA.SetMediator(this);
        
        _colleagueB = colleagueB;
        _colleagueB.SetMediator(this);
    }   

    public void Notify(Colleague sender, string @event)
    {
        Console.WriteLine($"Concrete Mediator notified by {sender.GetType().Name}");

        if (sender == _colleagueA)
        {
            // call some method on ColleagueB
            this._colleagueB.Receive(@event);
        }
        else if (sender == _colleagueB)
        {
            // call some method on ColleagueA
            this._colleagueA.Receive(@event);
        }
    }
}