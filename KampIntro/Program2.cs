using System;

namespace Lesson2_Homework6
{
    class Program2
    {
        static void Main (string[] args)
        {
            Product firsProduct = new Product();
            firsProduct.Category = "Electronic";
            firsProduct.ProductName = "Mi10";
            firsProduct.Price = 4000;

            Product secondProduct = new Product();
            secondProduct.Category = "Electronic";
            secondProduct.ProductName = "Mi11";
            secondProduct.Price = 5000;

            Product thirdProduct = new Product();
            thirdProduct.Category = "Electronic";
            thirdProduct.ProductName = "Electronic";
            thirdProduct.Price = 6000;

            Product[] product = new Product[] { firsProduct, secondProduct, thirdProduct };

            Console.WriteLine("Foreach Döngüsü");

            Console.WriteLine("");

            foreach (var Product in product)
            {
                Console.WriteLine("Ürün Kategorisi" + " : " + Product.Category);
                Console.WriteLine("Ürün İsmi" + " : " + Product.ProductName);
                Console.WriteLine( "Ürün Fiyatı" + " : " + Product.Price);
            }

            Console.WriteLine("");
            Console.WriteLine("For Döngüsü");
            Console.WriteLine("");

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine("Ürün Kategorisi" + " : " + product[i].Category);
                Console.WriteLine("Ürün İsmi" + " : " + product[i].ProductName);
                Console.WriteLine("Ürün Fiyatı" + " : " + product[i].Price);
            }

            Console.WriteLine("");
            Console.WriteLine("While Döngüsü");
            Console.WriteLine("");

            int k = 0;
            while (k<product.Length)
            {
                Console.WriteLine("Ürün Kategorisi" + " : " + product[k].Category);
                Console.WriteLine("Ürün İsmi" + " : " + product[k].ProductName);
                Console.WriteLine("Ürün Fiyatı" + " : " + product[k].Price);

                k++;
            }
        }

        public class Product
        {
            public string Category {set; get;}
            public string ProductName {set; get;}
            public int Price {set; get;}
        }
    }
}
