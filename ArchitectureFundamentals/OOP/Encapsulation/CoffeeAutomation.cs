using Architecture_Fundamentals.OOP.Polymorphism;

namespace Architecture_Fundamentals.OOP.Encapsulation;

public class CoffeeAutomation
{
    public void ServeCoffee()
    {
        var espresso = new CoffeeMachine();
        espresso.On();
        espresso.PrepareCoffee();
        espresso.Off();
    }
}