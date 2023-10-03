using Architecture_Fundamentals.SOLID.DIP.Solution.Interfaces;

namespace Architecture_Fundamentals.SOLID.DIP.Solution;

public class CustomerServices : ICustomerServices
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IEmailService _emailService;

    public CustomerServices(ICustomerRepository customerRepository, IEmailService emailService)
    {
        _customerRepository = customerRepository;
        _emailService = emailService;
    }

    public string Add(Customer customer)
    {
        if (!customer.Validate())
            return "Invalid data";

        _customerRepository.Add(customer);
        _emailService.Send("email@company.com", customer.Email.Address, "Hello World!", "You are coding");

        return "Customer successfully registered";
    }
}