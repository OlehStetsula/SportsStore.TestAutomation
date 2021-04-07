using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools.Builders.Order
{
    interface IOrderBuilder
    {
        public IOrderBuilder AddShipToName(string name);
        public IOrderBuilder AddAdressLine1(string adressLine1);
        public IOrderBuilder AddAdressLine2(string adressLine2);
        public IOrderBuilder AddAdressLine3(string adressLine3);
        public IOrderBuilder AddAdressCity(string city);
        public IOrderBuilder AddAdressState(string state);
        public IOrderBuilder AddAdressCountry(string country);
        public IOrderBuilder AddAdressZip(string zip);
        public IOrderBuilder GiftWrap();
        public Order Build();
    }
}
