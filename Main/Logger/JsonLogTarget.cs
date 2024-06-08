using NLog;
using NLog.Config;
using NLog.Targets;

namespace Main.Logger;
[Target("CustomJson")]
public sealed class JsonLogTarget : TargetWithLayout
{
	[RequiredParameter]
	public string DirectoryPath { get; set; } = ".";
	private readonly string _fileName;
	private string FilePath => Path.Combine(DirectoryPath, _fileName);
	private readonly object lockObject = new object();
	private bool isFirstLog = true;

	public JsonLogTarget()
	{
		var timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
		_fileName = $"log-{timestamp}.json";
	}

	protected override void InitializeTarget()
	{
		base.InitializeTarget();
		lock (lockObject)
		{
			if (!Directory.Exists(DirectoryPath))
			{
				Directory.CreateDirectory(DirectoryPath);
			}
			using var writer = new StreamWriter(FilePath, false);
			writer.WriteLine("[");
		}
	}

	protected override void Write(LogEventInfo logEvent)
	{
		var logMessage = this.Layout.Render(logEvent);
		lock (lockObject)
		{
			using var writer = new StreamWriter(FilePath, true);
			if (!isFirstLog)
			{
				writer.WriteLine(",");
			}
			writer.Write(logMessage);
			isFirstLog = false;
		}
	}

	protected override void CloseTarget()
	{
		base.CloseTarget();
		lock (lockObject)
		{
			using var writer = new StreamWriter(FilePath, true);
			writer.WriteLine("\n]");
		}
		base.CloseTarget();
	}
}
