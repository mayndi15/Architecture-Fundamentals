namespace Architecture_Fundamentals.SOLID.DIP.Violation;

public class CustomerService
{
    public string Add(Customer customer)
    {
        if (!customer.Validate())
            return "Invalid data";

        var repository = new CustomerRepository();
        repository.Add(customer);

        EmailService.Send("email@company.com", customer.Email.Address, "Hello World!", "You are coding");

        return "Customer successfully registered";
    }
}