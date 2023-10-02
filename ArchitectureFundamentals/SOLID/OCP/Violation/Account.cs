namespace Architecture_Fundamentals.SOLID.OCP.Violation;

public class Account
{
    public void Debit(decimal value, string account, AccountType accountType)
    {
        if (accountType == AccountType.Checking)
        {
            //Debit
        }

        if (accountType == AccountType.Savings)
        {
            //Validate 
            //Debit
        }
    }
}