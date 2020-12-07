using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Samochod : IDetails
    {
        public String Marka { get; set; }
        public String Model { get; set; }
        public int MaxPredkosc { get; set; }

        public Samochod(string marka, string model, int maxpredkosc) 
        {
            Marka = marka;
            Model = model;
            MaxPredkosc = maxpredkosc;
        }
        public string GetInfo()
        { 
            return Marka + " " + Model + "," + " predkosc max : " + MaxPredkosc;
        }
       
    }
}
