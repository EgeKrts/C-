using System;

namespace MethodInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kisiler kisiler = new Kisiler();

             Console.Write("Adınızı ve Soyadınızı Giriniz : ");
             string kisi =Console.ReadLine();

             kisiler.kisiListesi(kisi);*/


            /* Islem islem = new Islem();

             islem.topla(7,6);

             islem.küp(5);*/

            Kimlik kimlik = new Kimlik();
            kimlik.AD = "Ege";
            kimlik.SOYAD = "Karataş";
            kimlik.CINSIYET = 'E';
            kimlik.YAS = 21;
            kimlik.MEMLEKET = "Denizli";
            Console.WriteLine("Ad : "+kimlik.AD);
            Console.WriteLine("Soyad: "+kimlik.SOYAD);
            Console.WriteLine("Cinsiyet: "+kimlik.CINSIYET);
            Console.WriteLine("Yaş: "+kimlik.YAS);
            Console.WriteLine("Dogum yeri: "+kimlik.MEMLEKET);
            Console.Read();

        }
    }
}
