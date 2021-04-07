namespace SportsStore.TestAutomation.BasicTools
{
    class ProductManager
    {
        IBuilder builder;
        public ProductManager(IBuilder builder)
        {
            this.builder = builder;
        }

        public Product CreateProductWithAllAtributtes()
        {
            return builder.AddName(StringHelper.GetRandomString(10))
                    .AddDescription(StringHelper.GetRandomString(10))
                    .AddPrice(NumberHelper.GetRandomNumber())
                    .AddCategory(StringHelper.GetRandomString(10))
                    .Build();
        }

        public Product CreateProductWithoutName()
        {
            return builder.AddDescription(StringHelper.GetRandomString(10))
                    .AddPrice(NumberHelper.GetRandomNumber())
                    .AddCategory(StringHelper.GetRandomString(10))
                    .Build();
        }

        public Product CreateProductWithoutDescription()
        {
            return builder.AddName(StringHelper.GetRandomString(10))
                    .AddPrice(NumberHelper.GetRandomNumber())
                    .AddCategory(StringHelper.GetRandomString(10))
                    .Build();
        }
        public Product CreateProductWithoutPrice()
        {
            return builder.AddName(StringHelper.GetRandomString(10))
                    .AddDescription(StringHelper.GetRandomString(10))
                    .AddCategory(StringHelper.GetRandomString(10))
                    .Build();
        }
        public Product CreateProductWithoutCategory()
        {
            return builder.AddName(StringHelper.GetRandomString(10))
                    .AddDescription(StringHelper.GetRandomString(10))
                    .AddPrice(NumberHelper.GetRandomNumber())
                    .Build();
        }

    }
}
