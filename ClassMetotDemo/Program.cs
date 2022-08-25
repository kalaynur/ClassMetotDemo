using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Ad = "Ahmet";
musteri1.Soyad = "Karahoca";
musteri1.HesapNumarası = 1231231231;

Musteri musteri2 = new Musteri();
musteri2.Ad = "Bekir";
musteri2.Soyad = "Avşar";
musteri2.HesapNumarası = 127852231;

Musteri musteri3 = new Musteri();
musteri3.Ad = "Bilgin";
musteri3.Soyad = "Kocayürek";
musteri3.HesapNumarası = 872423121;

Musteri musteri4 = new Musteri();
musteri4.Ad = "Ortam";
musteri4.Soyad = "Patlatan";
musteri4.HesapNumarası = 983223121;

Musteri musteri5 = new Musteri();
musteri5.Ad = "Zeki";
musteri5.Soyad = "Yılmaz";
musteri5.HesapNumarası = 762512311;

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, };

MusteriManager musteriManager = new MusteriManager();

musteriManager.MusteriEkle(musteri1);
musteriManager.MusteriEkle(musteri2);

musteriManager.MusteriSil(musteri3);
musteriManager.MusteriSil(musteri4);




