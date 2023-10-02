namespace Architecture_Fundamentals.SOLID.OCP.Solution;

public class DebitAccountInvestment : DebitAccount
{
    public override string Debit(decimal value, string account)
    {
        //Debit
        //Exempt tax
        return FormatTransaction();
    }
}