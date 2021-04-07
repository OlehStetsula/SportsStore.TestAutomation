using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools.Builders.Order
{
    class OrderWithAllFieldsBuilder : IOrderBuilder
    {
        private string shipToName { get; set; }
        private Address address { get; set; }
        private bool giftWrap { get; set; }

        public OrderWithAllFieldsBuilder()
        {
            shipToName = "";
            address = new Address()
            {
                Line1 = "",
                Line2 = "",
                Line3 = "",
                City = "",
                State = "",
                Country = "",
                Zip = ""
            };
        }

        public IOrderBuilder AddShipToName(string name)
        {
            shipToName = name;
            return this;
        }

        public IOrderBuilder AddAdressLine1(string adressLine1)
        {
            address.Line1 = adressLine1;
            return this;
        }

        public IOrderBuilder AddAdressLine2(string adressLine2)
        {
            address.Line2 = adressLine2;
            return this;
        }

        public IOrderBuilder AddAdressLine3(string adressLine3)
        {
            address.Line3 = adressLine3;
            return this;
        }

        public IOrderBuilder AddAdressCity(string city) 
        {
            address.City = city;
            return this;
        }

        public IOrderBuilder AddAdressState(string state)
        {
            address.State = state;
            return this;
        }

        public IOrderBuilder AddAdressCountry(string country)
        {
            address.Country = country;
            return this;
        }

        public IOrderBuilder AddAdressZip(string zip)
        {
            address.Zip = zip;
            return this;
        }

        public IOrderBuilder GiftWrap()
        {
            giftWrap = true;
            return this;
        }

        public Order Build()
        {
            return new Order()
            {
                ShipToName = shipToName,
                Address = address,
                GifWrap = giftWrap
            };
        }
    }
}
