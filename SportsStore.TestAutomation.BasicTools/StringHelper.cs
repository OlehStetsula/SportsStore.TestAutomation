using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SportsStore.TestAutomation.BasicTools
{
    public static class StringHelper
    {
        public static string GetRandomString(int amountOfChars)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var arr = new List<char>(amountOfChars);
            arr.ForEach(n => n = chars[random.Next(36)]);
            return string.Join("", arr);
        }
    }
}
