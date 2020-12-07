using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4
{
    class Garaz
    {
        public static List<Samochod> garaz = new List<Samochod>();
        public static void AddPojazd(Samochod samochod)
        {
            garaz.Add(samochod);
        }

        public static Samochod GetPojazd(int i)
        {
            return garaz[i];
        }
    }
}
