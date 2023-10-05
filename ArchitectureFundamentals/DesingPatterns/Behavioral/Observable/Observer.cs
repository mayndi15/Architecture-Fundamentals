namespace Architecture_Fundamentals.DesingPatterns.Behavioral.Observable;

public class Observer : IObserver
{
    public string Name { get; }

    public Observer(string name)
    {
        Name = name;
    }

    public void Notify(Investment investment)
    {
        Console.WriteLine("Notifying {0} that {1} " +
                          "price changed to {2:C}", Name, investment.Symbol, investment.Value);
    }
}