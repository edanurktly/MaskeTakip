using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim: "Engin");
            SelamVer(isim: "Edanur");
            SelamVer();

            int sonuc = Topla(5,9);

            //Diziler / Arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Ali";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Ali";

            ogrenciler= new string[2];
            ogrenciler[3] = "Edanur";

            //for (int i = 0; i <ogrenciler.Length ; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            //string[] sehirler1 = new[] {"Ankara", "İstanbul", "İzmir"};
            //string[] sehirler2 = new[] {"Bursa", "Antalya", "Bursa"};

            //sehirler2 = sehirler1;
            //sehirler1[0] = "Adana";
            //Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity=123;

            //foreach (string sehir in sehirler1)
            //{
            //    Console.WriteLine(sehir);
            //}



            //List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            //yeniSehirler1.Add(item: "Adana 1");

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        //resharper
        static void SelamVer( string isim="isimsiz" )
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc=sayi1 + sayi2;
            Console.WriteLine("Toplam:"+ sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "merhaba";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmisMi = false;





            Console.WriteLine(tutar * 1.48);

            Console.ReadLine();
        }
    }
    //pascal casing 
   public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
