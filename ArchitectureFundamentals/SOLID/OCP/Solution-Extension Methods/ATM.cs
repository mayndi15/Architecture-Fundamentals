namespace Architecture_Fundamentals.SOLID.OCP.Solution_Extension_Methods;

public class ATM
{
    public static void Operations()
    {
        OperationMenu();

        var options = Console.ReadKey();
        var result = string.Empty;

        var debitAccount = DebitData();

        switch (options.KeyChar)
        {
            case '1':
                Console.WriteLine("Carrying out a Checking Account operation...");
                result = debitAccount.DebitChecking();
                break;
            case '2':
                Console.WriteLine("Carrying out a Savings Account operation...");
                result = debitAccount.DebitSavings();
                break;
            case '3':
                Console.WriteLine("Carrying out a Investment Account operation...");
                result = debitAccount.DebitInvestment();
                break;
        }

        TransactionResult(result);
    }

    private static void OperationMenu()
    {
        Console.Clear();
        Console.WriteLine("ATM");
        Console.WriteLine("Choose your option:");
        Console.WriteLine();
        Console.WriteLine("1 - Checking account");
        Console.WriteLine("2 - Savings account");
        Console.WriteLine("3 - Investment account");
    }

    private static DebitAccount DebitData()
    {
        Console.WriteLine();
        Console.WriteLine("..............................");
        Console.WriteLine();
        Console.WriteLine("Enter your account");
        var accountNumber = Console.ReadLine();
        Console.WriteLine("Enter the value");
        var value = Convert.ToDecimal(Console.ReadLine());

        var debitAccount = new DebitAccount()
        {
            AccountNumber = accountNumber,
            Value = value
        };

        return debitAccount;
    }

    private static void TransactionResult(string result)
    {
        Console.WriteLine();
        Console.WriteLine("Success! Transaction: " + result);
        Console.ReadKey();
    }
}