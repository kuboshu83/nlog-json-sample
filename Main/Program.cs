using Main;
using NLog;


LogInitializer.Initialize();
var logger = LogManager.GetCurrentClassLogger();
logger.Info("{user}", new AppLog("akira", 19));
logger.Info("{user}", new AppLog("alice", 13));
logger.Info("{user}", new AppLog("akari", 15));
logger.Info("hoge");