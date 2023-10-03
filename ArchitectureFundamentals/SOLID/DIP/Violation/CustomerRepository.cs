using System.Data;
using System.Data.SqlClient;

namespace Architecture_Fundamentals.SOLID.DIP.Violation;

public class CustomerRepository
{
    public void Add(Customer customer)
    {
        using (var connection = new SqlConnection())
        {
            var command = new SqlCommand();

            connection.ConnectionString = "DbConnectionString";
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText =
                "INSERT INTO Customer (name, email, cpf, createdDate) VALUES (@name, @email, @cpf, @createdDate)";

            command.Parameters.AddWithValue("name", customer.Name);
            command.Parameters.AddWithValue("email", customer.Email);
            command.Parameters.AddWithValue("cpf", customer.Cpf);
            command.Parameters.AddWithValue("createdDate", customer.CreatedDate);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}