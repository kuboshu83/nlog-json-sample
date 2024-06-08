namespace Main.Logger;

public class ApplicationLog(string applicationId, string message) : LogBase(applicationId)
{
	public string Message => message;
}
