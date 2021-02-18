using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation.BasicTools
{
    class ProductManager
    {
        IBuilder builder;
        public ProductManager(IBuilder builder)
        {
            this.builder = builder;
        }

        public Product CreateProductWithAllAtributtes(string name, string description, decimal price, string category)
        {
            builder.AddName(name);
            builder.AddDescription(description);
            builder.AddPrice(price);
            builder.AddCategory(category);
           return builder.Build();
        }

        public Product CreateProductWithoutName(string description, decimal price, string category)
        {
            builder.AddDescription(description);
            builder.AddPrice(price);
            builder.AddCategory(category);
            return builder.Build();
        }

        public Product CreateProductWithoutDescription(string name, decimal price, string category)
        {
            builder.AddName(name);
            builder.AddPrice(price);
            builder.AddCategory(category);
            return builder.Build();
        }
        public Product CreateProductWithoutPrice(string name, string description, string category)
        {
            return builder.AddName(name)
                .AddDescription(description)
                .AddCategory(category)
                .Build();
        }
        public Product CreateProductWithoutCategory(string name, string description, decimal price)
        {
            return builder.AddName(name)
                    .AddDescription(description)
                    .AddPrice(price)
                    .Build();
        }

    }
}
