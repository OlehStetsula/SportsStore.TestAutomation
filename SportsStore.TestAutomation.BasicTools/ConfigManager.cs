using Microsoft.Extensions.Configuration;



namespace SportsStore.TestAutomation.BasicTools
{
    public class ConfigManager
    {
        private readonly IConfiguration configuration;
        private static ConfigManager configManager;
        private ConfigManager()
        {
            configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<ConfigManager>()
                .Build();
        }

        public static ConfigManager InitConfigManager()
        {
            if (configManager == null)
                configManager = new ConfigManager();
            return configManager;
        }

        public string GetValue(string key)
        {
            return configuration[key];
        }
    }
}
