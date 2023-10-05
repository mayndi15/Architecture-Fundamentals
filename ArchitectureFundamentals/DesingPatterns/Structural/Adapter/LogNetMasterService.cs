namespace Architecture_Fundamentals.DesingPatterns.Structural.Adapter
{
    // Adapter class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Custom log - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Custom log - " + exception.Message);
        }
    }
}