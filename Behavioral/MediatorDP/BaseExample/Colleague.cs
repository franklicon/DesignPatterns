namespace DesignPatterns.Behavioral.MediatorDP.BaseExample;

public abstract class Colleague
{
    protected Mediator Mediator = null!;

    public void SetMediator(Mediator mediator)
    {
        Mediator = mediator;
    }
}