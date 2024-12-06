namespace DesignPatterns.Structural.ProxyDP.BaseExample;

public class RealSubject : Subject
{
    public RealSubject()
    {
        Console.WriteLine("Instantiating Real Subject");
    }
    
    public void Operation()
    {
        Console.WriteLine("Performing operation in Real Subject");
    }
}