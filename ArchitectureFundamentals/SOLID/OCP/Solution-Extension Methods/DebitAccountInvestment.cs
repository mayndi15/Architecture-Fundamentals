namespace Architecture_Fundamentals.SOLID.OCP.Solution_Extension_Methods;

public static class DebitAccountInvestment
{
    public static string DebitInvestment(this DebitAccount debitAccount)
    {
        return debitAccount.FormatTransaction();
    }
}