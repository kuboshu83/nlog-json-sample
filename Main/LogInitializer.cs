using NLog;

namespace Main;
public class LogInitializer
{
	public static void Initialize()
	{
		NLog.LogManager.Setup().SetupExtensions(ext =>
		{
			ext.RegisterTarget<JsonLogTarget>();
		});
	}
}
