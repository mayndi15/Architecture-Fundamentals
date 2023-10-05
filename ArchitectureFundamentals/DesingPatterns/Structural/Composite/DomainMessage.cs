namespace Architecture_Fundamentals.DesingPatterns.Structural.Composite;

public class DomainMessage : IMessage
{
    public string Name { get; set; }

    public DomainMessage(string name)
    {
        Name = name;
    }

    public void ShowMessage(int sub)
    {
        Console.WriteLine(new string('-', sub) + Name);
    }
}