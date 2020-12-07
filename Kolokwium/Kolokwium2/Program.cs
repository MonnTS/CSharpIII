using System;
using System.Collections.Generic;

/*Daniel Zujev*/
namespace Kolokwium2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Osoba> osoby = new List<Osoba>();
            Console.WriteLine("Ile chcesz dodac osob?");
            int D = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < D; i++)
            {
                Osoba n = new Osoba();
                Console.WriteLine("Osoba #{0}", i + 1);
                Console.WriteLine("Imie : ");
                n.Name = Console.ReadLine();
                Console.WriteLine("Nazwisko : ");
                n.SecondName = Console.ReadLine();
                Console.WriteLine("Rok Urodzenia : ");
                n.Age = Int32.Parse(Console.ReadLine());
                osoby.Add(n);
            }
            Console.WriteLine("Podaj rok urodzenia : ");
            int A = Int32.Parse(Console.ReadLine());

            int Starszych = 0;
            int Mlodszych = 0;
            int SamyRok = 0;

           foreach(Osoba k in osoby)
           {
                if (k.Age < A)
                {
                    Starszych++;
                }

                if (k.Age > A)
                {
                    Mlodszych++;
                }

                if (k.Age == A) 
                {
                    SamyRok++;
                }
           }
            Console.WriteLine("Starszych : " + Starszych);
            Console.WriteLine("Mlodszych : " + Mlodszych);
            Console.WriteLine("Samy Rok : " + SamyRok);
            Console.ReadKey();
        }
    }
    class Osoba
    {
        public string Name;
        public string SecondName;
        public int Age;
    }
}
