﻿using Main;
using NLog;

// アプリケーション起動時のオプションで設定する
var applicationId = $"app-{Guid.NewGuid().ToString("N")}";

LogInitializer.Initialize();
var logger = LogManager.GetCurrentClassLogger();
logger.Info("{@applicationLog}", new ApplicationLog(applicationId, "sample info"));
logger.Warn("{@applicationLog}", new ApplicationLog(applicationId, "sample warn"));
logger.Info("{@applicationLog}", new ApplicationLog(applicationId, "sample error"));