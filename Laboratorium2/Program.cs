using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pojazd n1 = new Pojazd("PESA");
            Console.WriteLine(n1.GetMarka());
            Samochod n2 = new Samochod("Fiat");
            Console.WriteLine(n2.GetMarka());
            n2.Przyspiesz(50);
            n2.Zwolnij(10);

            Pojazd test = s1;
            test.GetTypPojazdu();

            Pojazd A1 = new Pojazd("BMW1");
            Pojazd A2 = new Pojazd("BMW2");
            Samochod D1 = new Samochod("Samokat1");
            Samochod D2 = new Samochod("Samokat2");
            Garaz.garaz.Add(A1);
            Garaz.garaz.Add(A2);
            Garaz.garaz.Add(D1);
            Garaz.garaz.Add(D2);

            Console.WriteLine("Podaj index");
            int i = Int32.Parse(Console.ReadLine());
            if(Garaz.garaz.Count>i)
            {
                Console.WriteLine("Istnieje objekt pod zadanym indeksem");
                Console.WriteLine(Garaz.garaz[i].GetMarka());
                Garaz.garaz[i].GetTypPojazdu();
            }
            else
            {
                Console.WriteLine("Brak objektu pod zadanym indeksem");
            }
        }
    }
}
