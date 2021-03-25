namespace DesignPatterns.Proxy
{
    public class Settings : ISettings
    {
        private readonly string _config;

        public Settings(string config) => _config = config;

        public string GetConfig() => _config;
    }
}