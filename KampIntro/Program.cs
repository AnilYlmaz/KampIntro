////using System;

////namespace KampIntro
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Product firstProduct = new Product();
////            firstProduct.Category = "Electronic";
////            firstProduct.ProductName = "Iphone6";
////            firstProduct.Price = 3000;

////            Product secondProduct = new Product();
////            secondProduct.Category = "Electronic";
////            secondProduct.ProductName = "Iphone7";
////            secondProduct.Price = 4000;

////            Product thirdProduct = new Product();
////            thirdProduct.Category = "Electronic";
////            thirdProduct.ProductName = "Iphone8";
////            thirdProduct.Price = 5000;


////            Console.WriteLine(firstProduct.Category + " : " + secondProduct.Price);
////        }
////    }
////}


////class Product
////{
////    public string Category { get; set; }
////    public string ProductName { get; set; }
////    public int Price { get; set; }
////}

//using System;

//namespace _2ndDay_6thHomework
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Product product1 = new Product();         
//            product1.productName = "Matematik Kitabı";
//            product1.productCategory = "Kitap";
//            product1.productCategoryId = 1;

//            Product product2 = new Product();        
//            product2.productName = "Tükenmez Kalem";
//            product2.productCategory = "Kalem";
//            product2.productCategoryId = 2;

//            Product product3 = new Product();  
//            product2.productName = "İngilizce Sözlük";
//            product2.productCategory = "Sözlük";
//            product2.productCategoryId = 3;

//            Product[] product = new Product[] { product1, product2, product3 };

//            Console.WriteLine("Foreach döngüsü:");

//            Console.WriteLine("         ");

//            foreach (var pro in product)
//            {              
//                Console.WriteLine("Ürün Adı" + ":" + pro.productName);
//                Console.WriteLine("Ürün Kategorisi" + ":" + pro.productCategory);
//                Console.WriteLine("Ürün Kategori Id" + ":" + pro.productCategoryId);

//            }

            
//            Console.WriteLine("For Döngüsü");
//            Console.WriteLine("         ");

//            for (int i = 0; i < product.Length; i++)
//            {            
//                Console.WriteLine("Ürün Adı" + ":" + product[i].productName);
//                Console.WriteLine("Ürün Kategorisi" + ":" + product[i].productCategory);
//                Console.WriteLine("Ürün Kategori Id" + ":" + product[i].productCategoryId);
//            }

//            Console.WriteLine("         ");
//            Console.WriteLine("While Döngüsü:");
//            Console.WriteLine("         ");

//            int k = 0;
//            while (k < product.Length)
//            {
         
//                Console.WriteLine("Ürün Adı" + ":" + product[k].productName);
//                Console.WriteLine("Ürün Kategorisi" + ":" + product[k].productCategory);
//                Console.WriteLine("Ürün Kategori Id" + ":" + product[k].productCategoryId);

//                k++;
//            }

//        }

//        public class Product
//        {           
//            public string productName { get; set; }
//            public string productCategory { get; set; }
//            public int productCategoryId { get; set; }
//        }
//    }
//}