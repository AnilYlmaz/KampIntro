//using System;

//namespace _2ndDay_6thHomework
//{
//    class Program1
//    {
//        static void Main(string[] args)
//        {
//            Product firsProduct = new Product();
//            firsProduct.Category = "Electronic";
//            firsProduct.ProductName = "Mi8 Pro";
//            firsProduct.Price = 3000;

//            Product secondProduct = new Product();
//            secondProduct.Category = "Electronic";
//            secondProduct.ProductName = "Mi9 Pro";
//            secondProduct.Price = 4000;

//            Product thirdProduct = new Product();
//            thirdProduct.Category = "Electronic";
//            thirdProduct.ProductName = "Mi10 Pro";
//            thirdProduct.Price = 5000;

//            Product[] product = new Product[] { firsProduct, secondProduct, thirdProduct };

//            Console.WriteLine("Foreach Döngüsü");

//            Console.WriteLine("");

//            foreach (var Product in product)
//            {
//                Console.WriteLine("Ürün Kategorisi" + " : " + Product.Category);
//                Console.WriteLine("Ürün Adı" + " : " + Product.ProductName);
//                Console.WriteLine("Ürün Fiyatı" + " : " + Product.Price);
//            }

//            Console.WriteLine("         ");
//            Console.WriteLine("For Döngüsü");
//            Console.WriteLine("         ");

//            for (int i = 0; i < product.Length; i++)
//            {
//                Console.WriteLine("Ürün Kategorisi" + " : " + product[i].Category);
//                Console.WriteLine("Ürün Adı" + " : " + product[i].ProductName);
//                Console.WriteLine("Ürün Fiyatı" + " : " + product[i].Price);
//            }

//            Console.WriteLine("         ");
//            Console.WriteLine("While Döngüsü");
//            Console.WriteLine("         ");

//            int k = 0;
//            while (k<product.Length)
//            {
//                Console.WriteLine("Ürün Kategorisi" + " : " + product[k].Category);
//                Console.WriteLine("Ürün Adı" + " : " + product[k].ProductName);
//                Console.WriteLine("Ürün Fiyatı" + " : " + product[k].Price);

//                k++;
//            }

//        }

//        public class Product 
//        {
//            public string Category { get; set; }
//            public string ProductName { get; set; }
//            public int Price { get; set; }        
//        }
//    }
//}
