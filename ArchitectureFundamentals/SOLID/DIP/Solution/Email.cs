namespace Architecture_Fundamentals.SOLID.DIP.Solution;

public class Email
{
    public string Address { get; set; }

    public bool Validate()
    {
        return Address.Contains("@");
    }
}