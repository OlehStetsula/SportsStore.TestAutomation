using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools
{
    class ProductBuilder : IBuilder
    {
        Product product = new Product();

        public void AddCategory(string category)
        {
            product.Category = category;
        }

        public  void AddDescription(string description)
        {
            product.Description = description;
        }

        public void AddName(string name)
        {
            product.Nane = name;
        }

        public void AddPrice(decimal price)
        {
            product.Price = price;
        }

        public Product Build()
        {
            return product;
        }
    }
}
