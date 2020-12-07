using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Pojazd
    {
        private string marka;
        public string GetMarka()
        {
            return marka;
        }

        public void SetMarka(string m)
        {
            marka = m;
        }


        public Pojazd(string Marka)
        {
            marka = Marka;
        }

        public Pojazd()
        {
            marka = "Brak Marki";
        }

        public virtual void GetTypPojazdu()
        {
            Console.WriteLine("Typ pojazdu: pojazd");
        }
    }
}
