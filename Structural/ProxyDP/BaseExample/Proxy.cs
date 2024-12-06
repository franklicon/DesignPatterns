namespace DesignPatterns.Structural.ProxyDP.BaseExample;

public class Proxy : Subject
{
    private RealSubject? _realSubject = null;
    public Proxy()
    {
        Console.WriteLine("Instantiating Proxy");
    }
    
    public void Operation()
    {
        Console.WriteLine("Performing operation in Proxy");

        _realSubject ??= new RealSubject();
        
        _realSubject.Operation();
    }
}