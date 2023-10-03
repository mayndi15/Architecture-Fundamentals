namespace Architecture_Fundamentals.SOLID.DIP.Violation;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Email Email { get; set; }
    public Cpf Cpf { get; set; }
    public DateTime CreatedDate { get; set; }

    public bool Validate()
    {
        return Email.Validate() && Cpf.Validate();
    }
}