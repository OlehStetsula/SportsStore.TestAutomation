using SportsStore.TestAutomation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.AutoTests.Pages
{
    public class PageFactory
    {
        public T CreatePage<T>(DriverManager driverManager) where T : BasePage, new() 
        {
            T page = new T();
            page.SetDriverManager(driverManager);
            return page;
        }
    }
}
