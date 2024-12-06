namespace DesignPatterns.Behavioral.MediatorDP.BaseExample;

public interface Mediator
{
    void Notify(Colleague sender, string @event);
}