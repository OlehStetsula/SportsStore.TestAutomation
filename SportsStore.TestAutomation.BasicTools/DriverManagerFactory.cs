using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools
{
    public class DriverManagerFactory
    {
        public static DriverManager GetDriverManager(DriverType driverType)
        {
            DriverManager driverManager;
            switch (driverType)
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
                    throw new Exception();
            }

            return driverManager;
        }
    }

    public enum DriverType
    { 
        Chrome,
        Firefox,
        Remote
    }
}
