namespace Architecture_Fundamentals.DesingPatterns.Structural.Adapter;

public class AdapterExecution
{
    public static void Execute()
    {
        var paymentLogDefault = new TransactionService(new Logger());
        paymentLogDefault.CarryOutTransaction();

        var paymentLogCustom = new TransactionService(new LogAdapter(new LogNetMasterService()));
        paymentLogCustom.CarryOutTransaction();
    }
}