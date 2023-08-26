using System;


public class DataHelper
{
    public static string GetStringDB(IConfiguration configuration)
    {
        var devEnviroment = configuration["DbConnection:Railway"];
        var productionEnviroment = Environment.GetEnvironmentVariable("DATABASE_URL");
        return string.IsNullOrEmpty(productionEnviroment) ? devEnviroment : productionEnviroment;
    }
}