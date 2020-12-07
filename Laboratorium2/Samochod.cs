using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Samochod : Pojazd
    {
        int liczbaKol;
        public void Przyspiesz(int a)
        {
            Console.WriteLine("Przyspieszyl o " + a + " km/h");
        }

        public void Zwolnij(int a)
        {
            Console.WriteLine("Zwolnil o " + a +" km/h");
        }

        public Samochod(string Marka) : base (Marka)
        {
            
        }

        public Samochod() : base()
        {

        }

        public override void GetTypPojazdu()
        {
            Console.WriteLine("Typ pojazdu: samochod");
        }
    }
}
