using Architecture_Fundamentals.OOP.StateVsBehavior;

namespace Architecture_Fundamentals.OOP.Inheritance;

//Inheritance
public class Employee : Person
{
    public DateTime AdmissionDate { get; set; }
    public string Registry { get; set; }
}

public class Process
{
    public void Execution()
    {
        //Child class(Employee) inherits all states and behavior from the parent class(People)
        var employee = new Employee()
        {
            Name = "Mayndi Borges",
            Birthday = Convert.ToDateTime("2000/01/01"),
            AdmissionDate = DateTime.Now,
            Registry = "0123456"
        };

        employee.CalculateAge();
    }
}