namespace Architecture_Fundamentals.SOLID.OCP.Solution_Extension_Methods;

public static class DebitAccountChecking
{
    public static string DebitChecking(this DebitAccount debitAccount)
    {
        return debitAccount.FormatTransaction();
    }
}