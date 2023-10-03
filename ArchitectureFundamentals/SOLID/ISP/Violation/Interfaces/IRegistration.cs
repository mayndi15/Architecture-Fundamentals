namespace Architecture_Fundamentals.SOLID.ISP.Violation;

public interface IRegistration
{
    void Validate();
    void Save();
    void SendEmail();
}