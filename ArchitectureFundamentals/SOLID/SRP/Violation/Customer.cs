using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Architecture_Fundamentals.SOLID.SRP.Violation;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public DateTime CreatedDate { get; set; }

    public string Add()
    {
        if (!Email.Contains("@"))
            return "Customer with invalid email";

        if (Cpf.Length != 11)
            return "Customer with invalid CPF";

        using (var connection = new SqlConnection())
        {
            var command = new SqlCommand();

            connection.ConnectionString = "DbConnectionString";
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText =
                "INSERT INTO Customer (name, email, cpf, createdDate) VALUES (@name, @email, @cpf, @createdDate)";

            command.Parameters.AddWithValue("name", Name);
            command.Parameters.AddWithValue("email", Email);
            command.Parameters.AddWithValue("cpf", Cpf);
            command.Parameters.AddWithValue("createdDate", CreatedDate);

            connection.Open();
            command.ExecuteNonQuery();
        }

        var email = new MailMessage("email@company.com", Email);
        var client = new SmtpClient()
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        email.Subject = "Hello World!";
        email.Body = "You are coding";
        client.Send(email);

        return "Customer successfully registered";
    }
}