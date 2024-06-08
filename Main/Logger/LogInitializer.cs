using NLog;

namespace Main.Logger;
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
