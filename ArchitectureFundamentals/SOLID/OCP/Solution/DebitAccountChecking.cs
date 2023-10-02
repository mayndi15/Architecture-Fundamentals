namespace Architecture_Fundamentals.SOLID.OCP.Solution;

public class DebitAccountChecking : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        //Debit
        return FormatTransaction();
    }
}