namespace Architecture_Fundamentals.DesingPatterns.Structural.Adapter
{
    // Target class
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Default log - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Default log - " + exception.Message);
        }
    }
}