using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools
{
    public static class NumberHelper
    {
        public static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }
    }
}
