using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ebru";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkan Bilgin";
            kurs3.IzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOranı = 100;

            //Command line-yorum satırı
            //Console.WriteLine(kurs1.KursAdi + " ; "+ kurs1.Egitmen);

            //string[] kurslar = new string[] {}   Böyle yazınca sadece içinde string tutuyorduk kurs yazınca kurs ların objelerini tutabiliyoruz.
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2 ,kurs3 ,kurs4};

            foreach (var  kurs in  kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " ; " + kurs.Egitmen);
            }

            //Console.WriteLine("Hello World!");
        }
    }
    // class kursla yeni bi değişken türü gibi bişey oluşturmuş oluyoruz - tipimiz kurs oluyo
    class Kurs
    {
        //prop (özellik anlamında) yazıp tab tab yapıyoruz
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
