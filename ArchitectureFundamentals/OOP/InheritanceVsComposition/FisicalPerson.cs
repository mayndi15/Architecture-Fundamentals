using Architecture_Fundamentals.OOP.StateVsBehavior;

namespace Architecture_Fundamentals.OOP.InheritanceVsComposition;

//Inheritance
public class FisicalPerson : Person
{
    public string Cpf { get; set; }
}

//Composition
public class FisicalPersonTwo
{
    public Person Person { get; set; }

    public string Cpf { get; set; }
}

public class Test
{
    public Test()
    {
        var inheritancePerson = new FisicalPerson
        {
            Name = "Mayndi",
            Birthday = DateTime.Now,
            Cpf = "123.456.789.10"
        };

        var compositionPerson = new FisicalPersonTwo()
        {
            Person = new Person()
            {
                Name = "Mayndi",
                Birthday = DateTime.Now
            },
            Cpf = "123.456.789.10"
        };

        var inheritanceName = inheritancePerson.Name;
        var compositionName = compositionPerson.Person.Name;
    }
}