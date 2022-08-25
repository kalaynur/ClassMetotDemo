using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Başarıyla Eklendi");
            Console.WriteLine("Musteri Adı Soyadı" + " : " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("Hesap Numarası"+ " : "+ musteri.HesapNumarası);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri Başarıyla Silindi");
            Console.WriteLine("Musteri Adı Soyadı" + " : " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("Hesap Numarası" + " : " + musteri.HesapNumarası);
        }
    }
}
