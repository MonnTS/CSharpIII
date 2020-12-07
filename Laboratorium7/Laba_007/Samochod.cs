using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_007
{
    class Samochod
    {
        public string marka;
        public string model;
        public string paliwo;

        public string this[int j]
        {
            get
            {
                if (j == 0) return marka;
                else if (j == 1) return model;
                else if (j == 2) return paliwo;
                return "Nie podany lub zle podany";
            }

            set
            {
                if (j == 0) marka = value;
                else if (j == 1) model = value;
                else if (j == 2) paliwo = value;
            
            }
        }

    }
}
