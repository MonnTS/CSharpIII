using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Jacht : IDetails
    {
        public String Producent { get; set; }
        public int mocSilnika { get; set; }
        public int liczbaMejsc { get; set; }

        public Jacht(string producent, int mocsilnika, int liczbamejsc)
        {
            Producent = producent;
            mocSilnika = mocsilnika;
            liczbaMejsc = liczbamejsc;
        }

        public string GetInfo()
        {
            return Producent + "," + " silnik " + mocSilnika + ", " + liczbaMejsc + " osob";
        }
    }
}
