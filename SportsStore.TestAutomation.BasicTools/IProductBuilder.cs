using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools
{
    interface IBuilder
    {
        void AddName(string name);
        void AddDescription(string description);
        void AddPrice(decimal price);
        void AddCategory(string category);
        Product Build();
    }
}
