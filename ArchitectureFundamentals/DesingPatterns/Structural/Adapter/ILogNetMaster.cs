namespace Architecture_Fundamentals.DesingPatterns.Structural.Adapter
{
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}