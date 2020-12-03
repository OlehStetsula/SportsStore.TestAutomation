using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation
{
    class DriverManagerFactory
    {
        public static DriverManager getManager(DriverType type)
        {
            DriverManager driverManager;
            switch (type)
            {
                case DriverType.Chrome:
                    driverManager = new ChromeDriverManager();
                    break;
                case DriverType.Firefox:
                    driverManager = new FirefoxDriverManager();
                    break;
                case DriverType.Remote:
                    driverManager = new RemoteDriverManager();
                    break;
                default:
                    throw new ArgumentException($"This type '{type.ToString()}' of DriverManager is not implemented");
            }
            return driverManager;
        }
    }

    public enum DriverType
    {        
        Chrome,
        Firefox,
        IE,
        Edge,
        Safari,
        Remote
    }
}
