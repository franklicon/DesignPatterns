namespace DesignPatterns.Structural.ProxyDP.VirtualExample;

public class ProxyImage : IImage
{
    private RealImage? _realImage = null;
    private readonly string _fileName;
    
    public ProxyImage(string fileName)
    {
        Console.WriteLine("Instantiating ProxyImage");
        _fileName = fileName;
    }
    
    public void Display()
    {
        Console.WriteLine("Displaying in Proxy Image");

        if (_realImage == null)
        {
            Console.WriteLine("Showing low resolution placeholder");
            Console.WriteLine("""
                                ____  
                                      o8%8888,    
                                    o88%8888888.  
                                   8'-    -:8888b   
                                  8'         8888  
                                 d8.-=. ,==-.:888b  
                                 >8 `~` :`~' d8888   
                                 88         ,88888   
                                 88b. `-~  ':88888  
                                 888b ~==~ .:88888 
                                 88888o--:':::8888      
                                 `88888| :::' 8888b  
                                 8888^^'       8888b  
                                d888           ,%888b.   
                               d88%            %%%8--'-.  
                              /88:.__ ,       _%-' ---  -  
                                  '''::===..-'   =  --.
                              """);
            _realImage = new RealImage(_fileName);
            return;
        }
        
        _realImage.Display();
    }
}