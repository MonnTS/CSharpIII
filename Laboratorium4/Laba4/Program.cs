using System;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod();
            samochod1.marka = "Opel";
            samochod1.predkosc = 50;
            samochod1.kolor = Kolor.Niebieski;
            samochod1.InfoSamochod();

            samochod1.kolor = Kolor.Bialy;
            samochod1.InfoSamochod();
            foreach (Kolor kolor in Enum.GetValues(typeof(Kolor)))
            {
                Console.WriteLine(kolor + " " + (int)kolor);
            }

            Console.WriteLine("Ile chcesz dodac samochodow?");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Tworzy nowy Samochod");
            for (int i = 0; i < x; i++)
            {
                Samochod samochod_n = new Samochod();
                Console.WriteLine("Podaj Marke : ");
                samochod_n.marka = Console.ReadLine();
                Console.WriteLine("Podaj Predkosc : ");
                samochod_n.predkosc = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj Kolor : ");

                foreach (Kolor kolor in Enum.GetValues(typeof(Kolor)))
                {
                    Console.WriteLine(kolor + " " + (int)kolor);
                }
                samochod_n.SetKolor((Kolor)Int32.Parse(Console.ReadLine()));
                Garaz.AddPojazd(samochod_n);
            }

            int d = 0;
            foreach (Samochod samochod_x in Garaz.garaz)
            {
                Console.WriteLine("Index : " + d);
                samochod_x.InfoSamochod();
                d++;
            }

            string zmiana = "t";
            int num = 0;
            Kolor nk;
            while (zmiana != "n")
            {
                Console.WriteLine("Chcesz zmienic kolor samochodu? [t/n]");
                zmiana = Console.ReadLine();

                if (zmiana == "t")
                {
                    Console.WriteLine("Podaj numer samochodu : ");
                    num = Int32.Parse(Console.ReadLine());
                    foreach (Kolor kolor in Enum.GetValues(typeof(Kolor)))
                    {
                        Console.WriteLine(kolor + " " + (int)kolor);
                    }

                    Console.WriteLine("Podaj nowy kolor: ");
                    nk = (Kolor)Int32.Parse(Console.ReadLine());
                    Garaz.garaz[num].SetKolor(nk);
                }

                d = 0;
                foreach (Samochod auto in Garaz.garaz)
                {
                    Console.WriteLine("Index : " + d);
                    auto.InfoSamochod();
                    d++;
                }
             
            } 
        }
    }
}
