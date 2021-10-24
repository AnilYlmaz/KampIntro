using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //normal parantez varsa metot çalışıyor
        public void Ekle(Urun urun) //parantez içine metot imzası deniyor
        {
            Console.WriteLine("Tebrikler Sepete eklendi :" + urun.Adi); //sağlıklı olan yapı bu encapsulationa uyan da bu
              
        } 

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        // Buraya yeni bir şey eklersem programcs de bütün Ekle2 ler patlar çünkü biz metot imzsına uymuyoruz
        {
            Console.WriteLine("Tebrikler. Sepete eklendi  : " + urunAdi);  

        }
    }
}
