namespace Architecture_Fundamentals.DesingPatterns.Structural.Composite;

public class InputFormMessage : IMessage
{
    public string Name { get; set; }

    public InputFormMessage(string name)
    {
        Name = name;
    }

    public void ShowMessage(int sub)
    {
        Console.WriteLine(new string('-', sub) + Name);
    }
}