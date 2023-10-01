namespace Architecture_Fundamentals.OOP.StateVsBehavior;

public class Person
{
    //State 
    public string Name { get; set; }
    public DateTime Birthday { get; set; }

    //Behavior 
    public int CalculateAge()
    {
        var dateNow = DateTime.Now;
        var age = dateNow.Year - Birthday.Year;

        if (dateNow < Birthday.AddYears(age)) age--;
        return age;
    }
}