using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools.Builders.Order
{
    public class Order
    {
        public string ShipToName { get; set; }
        public Address Address { get; set; }
        public bool GifWrap { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    }
}
