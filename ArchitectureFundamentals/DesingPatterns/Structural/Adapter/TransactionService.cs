namespace Architecture_Fundamentals.DesingPatterns.Structural.Adapter
{
    // Client
    public class TransactionService
    {
        private readonly ILogger _logger;

        public TransactionService(ILogger logger)
        {
            _logger = logger;
        }

        public void CarryOutTransaction()
        {
            // Transaction
            _logger.Log("Transaction carried out");
        }
    }
}