namespace Architecture_Fundamentals.DesingPatterns.Structural.Composite;

public interface IMessage
{
    string Name { get; set; }
    void ShowMessage(int sub);
}