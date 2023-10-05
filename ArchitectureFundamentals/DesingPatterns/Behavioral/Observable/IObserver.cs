namespace Architecture_Fundamentals.DesingPatterns.Behavioral.Observable
{
    // Observer
    public interface IObserver
    {
        string Name { get; }
        void Notify(Investment investment);
    }
}