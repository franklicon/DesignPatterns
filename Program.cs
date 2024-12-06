using DesignPatterns.Clients;

Console.WriteLine("----Behavioral client: Iterator DP----");
BehavioralClient.AddIteratorClient();

Console.WriteLine("----Behavioral client: Mediator DP----");
BehavioralClient.AddMediatorClient();

Console.WriteLine("----Structural client: Proxy DP----");
StructuralClient.AddProxyClient();

Console.WriteLine("----Creational client: Factory Method DP----");
CreationalClient.AddFactoryMethodClient();