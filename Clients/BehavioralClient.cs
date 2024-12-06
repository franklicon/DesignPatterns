using DesignPatterns.Behavioral.IteratorDP.GenericExample;
using DesignPatterns.Behavioral.IteratorDP.PrimesExample;
using DesignPatterns.Behavioral.MediatorDP.BaseExample;
using DesignPatterns.Behavioral.MediatorDP.ChatRoomExample;

namespace DesignPatterns.Clients;

public static class BehavioralClient
{
    public static void AddIteratorClient()
    {
        // Generic Iterator client
        Console.WriteLine("Generic Iterator Client");
        IAggregate<int> aggregate = new Aggregate<int>();
        aggregate.Add(1);
        aggregate.Add(2);
        aggregate.Add(3);
        var iterator = aggregate.CreateIterator();
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }

        // Primes Iterator client
        Console.WriteLine("Primes Iterator Client");
        var primes = new PrimeCollection(150);
        var primeIterator = primes.CreateIterator();
        while (primeIterator.HasNext())
        {
            Console.WriteLine(primeIterator.Next());
        }
    }
    
    public static void AddMediatorClient()
    {
        // Base Mediator client.
        Console.WriteLine("Base Mediator Client");
        ColleagueA colleagueA = new();
        ColleagueB colleagueB = new();
        ConcreteMediator concreteMediator = new(colleagueA, colleagueB);
        colleagueA.OperationA();
        colleagueB.OperationB();
        
        // Chat Room Mediator client
        Console.WriteLine("Chat Room Mediator Client");
        RegularUser alice  = new("Alice");
        RegularUser bob = new("Bob");
        AdminUser charlie = new("Charlie");

        ChatRoom chatRoom = new();
        chatRoom.AddUser(alice);
        chatRoom.AddUser(bob);
        chatRoom.AddUser(charlie);

        charlie.Send("Welcome, I'm Charlie!");
        alice.Send("Hello, everyone!!");
        bob.Send("Hi, Alice");
        charlie.BroadcastAlert("Keep it friendly, guys!");
    }
}