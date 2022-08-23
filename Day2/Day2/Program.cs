using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Product
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
        public decimal Star { get; set; }
        public decimal Price { get; set; }
        public byte Size { get; set; }
        public string Color { get; set; }
        public int Like { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product0 = new Product();
            product0.Name = "Düşük Bel Baggy Pantolon";
            product0.Code = "08674341";
            product0.Brand = "Pull&Bear";
            product0.Image = "img/product";
            product0.Star = 4.5m;
            product0.Price = 599.99m;
            product0.Size = 32;
            product0.Color = "Black";
            product0.Like = 34342;

            Product product1 = new Product();
            product1.Name = "Düşük Bel Baggy Pantolon";
            product1.Code = "08674341";
            product1.Brand = "Pull&Bear";
            product1.Image = "img/product";
            product1.Star = 4.5m;
            product1.Price = 599.99m;
            product1.Size = 32;
            product1.Color = "Black";
            product1.Like = 34342;

            Product product2 = new Product();
            product2.Name = "Düşük Bel Baggy Pantolon";
            product2.Code = "08674341";
            product2.Brand = "Pull&Bear";
            product2.Image = "img/product";
            product2.Star = 4.5m;
            product2.Price = 599.99m;
            product2.Size = 32;
            product2.Color = "Black";
            product2.Like = 34342;


            Product[] products = new Product [] {product0,product1,product2};
            for(int i=0;i<products.Length;i++)
            {
                Console.WriteLine(products[i].Brand+" "+products[i].Name+" "+products[i].Code);
                Console.WriteLine(products[i].Image+" "+products[i].Price+"Tl");
                Console.WriteLine(products[i].Size+" "+products[i].Color);
                Console.WriteLine("Like: "+products[i].Like);
                Console.WriteLine();
            }
            foreach(Product product in products)
            {
                Console.WriteLine(product.Brand+" "+product.Name+" "+product.Code);
                Console.WriteLine(product.Image+" "+product.Price+"Tl");
                Console.WriteLine(product.Size+" "+product.Color+" "+ product.Star);
                Console.WriteLine("Like: "+product.Like);
                Console.WriteLine();
            }
            int length = products.Length;
            int writer = 0;
            while (writer<length)
            {
               
                Console.WriteLine(products[writer].Brand+" "+products[writer].Name+" "+products[writer].Code);
                Console.WriteLine(products[writer].Image+" "+products[writer].Price+"Tl");
                Console.WriteLine(products[writer].Size+" "+products[writer].Color);
                Console.WriteLine("Like: "+products[writer].Like);
                Console.WriteLine();
                writer++;
            }

        }
    }
}