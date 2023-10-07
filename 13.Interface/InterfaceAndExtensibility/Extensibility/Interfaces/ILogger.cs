namespace Extensibility.Interfaces;

public interface ILogger
{
    void LogError(string message);
    void LogInfo(string message);
}
