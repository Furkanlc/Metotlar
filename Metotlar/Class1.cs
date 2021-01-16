using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //fonksiyonlar da class şeklinde yapılır mesela sepete ekle butonu birden fazla yerde kullanılır o da class seklindedir
        //naming convention - Fonksiyonlar da büyük harfle başlar
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi ; " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi ; " + urunAdi);
        }
    }
}