# C#で Json のログを吐き出す

# NLog

- 5.3.2

# 実行

```bash
dotnet run --project Main
```

# 結果

## ログファイル

実行の度に./logs/に以下のフォーマットのログファイルが作成されます。

- log-yyyyMMddHHmmssffff.json

また、ファイルの内容は以下のようになります。

```json
[
  {
    "message": "{\"Message\":\"sample info\", \"LogId\":\"log-b1a5fb41219c4040b82ef8c7c796eca4\", \"Timestamp\":\"2024-06-08T10:13:16.361184Z\", \"ApplicationId\":\"app-7614009df905448f813c2c3a4f6831f1\"}",
    "level": "INFO",
    "properties": {
      "applicationLog": {
        "Message": "sample info",
        "LogId": "log-b1a5fb41219c4040b82ef8c7c796eca4",
        "Timestamp": "2024-06-08T10:13:16.388797Z",
        "ApplicationId": "app-7614009df905448f813c2c3a4f6831f1"
      }
    }
  },
  {
    "message": "{\"Message\":\"sample warn\", \"LogId\":\"log-b1a5fb41219c4040b82ef8c7c796eca4\", \"Timestamp\":\"2024-06-08T10:13:16.389404Z\", \"ApplicationId\":\"app-7614009df905448f813c2c3a4f6831f1\"}",
    "level": "WARN",
    "properties": {
      "applicationLog": {
        "Message": "sample warn",
        "LogId": "log-b1a5fb41219c4040b82ef8c7c796eca4",
        "Timestamp": "2024-06-08T10:13:16.389475Z",
        "ApplicationId": "app-7614009df905448f813c2c3a4f6831f1"
      }
    }
  },
  {
    "message": "{\"Message\":\"sample error\", \"LogId\":\"log-b1a5fb41219c4040b82ef8c7c796eca4\", \"Timestamp\":\"2024-06-08T10:13:16.389621Z\", \"ApplicationId\":\"app-7614009df905448f813c2c3a4f6831f1\"}",
    "level": "INFO",
    "properties": {
      "applicationLog": {
        "Message": "sample error",
        "LogId": "log-b1a5fb41219c4040b82ef8c7c796eca4",
        "Timestamp": "2024-06-08T10:13:16.389647Z",
        "ApplicationId": "app-7614009df905448f813c2c3a4f6831f1"
      }
    }
  }
]
```

## コンソール

コンソールには以下のように表示されます

```bash
2024-06-08 19:13:16.3497|INFO|Main.Program|{"Message":"sample info", "LogId":"log-b1a5fb41219c4040b82ef8c7c796eca4", "Timestamp":"2024-06-08T10:13:16.361184Z", "ApplicationId":"app-7614009df905448f813c2c3a4f6831f1"}
2024-06-08 19:13:16.3893|WARN|Main.Program|{"Message":"sample warn", "LogId":"log-b1a5fb41219c4040b82ef8c7c796eca4", "Timestamp":"2024-06-08T10:13:16.389404Z", "ApplicationId":"app-7614009df905448f813c2c3a4f6831f1"}
2024-06-08 19:13:16.3893|INFO|Main.Program|{"Message":"sample error", "LogId":"log-b1a5fb41219c4040b82ef8c7c796eca4", "Timestamp":"2024-06-08T10:13:16.389621Z", "ApplicationId":"app-7614009df905448f813c2c3a4f6831f1"}
```
