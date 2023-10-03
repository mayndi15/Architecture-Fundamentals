namespace Architecture_Fundamentals.SOLID.ISP.Violation;

public class ProductRegistration : IRegistration
{
    public void Validate()
    {
        //Validate value
    }

    public void Save()
    {
        //Insert in table product
    }

    public void SendEmail()
    {
        throw new NotImplementedException("This method is not suitable for this context");
    }
}