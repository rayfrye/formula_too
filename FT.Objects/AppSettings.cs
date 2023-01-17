using System;

namespace FT.Objects
{
	public class AppSettings
	{
		public AppSettings()
		{
            
        }

        public LoggingConfig Logging { get; set; }
        public ServiceProviderConfig ServiceProviders { get; set; }
        public string AllowedHosts { get; set; }

        public class LoggingConfig
        {
            public LogLevel LogLevel { get; set; }
        }

        public class LogLevel
        {
            public string Default { get; set; }
        }

        public class ServiceProviderConfig
        {
            public string DataTeam { get; set; }
        }
    }
}

