namespace Architecture_Fundamentals.SOLID.ISP.Solution.Interfaces;

public interface ICustomerRegistration : IRegistration
{
    void Validate();
    void SendEmail();
}