namespace Architecture_Fundamentals.SOLID.OCP.Solution_Extension_Methods;

public static class DebitAccountSavings
{
    public static string DebitSavings(this DebitAccount debitAccount)
    {
        return debitAccount.FormatTransaction();
    }
}