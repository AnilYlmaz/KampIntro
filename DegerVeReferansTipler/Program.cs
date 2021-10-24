using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;  //Değer tipler STACK de tutulur stack dediğimiz şey ise
            int sayi2 = 30;  //Sayi1=10 Sayi2=30 sayi1=sayi2 derse sayi1 in değeri sayi2 nin değerine eşit
            sayi1 = sayi2;   //Yani sonuç=30
            sayi2 = 65;
            //sayi1 ??


            //HEAp de tutulur
            int[] sayilar1 = new int[] { 10, 20, 30 };  //değer tiplerde değer atanırken referans tiplerde adres atanır
            int[] sayilar2 = new int[] { 100, 200, 300 }; //yani sayilar1 tamamen sayilar2 ye atandı böylece 10,20,30 ile işimiz bitti
            sayilar1 = sayilar2;  //sonra denmiş 2 sayilar 2 nin 0. değeri 999 bizim sayilar1 sayilar2 ye atanmıştı böylece
            sayilar2[0] = 999;    //böylece sayilar1'in 0. değeri de 999 olmuş oldu
            //sayilar1[0] 999

           
           

            //int,decimal,float,double,bool= değer tip
            //array,class,interface = referans tip
        }
    }
}
