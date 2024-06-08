namespace Main;

public class ApplicationLog(string applicationId, string message)
{
	private static string _logId => $"log-{Guid.NewGuid().ToString("N")}";
	public string LogId => _logId;
	public string ApplicationId => applicationId;
	public DateTime Timestamp => DateTime.Now;
	public string Message => message;
}
