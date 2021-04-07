using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools
{
    class ProductBuilder : IBuilder
    {
        private string category;
        private string description;
        private string name;
        private decimal price;

        public IBuilder AddCategory(string category)
        {
            this.category = category;
            return this;
        }

        public IBuilder AddDescription(string description)
        {
            this.description = description;
            return this;
        }

        public IBuilder AddName(string name)
        {
            this.name = name;
            return this;
        }

        public IBuilder AddPrice(decimal price)
        {
            this.price = price;
            return this;
        }

        public Product Build()
        {
            return new Product()
            { 
                Nane = name,
                Description = description,
                Price = price,
                Category = category
            };
        }
    }
}
