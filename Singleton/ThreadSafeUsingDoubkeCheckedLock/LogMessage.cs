
namespace Singleton.ThreadSafeUsingDoubkeCheckedLock;

public class LogMessage
{
    public string Message { get; set; } = string.Empty;
    public LogType LogType { get; set; }
    public DateTime CreatedAt { get; set; }

    public override string ToString() => $"{LogType,7}  [{CreatedAt:yyyy-MM-dd hh:mm}] {Message}";
}
