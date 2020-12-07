using System;
using System.IO;

namespace Laba06
{
    class Program
    {
        public static void WriteTXT()
        {
            String[] lines = new String[Garaz.listaSamochodow.Count * 3];
            int i = 0;
            foreach (Samochod car in Garaz.listaSamochodow)
            {
                lines[i] = car.marka;
                lines[i + 1] = car.model;
                lines[i + 2] = car.predkosc.ToString();
                i += 3;
            }
            File.WriteAllLines(@"D:\samochody.txt", lines);
        }

        public static void ReadTXT() 
            
        {
            if (!File.Exists(@"D:\samochody.txt"))
            { 
                Console.WriteLine(@"Brak Pliku D:\samochody.txt");
                return;
            }

            Garaz.listaSamochodow.Clear();
            String[] Lines = File.ReadAllLines(@"D:\samochody.txt");
            int o = 0;
            Samochod samochod = new Samochod();
            foreach (string Line in Lines)
            {
                if (o == 0) { 
                    samochod.marka = Line;
                    o++;
                }

                if (o == 1) {
                    samochod.model = Line;
                    o++;
                } 

                else if(o == 2)
                {
                    samochod.predkosc = Int32.Parse(Console.ReadLine());
                    Garaz.listaSamochodow.Add(samochod);
                    samochod = new Samochod();
                    o = 0;
                }
            }
        }

        static void Main(string[] args)
        {
            string dalej = "t";
            while (dalej != "n")
            {
                ReadTXT();
                Console.WriteLine("Lista samochodów: ");
                foreach (Samochod samochod in Garaz.listaSamochodow)
                {
                    Console.WriteLine(samochod.marka + " " + samochod.model + " " + samochod.predkosc);
                }

                Console.WriteLine("Ile samochodow dodac:");
                int n = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Samochod neiw = new Samochod();
                    Console.WriteLine("Podaj marke:");
                    neiw.marka = Console.ReadLine();
                    Console.WriteLine("Podaj model");
                    neiw.model = Console.ReadLine();
                    Console.WriteLine("Podaj predkosc:");
                    neiw.predkosc = Int32.Parse(Console.ReadLine());
                    Garaz.listaSamochodow.Add(neiw);
                    WriteTXT();
                }
                Console.WriteLine("Jeszcze raz? t/n");
                dalej = Console.ReadLine();
            }

        }
    }
}
