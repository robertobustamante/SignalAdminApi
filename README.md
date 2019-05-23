# SignalAdminApi
Api with basical functions for traffic asset management

In order to compile this project, you will need add a file called appsetting.json with this structure

{
  "ConnectionStrings": {
    "Dev": "You_SQL_ConnectionString_For_DEV",
    "Prod": "You_SQL_ConnectionString_For_PROD",
  },
  "ApiAuth": {
    "SecretKey": "You_JWT_Secret_String",
    "Issuer": "Usually_You_URL",
    "Audience":  "Usually_You_App_Name"

  },
  "Logging": {
    "IncludeScopes": false,
    "Debug": {
      "LogLevel": {
        "Default": "Warning"
      }
    },
    "Console": {
      "LogLevel": {
        "Default": "Warning"
      }
    }
  }
}
