using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools
{
    interface IBuilder
    {
        IBuilder AddName(string name);
        IBuilder AddDescription(string description);
        IBuilder AddPrice(decimal price);
        IBuilder AddCategory(string category);
        Product Build();
    }
}
