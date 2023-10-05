namespace Architecture_Fundamentals.DesingPatterns.Behavioral.Command;

public class Calculator
{
    private int _currentValue;

    public void Operation(char operators, int value)
    {
        switch (operators)
        {
            case '+':
                _currentValue += value;
                break;
            case '-':
                _currentValue -= value;
                break;
            case '*':
                _currentValue *= value;
                break;
            case '/':
                _currentValue /= value;
                break;
        }

        Console.WriteLine("(Given {1} {2}) - Current value = {0,3}", _currentValue, operators, value);
    }
}