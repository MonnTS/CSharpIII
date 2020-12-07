using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4
{
    enum Kolor : byte
    { 
        Czerwony,
        Niebieski,
        Bialy,
        Czarny,
        Zielony
    }
    class Samochod
    {
        public string marka;
        public int predkosc;
        public Kolor kolor;

        public void SetKolor(Kolor L)
        {
            kolor = L;        
        }

        public Kolor GetKolor()
        {
            return kolor;
        }

        public void InfoSamochod()
        {
            Console.WriteLine("Marka : " + this.marka);
            Console.WriteLine("Predkosc : " + this.predkosc);
            Console.WriteLine("Kolor : " + this.kolor);
            Console.WriteLine("Kolor : " + (int)kolor);
        }
    }

}
