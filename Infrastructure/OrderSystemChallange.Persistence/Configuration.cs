using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Persistence
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Core/OrderSystemChallange.EnvironmentConfiguration"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("localDb");

            }
        }
    }
}
