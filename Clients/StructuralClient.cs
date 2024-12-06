using DesignPatterns.Structural.ProxyDP.BaseExample;
using DesignPatterns.Structural.ProxyDP.VirtualExample;

namespace DesignPatterns.Clients;

public static class StructuralClient
{
    public static void AddProxyClient()
    {
        // Base Proxy client
        Console.WriteLine("Base Proxy Client");
        var proxy = new Proxy();
        proxy.Operation();

        // Virtual Proxy client
        Console.WriteLine("Virtual Proxy Client");
        var image1 = new ProxyImage("image1");
        var image2 = new ProxyImage("image2");
        image1.Display();
        image2.Display();
        image1.Display();
        image2.Display();
    }
}