using Main;
using NLog;

LogInitializer.Initialize();

var logger = LogManager.GetCurrentClassLogger();
logger.Info("hoge");
logger.Info("moge");
logger.Info("piyo");