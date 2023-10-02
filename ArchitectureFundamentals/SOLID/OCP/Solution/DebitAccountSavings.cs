namespace Architecture_Fundamentals.SOLID.OCP.Solution;

public class DebitAccountSavings : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        //Validate
        //Debit
        return FormatTransaction();
    }
}