using System;

namespace DesignPatterns.Proxy
{
    public class ProtectedSettings : ISettings
    {
        private readonly AuthService _authService;
        private readonly Settings _config;

        public ProtectedSettings(AuthService authService)
        {
            _authService = authService;
            _config = new Settings("config");
        }

        public string GetConfig()
        {
            if (!_authService.Allowed)
            {
                return "Not Allowed!";
            }

            return _config.GetConfig();
        }
    }
}