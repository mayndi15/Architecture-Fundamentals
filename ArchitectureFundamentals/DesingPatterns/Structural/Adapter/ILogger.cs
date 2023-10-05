namespace Architecture_Fundamentals.DesingPatterns.Structural.Adapter
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}