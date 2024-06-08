namespace Main;

public class LogBase(string applicationId)
{
	private static readonly string _logId = $"log-{Guid.NewGuid().ToString("N")}";
	public string LogId => _logId;
	public DateTime Timestamp => DateTime.Now;
	public string ApplicationId => applicationId;
}
