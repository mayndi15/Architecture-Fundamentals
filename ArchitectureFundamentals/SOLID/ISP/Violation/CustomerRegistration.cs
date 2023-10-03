namespace Architecture_Fundamentals.SOLID.ISP.Violation;

public class CustomerRegistration : IRegistration
{
    public void Validate()
    {
        //Validate CPF, Email
    }

    public void Save()
    {
       //Insert in table customer
    }

    public void SendEmail()
    {
        //Send email for customer
    }
}