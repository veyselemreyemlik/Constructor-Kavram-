using System;

namespace Kurucu_Metotlar
{
    class Canli
    {
        public string adı;
        public string turu;
        public int yası;
        public int kilo;

        public Canli()
        {
        }

        public Canli(string Adı , string Turu , int Yası , int Kilo)
        {
            turu = Turu;
            adı = Adı;
            yası = Yası;
            kilo = Kilo;
        }

        public void CanliYazdir()
        {
            Console.WriteLine("Canlının Adı :" +" "+ adı);
            Console.WriteLine("Canlının Türü : " +" "+ turu);
            Console.WriteLine("Canlının Yaşı :" +" "+ yası);
            Console.WriteLine("Canlının Kilosu :" +" "+ kilo);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Canli canli = new Canli();
            canli.adı = "Aslan";
            canli.turu = "Panthera";
            canli.yası = 10;
            canli.kilo = 100;
            canli.CanliYazdir();

            Console.WriteLine("**********************************");

            Canli canli2 = new Canli("Leylek" ,"Kuş" , 5 , 50 );
            canli2.CanliYazdir();
        }
    }
}
