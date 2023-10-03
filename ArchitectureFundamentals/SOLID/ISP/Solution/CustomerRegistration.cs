using Architecture_Fundamentals.SOLID.ISP.Solution.Interfaces;

namespace Architecture_Fundamentals.SOLID.ISP.Solution;

public class CustomerRegistration : ICustomerRegistration
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