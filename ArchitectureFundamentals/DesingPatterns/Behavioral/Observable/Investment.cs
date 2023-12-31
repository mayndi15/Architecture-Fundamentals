namespace Architecture_Fundamentals.DesingPatterns.Behavioral.Observable;

public abstract class Investment
{
    private decimal _value;
    private readonly List<IObserver> _observers = new();

    protected Investment(string symbol, decimal value)
    {
        Symbol = symbol;
        _value = value;
    }

    public string Symbol { get; }

    public decimal Value
    {
        get => _value;
        set
        {
            if (_value == value) return;

            _value = value;
            Notify();
        }
    }


    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
        Console.WriteLine($"Notifying that {observer.Name} is receiving updates from {Symbol}");
    }

    public void UnSubscribe(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine($"Notifying that {observer.Name} is NOT receiving updates from {Symbol}");
    }

    private void Notify()
    {
        foreach (var investor in _observers)
        {
            investor.Notify(this);
        }

        Console.WriteLine("");
    }
}