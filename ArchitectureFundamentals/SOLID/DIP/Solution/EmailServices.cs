using System.Net.Mail;
using Architecture_Fundamentals.SOLID.DIP.Solution.Interfaces;

namespace Architecture_Fundamentals.SOLID.DIP.Solution;

public class EmailServices : IEmailService
{
    public void Send(string sender, string recipient, string subject, string message)
    {
        var email = new MailMessage(sender, recipient);
        var client = new SmtpClient()
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        email.Subject = subject;
        email.Body = message;
        client.Send(email);
    }
}