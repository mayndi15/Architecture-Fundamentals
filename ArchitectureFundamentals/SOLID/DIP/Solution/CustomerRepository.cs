using System.Data;
using System.Data.SqlClient;
using Architecture_Fundamentals.SOLID.DIP.Solution.Interfaces;

namespace Architecture_Fundamentals.SOLID.DIP.Solution;

public class CustomerRepository : ICustomerRepository
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