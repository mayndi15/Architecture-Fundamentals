namespace Architecture_Fundamentals.SOLID.DIP.Solution.Interfaces;

public interface IEmailService
{
    void Send(string sender, string recipient, string subject, string message);
}